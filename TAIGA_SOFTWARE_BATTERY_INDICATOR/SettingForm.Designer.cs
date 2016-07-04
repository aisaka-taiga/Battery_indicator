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
            this.hint2.Location = new System.Drawing.Point(26, 70);
            this.hint2.Name = "hint2";
            this.hint2.ReadOnly = true;
            this.hint2.Size = new System.Drawing.Size(144, 14);
            this.hint2.TabIndex = 3;
            this.hint2.Text = "크기";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(338, 221);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "저장";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // hint1
            // 
            this.hint1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint1.Location = new System.Drawing.Point(26, 23);
            this.hint1.Name = "hint1";
            this.hint1.ReadOnly = true;
            this.hint1.Size = new System.Drawing.Size(144, 14);
            this.hint1.TabIndex = 2;
            this.hint1.Text = "폰트";
            // 
            // currentFont
            // 
            this.currentFont.Location = new System.Drawing.Point(26, 43);
            this.currentFont.Name = "currentFont";
            this.currentFont.ReadOnly = true;
            this.currentFont.Size = new System.Drawing.Size(144, 21);
            this.currentFont.TabIndex = 5;
            // 
            // changeFontBtn
            // 
            this.changeFontBtn.Location = new System.Drawing.Point(176, 41);
            this.changeFontBtn.Name = "changeFontBtn";
            this.changeFontBtn.Size = new System.Drawing.Size(52, 23);
            this.changeFontBtn.TabIndex = 6;
            this.changeFontBtn.Text = "변경";
            this.changeFontBtn.UseVisualStyleBackColor = true;
            this.changeFontBtn.Click += new System.EventHandler(this.changeFontBtn_Click);
            // 
            // currentFontSizeTB
            // 
            this.currentFontSizeTB.Location = new System.Drawing.Point(26, 90);
            this.currentFontSizeTB.Name = "currentFontSizeTB";
            this.currentFontSizeTB.ReadOnly = true;
            this.currentFontSizeTB.Size = new System.Drawing.Size(144, 21);
            this.currentFontSizeTB.TabIndex = 7;
            // 
            // hint3
            // 
            this.hint3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint3.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint3.Location = new System.Drawing.Point(50, 199);
            this.hint3.Name = "hint3";
            this.hint3.ReadOnly = true;
            this.hint3.Size = new System.Drawing.Size(100, 14);
            this.hint3.TabIndex = 8;
            this.hint3.Text = "글자위치";
            // 
            // hint4
            // 
            this.hint4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint4.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint4.Location = new System.Drawing.Point(9, 221);
            this.hint4.Name = "hint4";
            this.hint4.ReadOnly = true;
            this.hint4.Size = new System.Drawing.Size(25, 14);
            this.hint4.TabIndex = 9;
            this.hint4.Text = "왼쪽";
            // 
            // hint5
            // 
            this.hint5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint5.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint5.Location = new System.Drawing.Point(9, 245);
            this.hint5.Name = "hint5";
            this.hint5.ReadOnly = true;
            this.hint5.Size = new System.Drawing.Size(25, 14);
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
            this.yOffset.Location = new System.Drawing.Point(50, 243);
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
            this.yOffset.Size = new System.Drawing.Size(120, 21);
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
            this.xOffset.Location = new System.Drawing.Point(50, 219);
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
            this.xOffset.Size = new System.Drawing.Size(120, 21);
            this.xOffset.TabIndex = 12;
            this.xOffset.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // showIfFullCB
            // 
            this.showIfFullCB.AutoSize = true;
            this.showIfFullCB.Location = new System.Drawing.Point(292, 41);
            this.showIfFullCB.Name = "showIfFullCB";
            this.showIfFullCB.Size = new System.Drawing.Size(140, 16);
            this.showIfFullCB.TabIndex = 13;
            this.showIfFullCB.Text = "완전히 충전되면 알림";
            this.showIfFullCB.UseVisualStyleBackColor = true;
            this.showIfFullCB.CheckedChanged += new System.EventHandler(this.showIfFullCB_CheckedChanged);
            // 
            // widthNum
            // 
            this.widthNum.Location = new System.Drawing.Point(50, 148);
            this.widthNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthNum.Name = "widthNum";
            this.widthNum.Size = new System.Drawing.Size(120, 21);
            this.widthNum.TabIndex = 18;
            this.widthNum.ValueChanged += new System.EventHandler(this.ResolutionValueChanged);
            // 
            // heightNum
            // 
            this.heightNum.Location = new System.Drawing.Point(50, 172);
            this.heightNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightNum.Name = "heightNum";
            this.heightNum.Size = new System.Drawing.Size(120, 21);
            this.heightNum.TabIndex = 17;
            this.heightNum.ValueChanged += new System.EventHandler(this.ResolutionValueChanged);
            // 
            // hint8
            // 
            this.hint8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint8.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint8.Location = new System.Drawing.Point(9, 174);
            this.hint8.Name = "hint8";
            this.hint8.ReadOnly = true;
            this.hint8.Size = new System.Drawing.Size(25, 14);
            this.hint8.TabIndex = 16;
            this.hint8.Text = "세로";
            // 
            // hint7
            // 
            this.hint7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint7.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint7.Location = new System.Drawing.Point(9, 150);
            this.hint7.Name = "hint7";
            this.hint7.ReadOnly = true;
            this.hint7.Size = new System.Drawing.Size(25, 14);
            this.hint7.TabIndex = 15;
            this.hint7.Text = "가로";
            // 
            // hint6
            // 
            this.hint6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint6.Cursor = System.Windows.Forms.Cursors.Default;
            this.hint6.Location = new System.Drawing.Point(50, 128);
            this.hint6.Name = "hint6";
            this.hint6.ReadOnly = true;
            this.hint6.Size = new System.Drawing.Size(100, 14);
            this.hint6.TabIndex = 14;
            this.hint6.Text = "아이콘해상도";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 276);
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