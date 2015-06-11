namespace WinFormStudy
{
    partial class MainForm
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
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.txtSampleText = new System.Windows.Forms.TextBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.grpBar = new System.Windows.Forms.GroupBox();
            this.tbDummy = new System.Windows.Forms.TrackBar();
            this.pgDummy = new System.Windows.Forms.ProgressBar();
            this.btnModal = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.grpFont.SuspendLayout();
            this.grpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).BeginInit();
            this.grpForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.txtSampleText);
            this.grpFont.Controls.Add(this.chkItalic);
            this.grpFont.Controls.Add(this.chkBold);
            this.grpFont.Controls.Add(this.cboFont);
            this.grpFont.Controls.Add(this.lblFont);
            this.grpFont.Location = new System.Drawing.Point(13, 13);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(488, 72);
            this.grpFont.TabIndex = 0;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "ComboBox,CheckBox,TextBox";
            // 
            // txtSampleText
            // 
            this.txtSampleText.Location = new System.Drawing.Point(24, 36);
            this.txtSampleText.Name = "txtSampleText";
            this.txtSampleText.Size = new System.Drawing.Size(294, 21);
            this.txtSampleText.TabIndex = 4;
            this.txtSampleText.Text = "Hello, C#";
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkItalic.Location = new System.Drawing.Point(258, 16);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(60, 16);
            this.chkItalic.TabIndex = 3;
            this.chkItalic.Text = "이탤릭";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkBold.Location = new System.Drawing.Point(204, 16);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(50, 16);
            this.chkBold.TabIndex = 2;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(58, 12);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(121, 20);
            this.cboFont.TabIndex = 1;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(22, 21);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(29, 12);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Font";
            // 
            // grpBar
            // 
            this.grpBar.Controls.Add(this.pgDummy);
            this.grpBar.Controls.Add(this.tbDummy);
            this.grpBar.Location = new System.Drawing.Point(13, 91);
            this.grpBar.Name = "grpBar";
            this.grpBar.Size = new System.Drawing.Size(488, 82);
            this.grpBar.TabIndex = 5;
            this.grpBar.TabStop = false;
            this.grpBar.Text = "TrackBar && ProgressBar";
            // 
            // tbDummy
            // 
            this.tbDummy.Location = new System.Drawing.Point(3, 17);
            this.tbDummy.Maximum = 20;
            this.tbDummy.Name = "tbDummy";
            this.tbDummy.Size = new System.Drawing.Size(479, 45);
            this.tbDummy.TabIndex = 0;
            this.tbDummy.Scroll += new System.EventHandler(this.thDummy_Scroll);
            // 
            // pgDummy
            // 
            this.pgDummy.Location = new System.Drawing.Point(6, 53);
            this.pgDummy.Maximum = 20;
            this.pgDummy.Name = "pgDummy";
            this.pgDummy.Size = new System.Drawing.Size(476, 23);
            this.pgDummy.TabIndex = 1;
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(6, 20);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(75, 23);
            this.btnModal.TabIndex = 6;
            this.btnModal.Text = "Modal";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(105, 20);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(121, 23);
            this.btnModaless.TabIndex = 7;
            this.btnModaless.Text = "Modaless";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.btnModaless_Click);
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Location = new System.Drawing.Point(252, 20);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(118, 23);
            this.btnMessageBox.TabIndex = 8;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // grpForm
            // 
            this.grpForm.Controls.Add(this.btnMessageBox);
            this.grpForm.Controls.Add(this.btnModal);
            this.grpForm.Controls.Add(this.btnModaless);
            this.grpForm.Location = new System.Drawing.Point(19, 179);
            this.grpForm.Name = "grpForm";
            this.grpForm.Size = new System.Drawing.Size(476, 54);
            this.grpForm.TabIndex = 9;
            this.grpForm.TabStop = false;
            this.grpForm.Text = "Model && Modaless";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 250);
            this.Controls.Add(this.grpBar);
            this.Controls.Add(this.grpFont);
            this.Controls.Add(this.grpForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.grpBar.ResumeLayout(false);
            this.grpBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).EndInit();
            this.grpForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.TextBox txtSampleText;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.GroupBox grpBar;
        private System.Windows.Forms.TrackBar tbDummy;
        private System.Windows.Forms.ProgressBar pgDummy;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnModaless;
        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.GroupBox grpForm;
    }
}

