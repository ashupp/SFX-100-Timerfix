
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerfixControl));
            this.lblHeadline = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.pictureBoxCurrentStatus = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.ListBox();
            this.btnCheckTimer = new System.Windows.Forms.Button();
            this.btnApplyFix = new System.Windows.Forms.Button();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.btnForceFix = new System.Windows.Forms.Button();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.checkBoxAutoApply = new System.Windows.Forms.CheckBox();
            this.lblDescription = new System.Windows.Forms.Label();
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
            this.groupBox1.Location = new System.Drawing.Point(10, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Messages";
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(10, 19);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(421, 134);
            this.logBox.TabIndex = 0;
            // 
            // btnCheckTimer
            // 
            this.btnCheckTimer.Location = new System.Drawing.Point(10, 133);
            this.btnCheckTimer.Name = "btnCheckTimer";
            this.btnCheckTimer.Size = new System.Drawing.Size(142, 23);
            this.btnCheckTimer.TabIndex = 5;
            this.btnCheckTimer.Text = "Check current timing";
            this.btnCheckTimer.UseVisualStyleBackColor = true;
            this.btnCheckTimer.Click += new System.EventHandler(this.btnCheckTimer_Click);
            // 
            // btnApplyFix
            // 
            this.btnApplyFix.Location = new System.Drawing.Point(157, 133);
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
            // btnForceFix
            // 
            this.btnForceFix.Location = new System.Drawing.Point(305, 133);
            this.btnForceFix.Name = "btnForceFix";
            this.btnForceFix.Size = new System.Drawing.Size(142, 23);
            this.btnForceFix.TabIndex = 8;
            this.btnForceFix.Text = "Force Timerfix";
            this.btnForceFix.UseVisualStyleBackColor = true;
            this.btnForceFix.Click += new System.EventHandler(this.btnForceFix_Click);
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreshold.Location = new System.Drawing.Point(27, 103);
            this.lblThreshold.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(305, 16);
            this.lblThreshold.TabIndex = 11;
            this.lblThreshold.Text = "Force fix on startup even if average is below 12ms ";
            // 
            // checkBoxAutoApply
            // 
            this.checkBoxAutoApply.AutoSize = true;
            this.checkBoxAutoApply.Checked = true;
            this.checkBoxAutoApply.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoApply.Location = new System.Drawing.Point(11, 104);
            this.checkBoxAutoApply.Name = "checkBoxAutoApply";
            this.checkBoxAutoApply.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAutoApply.TabIndex = 13;
            this.checkBoxAutoApply.UseVisualStyleBackColor = true;
            this.checkBoxAutoApply.CheckedChanged += new System.EventHandler(this.checkBoxAutoApply_CheckedChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(8, 339);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(392, 65);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // TimerfixControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.checkBoxAutoApply);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.btnForceFix);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.btnApplyFix);
            this.Controls.Add(this.btnCheckTimer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxCurrentStatus);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.lblHeadline);
            this.Name = "TimerfixControl";
            this.Size = new System.Drawing.Size(454, 421);
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
        private System.Windows.Forms.Button btnForceFix;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.CheckBox checkBoxAutoApply;
        private System.Windows.Forms.Label lblDescription;
    }
}
