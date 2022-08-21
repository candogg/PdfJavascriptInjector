using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Action;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfInjector
{
    public partial class PdfInjector : Form
    {
        private readonly SynchronizationContext context;

        public PdfInjector()
        {
            InitializeComponent();

            context = SynchronizationContext.Current;
        }

        private void PctClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnSelectPdf_Click(object sender, EventArgs e)
        {
            SelectPdfFileDialog.ShowDialog();
        }

        private void SelectPdfFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!File.Exists(SelectPdfFileDialog.FileName))
            {
                MessageBox.Show("File not valid!");

                return;
            }

            TxtPdfPath.Text = SelectPdfFileDialog.FileName;
        }

        private Task<string> InjectToPdf(string pdfFilePath, string code)
        {
            return Task.Run(() =>
            {
                var fileExtension = Path.GetExtension(pdfFilePath);
                var fileName = Path.GetFileNameWithoutExtension(pdfFilePath);

                var newFileName = $"{fileName}_jsInjected_{DateTime.Now:yyyyMMddHHmmssfff}{fileExtension}";

                using (var reader = new PdfReader(pdfFilePath))
                {
                    var writer = new PdfWriter(newFileName);

                    using (var pdfdoc = new PdfDocument(reader, writer))
                    {
                        PdfAction action = PdfAction.CreateJavaScript(TxtCode.Text);
                        pdfdoc.GetCatalog().SetOpenAction(action);
                        pdfdoc.Close();
                    }
                }

                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, newFileName); ;
            });
        }

        private void BtnInject_Click(object sender, EventArgs e)
        {
            BtnInject.Enabled = false;

            InjectToPdf(SelectPdfFileDialog.FileName, TxtCode.Text).ContinueWith(result =>
            {
                context.Post(_ =>
                {
                    TxtPdfPath.Text = string.Empty;
                    TxtCode.Text = "app.alert('Your Message');";

                    BtnInject.Enabled = true;

                    if (MessageBox.Show($"Injection completed!\n\nNew file saved to {result.Result}\n\nDo you want to open file?", "File Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Process.Start(result.Result);
                    }
                }, null);
            });
        }
    }
}
