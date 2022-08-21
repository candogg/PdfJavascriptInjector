namespace PdfInjector
{
    partial class PdfInjector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PctClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPdfPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSelectPdf = new System.Windows.Forms.Button();
            this.BtnInject = new System.Windows.Forms.Button();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectPdfFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PctClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PctClose
            // 
            this.PctClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PctClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctClose.Image = global::PdfInjector.Properties.Resources.delete_icon;
            this.PctClose.Location = new System.Drawing.Point(523, 5);
            this.PctClose.Margin = new System.Windows.Forms.Padding(4);
            this.PctClose.Name = "PctClose";
            this.PctClose.Size = new System.Drawing.Size(24, 24);
            this.PctClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PctClose.TabIndex = 0;
            this.PctClose.TabStop = false;
            this.PctClose.Click += new System.EventHandler(this.PctClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "canp0w3R PDF Injector";
            // 
            // TxtPdfPath
            // 
            this.TxtPdfPath.BackColor = System.Drawing.Color.Black;
            this.TxtPdfPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPdfPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtPdfPath.Location = new System.Drawing.Point(17, 84);
            this.TxtPdfPath.Name = "TxtPdfPath";
            this.TxtPdfPath.ReadOnly = true;
            this.TxtPdfPath.Size = new System.Drawing.Size(349, 26);
            this.TxtPdfPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select PDF File Below";
            // 
            // BtnSelectPdf
            // 
            this.BtnSelectPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSelectPdf.Location = new System.Drawing.Point(372, 81);
            this.BtnSelectPdf.Name = "BtnSelectPdf";
            this.BtnSelectPdf.Size = new System.Drawing.Size(175, 32);
            this.BtnSelectPdf.TabIndex = 4;
            this.BtnSelectPdf.Text = "Select PDF File";
            this.BtnSelectPdf.UseVisualStyleBackColor = true;
            this.BtnSelectPdf.Click += new System.EventHandler(this.BtnSelectPdf_Click);
            // 
            // BtnInject
            // 
            this.BtnInject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnInject.Location = new System.Drawing.Point(372, 293);
            this.BtnInject.Name = "BtnInject";
            this.BtnInject.Size = new System.Drawing.Size(175, 32);
            this.BtnInject.TabIndex = 6;
            this.BtnInject.Text = "INJECT!";
            this.BtnInject.UseVisualStyleBackColor = true;
            this.BtnInject.Click += new System.EventHandler(this.BtnInject_Click);
            // 
            // TxtCode
            // 
            this.TxtCode.BackColor = System.Drawing.Color.Black;
            this.TxtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtCode.Location = new System.Drawing.Point(17, 144);
            this.TxtCode.Multiline = true;
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(349, 181);
            this.TxtCode.TabIndex = 5;
            this.TxtCode.Text = "app.alert(\'Your Message\');";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Javascript Code";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(-4, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(599, 1);
            this.label4.TabIndex = 1;
            // 
            // SelectPdfFileDialog
            // 
            this.SelectPdfFileDialog.Filter = "PDF Files|*.pdf";
            this.SelectPdfFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SelectPdfFileDialog_FileOk);
            // 
            // PdfInjector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(557, 337);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnInject);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.BtnSelectPdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPdfPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PctClose);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(557, 337);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(557, 337);
            this.Name = "PdfInjector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PdfInjector";
            ((System.ComponentModel.ISupportInitialize)(this.PctClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPdfPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSelectPdf;
        private System.Windows.Forms.Button BtnInject;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog SelectPdfFileDialog;
    }
}

