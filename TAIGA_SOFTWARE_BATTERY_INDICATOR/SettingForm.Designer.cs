namespace BATTERY_INDICATOR
{
    partial class SettingForm
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
            this.hint2 = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.hint1 = new System.Windows.Forms.TextBox();
            this.currentFont = new System.Windows.Forms.TextBox();
            this.changeFontBtn = new System.Windows.Forms.Button();
            this.currentFontSizeTB = new System.Windows.Forms.TextBox();
            this.hint3 = new System.Windows.Forms.TextBox();
            this.hint4 = new System.Windows.Forms.TextBox();
            this.hint5 = new System.Windows.Forms.TextBox();
            this.yOffset = new System.Windows.Forms.NumericUpDown();
            this.xOffset = new System.Windows.Forms.NumericUpDown();
            this.showIfFullCB = new System.Windows.Forms.CheckBox();
            this.widthNum = new System.Windows.Forms.NumericUpDown();
            this.heightNum = new System.Windows.Forms.NumericUpDown();
            this.hint8 = new System.Windows.Forms.TextBox();
            this.hint7 = new System.Windows.Forms.TextBox();
            this.hint6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.yOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNum)).BeginInit();
            this.SuspendLayout();
            // 
            // hint2
            // 
            this.hint2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint2.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint2.Location = new System.Drawing.Point(59, 158);
            this.hint2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.hint2.Name = "hint2";
            this.hint2.ReadOnly = true;
            this.hint2.Size = new System.Drawing.Size(329, 32);
            this.hint2.TabIndex = 3;
            this.hint2.Text = "크기";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(773, 497);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(171, 52);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "저장";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // hint1
            // 
            this.hint1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint1.Location = new System.Drawing.Point(59, 52);
            this.hint1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.hint1.Name = "hint1";
            this.hint1.ReadOnly = true;
            this.hint1.Size = new System.Drawing.Size(329, 32);
            this.hint1.TabIndex = 2;
            this.hint1.Text = "폰트";
            // 
            // currentFont
            // 
            this.currentFont.Location = new System.Drawing.Point(59, 97);
            this.currentFont.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.currentFont.Name = "currentFont";
            this.currentFont.ReadOnly = true;
            this.currentFont.Size = new System.Drawing.Size(324, 39);
            this.currentFont.TabIndex = 5;
            // 
            // changeFontBtn
            // 
            this.changeFontBtn.Location = new System.Drawing.Point(402, 92);
            this.changeFontBtn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.changeFontBtn.Name = "changeFontBtn";
            this.changeFontBtn.Size = new System.Drawing.Size(119, 52);
            this.changeFontBtn.TabIndex = 6;
            this.changeFontBtn.Text = "변경";
            this.changeFontBtn.UseVisualStyleBackColor = true;
            this.changeFontBtn.Click += new System.EventHandler(this.changeFontBtn_Click);
            // 
            // currentFontSizeTB
            // 
            this.currentFontSizeTB.Location = new System.Drawing.Point(59, 202);
            this.currentFontSizeTB.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.currentFontSizeTB.Name = "currentFontSizeTB";
            this.currentFontSizeTB.ReadOnly = true;
            this.currentFontSizeTB.Size = new System.Drawing.Size(324, 39);
            this.currentFontSizeTB.TabIndex = 7;
            // 
            // hint3
            // 
            this.hint3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint3.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint3.Location = new System.Drawing.Point(114, 448);
            this.hint3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.hint3.Name = "hint3";
            this.hint3.ReadOnly = true;
            this.hint3.Size = new System.Drawing.Size(229, 32);
            this.hint3.TabIndex = 8;
            this.hint3.Text = "글자위치";
            // 
            // hint4
            // 
            this.hint4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint4.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint4.Location = new System.Drawing.Point(21, 497);
            this.hint4.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.hint4.Name = "hint4";
            this.hint4.ReadOnly = true;
            this.hint4.Size = new System.Drawing.Size(57, 32);
            this.hint4.TabIndex = 9;
            this.hint4.Text = "왼쪽";
            // 
            // hint5
            // 
            this.hint5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint5.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint5.Location = new System.Drawing.Point(21, 551);
            this.hint5.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.hint5.Name = "hint5";
            this.hint5.ReadOnly = true;
            this.hint5.Size = new System.Drawing.Size(57, 32);
            this.hint5.TabIndex = 10;
            this.hint5.Text = "위쪽";
            // 
            // yOffset
            // 
            this.yOffset.DecimalPlaces = 1;
            this.yOffset.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.yOffset.Location = new System.Drawing.Point(114, 547);
            this.yOffset.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.yOffset.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.yOffset.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            -2147483648});
            this.yOffset.Name = "yOffset";
            this.yOffset.Size = new System.Drawing.Size(274, 39);
            this.yOffset.TabIndex = 11;
            this.yOffset.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // xOffset
            // 
            this.xOffset.DecimalPlaces = 1;
            this.xOffset.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.xOffset.Location = new System.Drawing.Point(114, 493);
            this.xOffset.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.xOffset.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.xOffset.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            -2147483648});
            this.xOffset.Name = "xOffset";
            this.xOffset.Size = new System.Drawing.Size(274, 39);
            this.xOffset.TabIndex = 12;
            this.xOffset.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // showIfFullCB
            // 
            this.showIfFullCB.AutoSize = true;
            this.showIfFullCB.Location = new System.Drawing.Point(667, 92);
            this.showIfFullCB.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.showIfFullCB.Name = "showIfFullCB";
            this.showIfFullCB.Size = new System.Drawing.Size(305, 31);
            this.showIfFullCB.TabIndex = 13;
            this.showIfFullCB.Text = "완전히 충전되면 알림";
            this.showIfFullCB.UseVisualStyleBackColor = true;
            this.showIfFullCB.CheckedChanged += new System.EventHandler(this.showIfFullCB_CheckedChanged);
            // 
            // widthNum
            // 
            this.widthNum.Location = new System.Drawing.Point(114, 333);
            this.widthNum.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.widthNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthNum.Name = "widthNum";
            this.widthNum.Size = new System.Drawing.Size(274, 39);
            this.widthNum.TabIndex = 18;
            // 
            // heightNum
            // 
            this.heightNum.Location = new System.Drawing.Point(114, 387);
            this.heightNum.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.heightNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightNum.Name = "heightNum";
            this.heightNum.Size = new System.Drawing.Size(274, 39);
            this.heightNum.TabIndex = 17;
            // 
            // hint8
            // 
            this.hint8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint8.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint8.Location = new System.Drawing.Point(21, 392);
            this.hint8.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.hint8.Name = "hint8";
            this.hint8.ReadOnly = true;
            this.hint8.Size = new System.Drawing.Size(57, 32);
            this.hint8.TabIndex = 16;
            this.hint8.Text = "세로";
            // 
            // hint7
            // 
            this.hint7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint7.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint7.Location = new System.Drawing.Point(21, 338);
            this.hint7.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.hint7.Name = "hint7";
            this.hint7.ReadOnly = true;
            this.hint7.Size = new System.Drawing.Size(57, 32);
            this.hint7.TabIndex = 15;
            this.hint7.Text = "가로";
            // 
            // hint6
            // 
            this.hint6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint6.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint6.Location = new System.Drawing.Point(114, 288);
            this.hint6.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.hint6.Name = "hint6";
            this.hint6.ReadOnly = true;
            this.hint6.Size = new System.Drawing.Size(229, 32);
            this.hint6.TabIndex = 14;
            this.hint6.Text = "아이콘해상도";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 621);
            this.Controls.Add(this.widthNum);
            this.Controls.Add(this.heightNum);
            this.Controls.Add(this.hint8);
            this.Controls.Add(this.hint7);
            this.Controls.Add(this.hint6);
            this.Controls.Add(this.showIfFullCB);
            this.Controls.Add(this.xOffset);
            this.Controls.Add(this.yOffset);
            this.Controls.Add(this.hint5);
            this.Controls.Add(this.hint4);
            this.Controls.Add(this.hint3);
            this.Controls.Add(this.currentFontSizeTB);
            this.Controls.Add(this.changeFontBtn);
            this.Controls.Add(this.currentFont);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.hint2);
            this.Controls.Add(this.hint1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "SettingForm";
            this.Text = "설정";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox hint2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox hint1;
        private System.Windows.Forms.TextBox currentFont;
        private System.Windows.Forms.Button changeFontBtn;
        private System.Windows.Forms.TextBox currentFontSizeTB;
        private System.Windows.Forms.TextBox hint3;
        private System.Windows.Forms.TextBox hint4;
        private System.Windows.Forms.TextBox hint5;
        private System.Windows.Forms.NumericUpDown yOffset;
        private System.Windows.Forms.NumericUpDown xOffset;
        private System.Windows.Forms.CheckBox showIfFullCB;
        private System.Windows.Forms.NumericUpDown widthNum;
        private System.Windows.Forms.NumericUpDown heightNum;
        private System.Windows.Forms.TextBox hint8;
        private System.Windows.Forms.TextBox hint7;
        private System.Windows.Forms.TextBox hint6;
    }
}