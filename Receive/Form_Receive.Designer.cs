using System.Collections.Generic;

namespace Receive
{
    partial class Form_Receive
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
            this.lbResult = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.tbPostfix = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.lbProcessName = new System.Windows.Forms.Label();
            this.gbProcess = new System.Windows.Forms.GroupBox();
            this.lbPostfix = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.labelIntro = new System.Windows.Forms.Label();
            this.gbIntro = new System.Windows.Forms.GroupBox();
            this.gbProcess.SuspendLayout();
            this.gbIntro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(515, 40);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(44, 13);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = "Kết quả";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Location = new System.Drawing.Point(20, 40);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(50, 13);
            this.lbContent.TabIndex = 4;
            this.lbContent.Text = "Nội dung";
            // 
            // tbPostfix
            // 
            this.tbPostfix.BackColor = System.Drawing.SystemColors.Menu;
            this.tbPostfix.Location = new System.Drawing.Point(268, 56);
            this.tbPostfix.Multiline = true;
            this.tbPostfix.Name = "tbPostfix";
            this.tbPostfix.ReadOnly = true;
            this.tbPostfix.Size = new System.Drawing.Size(239, 274);
            this.tbPostfix.TabIndex = 3;
            this.tbPostfix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbContent
            // 
            this.tbContent.BackColor = System.Drawing.SystemColors.Menu;
            this.tbContent.Location = new System.Drawing.Point(23, 56);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ReadOnly = true;
            this.tbContent.Size = new System.Drawing.Size(239, 274);
            this.tbContent.TabIndex = 2;
            this.tbContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbProcessName
            // 
            this.lbProcessName.AutoSize = true;
            this.lbProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessName.Location = new System.Drawing.Point(290, 16);
            this.lbProcessName.Name = "lbProcessName";
            this.lbProcessName.Size = new System.Drawing.Size(194, 16);
            this.lbProcessName.TabIndex = 0;
            this.lbProcessName.Text = "TIẾN TRÌNH NGƯỜI DÙNG";
            // 
            // gbProcess
            // 
            this.gbProcess.Controls.Add(this.lbPostfix);
            this.gbProcess.Controls.Add(this.tbResult);
            this.gbProcess.Controls.Add(this.lbResult);
            this.gbProcess.Controls.Add(this.lbContent);
            this.gbProcess.Controls.Add(this.tbPostfix);
            this.gbProcess.Controls.Add(this.tbContent);
            this.gbProcess.Controls.Add(this.lbProcessName);
            this.gbProcess.Location = new System.Drawing.Point(11, 84);
            this.gbProcess.Name = "gbProcess";
            this.gbProcess.Size = new System.Drawing.Size(778, 343);
            this.gbProcess.TabIndex = 5;
            this.gbProcess.TabStop = false;
            // 
            // lbPostfix
            // 
            this.lbPostfix.AutoSize = true;
            this.lbPostfix.Location = new System.Drawing.Point(268, 39);
            this.lbPostfix.Name = "lbPostfix";
            this.lbPostfix.Size = new System.Drawing.Size(86, 13);
            this.lbPostfix.TabIndex = 9;
            this.lbPostfix.Text = "Biểu thức Postfix";
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.Menu;
            this.tbResult.Location = new System.Drawing.Point(513, 56);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(239, 274);
            this.tbResult.TabIndex = 8;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelIntro
            // 
            this.labelIntro.AutoSize = true;
            this.labelIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntro.Location = new System.Drawing.Point(232, 16);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(327, 24);
            this.labelIntro.TabIndex = 0;
            this.labelIntro.Text = "Interprocess Communication - IPC";
            this.labelIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbIntro
            // 
            this.gbIntro.Controls.Add(this.labelIntro);
            this.gbIntro.Location = new System.Drawing.Point(11, 24);
            this.gbIntro.Name = "gbIntro";
            this.gbIntro.Size = new System.Drawing.Size(777, 54);
            this.gbIntro.TabIndex = 4;
            this.gbIntro.TabStop = false;
            // 
            // Form_Receive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbProcess);
            this.Controls.Add(this.gbIntro);
            this.Name = "Form_Receive";
            this.Text = "Form1";
            this.gbProcess.ResumeLayout(false);
            this.gbProcess.PerformLayout();
            this.gbIntro.ResumeLayout(false);
            this.gbIntro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.TextBox tbPostfix;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label lbProcessName;
        private System.Windows.Forms.GroupBox gbProcess;
        private System.Windows.Forms.Label lbPostfix;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label labelIntro;
        private System.Windows.Forms.GroupBox gbIntro;

        private List<string> ExpressionList;
        private List<string> ResultList;
        private List<string> PostfixList;
       
        private const string ExpressionMSMQ = @".\private$\ExpressionMSMQ";
        private const string ResultMSMQ = @".\private$\ResultMSMQ";
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}

