﻿namespace BATTERY_INDICATOR
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dd2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "배터리 상태";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.dd2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 92);
            // 
            // ddToolStripMenuItem
            // 
            this.ddToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ddToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ddToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ddToolStripMenuItem.Name = "ddToolStripMenuItem";
            this.ddToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.ddToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ddToolStripMenuItem.ShowShortcutKeys = false;
            this.ddToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ddToolStripMenuItem.Text = "부팅 시 자동실행";
            this.ddToolStripMenuItem.Click += new System.EventHandler(this.ddToolStripMenuItem_Click);
            // 
            // dd2ToolStripMenuItem
            // 
            this.dd2ToolStripMenuItem.Name = "dd2ToolStripMenuItem";
            this.dd2ToolStripMenuItem.ShowShortcutKeys = false;
            this.dd2ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dd2ToolStripMenuItem.Text = "종료";
            this.dd2ToolStripMenuItem.Click += new System.EventHandler(this.dd2ToolStripMenuItem_Click);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.설정ToolStripMenuItem.Text = "설정";
            this.설정ToolStripMenuItem.Click += new System.EventHandler(this.설정ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 23);
            this.ControlBox = false;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dd2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
    }
}

