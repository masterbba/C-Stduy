﻿namespace AsyncFileIOWinForm
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
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnFindSource = new System.Windows.Forms.Button();
            this.btnFindTarget = new System.Windows.Forms.Button();
            this.btnAsyncCopy = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSyncCopy = new System.Windows.Forms.Button();
            this.pbCopy = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 18);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(53, 12);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source :";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(12, 45);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(49, 12);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "Target :";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(65, 15);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(295, 21);
            this.txtSource.TabIndex = 2;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(65, 42);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(295, 21);
            this.txtTarget.TabIndex = 3;
            // 
            // btnFindSource
            // 
            this.btnFindSource.Location = new System.Drawing.Point(366, 13);
            this.btnFindSource.Name = "btnFindSource";
            this.btnFindSource.Size = new System.Drawing.Size(75, 23);
            this.btnFindSource.TabIndex = 4;
            this.btnFindSource.Text = "...";
            this.btnFindSource.UseVisualStyleBackColor = true;
            this.btnFindSource.Click += new System.EventHandler(this.btnFindSource_Click);
            // 
            // btnFindTarget
            // 
            this.btnFindTarget.Location = new System.Drawing.Point(366, 40);
            this.btnFindTarget.Name = "btnFindTarget";
            this.btnFindTarget.Size = new System.Drawing.Size(75, 23);
            this.btnFindTarget.TabIndex = 5;
            this.btnFindTarget.Text = "...";
            this.btnFindTarget.UseVisualStyleBackColor = true;
            this.btnFindTarget.Click += new System.EventHandler(this.btnFindTarget_Click);
            // 
            // btnAsyncCopy
            // 
            this.btnAsyncCopy.Location = new System.Drawing.Point(23, 80);
            this.btnAsyncCopy.Name = "btnAsyncCopy";
            this.btnAsyncCopy.Size = new System.Drawing.Size(99, 23);
            this.btnAsyncCopy.TabIndex = 6;
            this.btnAsyncCopy.Text = "Async Copy";
            this.btnAsyncCopy.UseVisualStyleBackColor = true;
            this.btnAsyncCopy.Click += new System.EventHandler(this.btnAsyncCopy_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(366, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSyncCopy
            // 
            this.btnSyncCopy.Location = new System.Drawing.Point(183, 80);
            this.btnSyncCopy.Name = "btnSyncCopy";
            this.btnSyncCopy.Size = new System.Drawing.Size(91, 23);
            this.btnSyncCopy.TabIndex = 8;
            this.btnSyncCopy.Text = "SyncCopy";
            this.btnSyncCopy.UseVisualStyleBackColor = true;
            this.btnSyncCopy.Click += new System.EventHandler(this.btnSyncCopy_Click);
            // 
            // pbCopy
            // 
            this.pbCopy.Location = new System.Drawing.Point(23, 119);
            this.pbCopy.Name = "pbCopy";
            this.pbCopy.Size = new System.Drawing.Size(418, 23);
            this.pbCopy.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 160);
            this.Controls.Add(this.pbCopy);
            this.Controls.Add(this.btnSyncCopy);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAsyncCopy);
            this.Controls.Add(this.btnFindTarget);
            this.Controls.Add(this.btnFindSource);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblSource);
            this.Name = "MainForm";
            this.Text = "Async File Copy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnFindSource;
        private System.Windows.Forms.Button btnFindTarget;
        private System.Windows.Forms.Button btnAsyncCopy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSyncCopy;
        private System.Windows.Forms.ProgressBar pbCopy;
    }
}

