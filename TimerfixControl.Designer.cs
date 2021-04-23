
using System;

namespace SFX100Timerfix
{
    partial class TimerfixControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeadline = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.pictureBoxCurrentStatus = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.ListBox();
            this.btnCheckTimer = new System.Windows.Forms.Button();
            this.btnApplyFix = new System.Windows.Forms.Button();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentStatus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeadline
            // 
            this.lblHeadline.AutoSize = true;
            this.lblHeadline.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline.Location = new System.Drawing.Point(3, 7);
            this.lblHeadline.Name = "lblHeadline";
            this.lblHeadline.Size = new System.Drawing.Size(178, 23);
            this.lblHeadline.TabIndex = 0;
            this.lblHeadline.Text = "SFX-100-Timerfix";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.Location = new System.Drawing.Point(7, 72);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(93, 16);
            this.lblCurrentStatus.TabIndex = 1;
            this.lblCurrentStatus.Text = "Current Status:";
            // 
            // pictureBoxCurrentStatus
            // 
            this.pictureBoxCurrentStatus.Location = new System.Drawing.Point(102, 65);
            this.pictureBoxCurrentStatus.Name = "pictureBoxCurrentStatus";
            this.pictureBoxCurrentStatus.Size = new System.Drawing.Size(34, 30);
            this.pictureBoxCurrentStatus.TabIndex = 2;
            this.pictureBoxCurrentStatus.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Messages";
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(10, 19);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(355, 147);
            this.logBox.TabIndex = 0;
            this.logBox.SelectedIndexChanged += new System.EventHandler(this.logBox_SelectedIndexChanged);
            // 
            // btnCheckTimer
            // 
            this.btnCheckTimer.Location = new System.Drawing.Point(9, 108);
            this.btnCheckTimer.Name = "btnCheckTimer";
            this.btnCheckTimer.Size = new System.Drawing.Size(142, 23);
            this.btnCheckTimer.TabIndex = 5;
            this.btnCheckTimer.Text = "Check current timing";
            this.btnCheckTimer.UseVisualStyleBackColor = true;
            this.btnCheckTimer.Click += new System.EventHandler(this.btnCheckTimer_Click);
            // 
            // btnApplyFix
            // 
            this.btnApplyFix.Location = new System.Drawing.Point(157, 108);
            this.btnApplyFix.Name = "btnApplyFix";
            this.btnApplyFix.Size = new System.Drawing.Size(142, 23);
            this.btnApplyFix.TabIndex = 6;
            this.btnApplyFix.Text = "Manual (re)apply Timerfix";
            this.btnApplyFix.UseVisualStyleBackColor = true;
            this.btnApplyFix.Click += new System.EventHandler(this.btnApplyFix_Click);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(3, 36);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(220, 13);
            this.lblLink.TabIndex = 7;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "https://github.com/ashupp/SFX-100-Timerfix";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // TimerfixControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.btnApplyFix);
            this.Controls.Add(this.btnCheckTimer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxCurrentStatus);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.lblHeadline);
            this.Name = "TimerfixControl";
            this.Size = new System.Drawing.Size(394, 322);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentStatus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.PictureBox pictureBoxCurrentStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.Button btnCheckTimer;
        private System.Windows.Forms.Button btnApplyFix;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}
