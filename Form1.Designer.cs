namespace lr2graphics
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.translateX = new System.Windows.Forms.NumericUpDown();
            this.translateY = new System.Windows.Forms.NumericUpDown();
            this.Rotate = new System.Windows.Forms.NumericUpDown();
            this.ScaleX = new System.Windows.Forms.NumericUpDown();
            this.ScaleY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkHead = new System.Windows.Forms.CheckBox();
            this.checkWhisker1 = new System.Windows.Forms.CheckBox();
            this.checkWhisker2 = new System.Windows.Forms.CheckBox();
            this.checkWhisker3 = new System.Windows.Forms.CheckBox();
            this.checkWhisker4 = new System.Windows.Forms.CheckBox();
            this.checkWhisker5 = new System.Windows.Forms.CheckBox();
            this.checkWhisker6 = new System.Windows.Forms.CheckBox();
            this.checkEar1 = new System.Windows.Forms.CheckBox();
            this.checkEar2 = new System.Windows.Forms.CheckBox();
            this.checkEye1 = new System.Windows.Forms.CheckBox();
            this.checkEye2 = new System.Windows.Forms.CheckBox();
            this.checkNose = new System.Windows.Forms.CheckBox();
            this.checkBody = new System.Windows.Forms.CheckBox();
            this.checkFoot1 = new System.Windows.Forms.CheckBox();
            this.checkFoot2 = new System.Windows.Forms.CheckBox();
            this.checkTail = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleY)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(731, 635);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // translateX
            // 
            this.translateX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.translateX.Location = new System.Drawing.Point(840, 422);
            this.translateX.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.translateX.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.translateX.Name = "translateX";
            this.translateX.Size = new System.Drawing.Size(120, 20);
            this.translateX.TabIndex = 1;
            this.translateX.ValueChanged += new System.EventHandler(this.Translate_ValueChanged);
            // 
            // translateY
            // 
            this.translateY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.translateY.Location = new System.Drawing.Point(840, 473);
            this.translateY.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.translateY.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.translateY.Name = "translateY";
            this.translateY.Size = new System.Drawing.Size(120, 20);
            this.translateY.TabIndex = 2;
            this.translateY.ValueChanged += new System.EventHandler(this.Translate_ValueChanged);
            // 
            // Rotate
            // 
            this.Rotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rotate.Location = new System.Drawing.Point(840, 533);
            this.Rotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.Rotate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(120, 20);
            this.Rotate.TabIndex = 3;
            this.Rotate.ValueChanged += new System.EventHandler(this.Rotate_ValueChanged);
            // 
            // ScaleX
            // 
            this.ScaleX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleX.DecimalPlaces = 2;
            this.ScaleX.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.ScaleX.Location = new System.Drawing.Point(840, 588);
            this.ScaleX.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ScaleX.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.ScaleX.Name = "ScaleX";
            this.ScaleX.Size = new System.Drawing.Size(120, 20);
            this.ScaleX.TabIndex = 4;
            this.ScaleX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScaleX.ValueChanged += new System.EventHandler(this.Scale_ValueChanged);
            // 
            // ScaleY
            // 
            this.ScaleY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleY.DecimalPlaces = 2;
            this.ScaleY.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.ScaleY.Location = new System.Drawing.Point(840, 627);
            this.ScaleY.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ScaleY.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.ScaleY.Name = "ScaleY";
            this.ScaleY.Size = new System.Drawing.Size(120, 20);
            this.ScaleY.TabIndex = 5;
            this.ScaleY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScaleY.ValueChanged += new System.EventHandler(this.Scale_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(837, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Translate X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(841, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Translate Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(837, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rotation angle";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(841, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Scale X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(841, 611);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Scale Y";
            // 
            // checkHead
            // 
            this.checkHead.AutoSize = true;
            this.checkHead.Location = new System.Drawing.Point(749, 12);
            this.checkHead.Name = "checkHead";
            this.checkHead.Size = new System.Drawing.Size(52, 17);
            this.checkHead.TabIndex = 11;
            this.checkHead.Text = "Head";
            this.checkHead.UseVisualStyleBackColor = true;
            this.checkHead.CheckedChanged += new System.EventHandler(this.checkHead_CheckedChanged);
            // 
            // checkWhisker1
            // 
            this.checkWhisker1.AutoSize = true;
            this.checkWhisker1.Location = new System.Drawing.Point(765, 35);
            this.checkWhisker1.Name = "checkWhisker1";
            this.checkWhisker1.Size = new System.Drawing.Size(71, 17);
            this.checkWhisker1.TabIndex = 12;
            this.checkWhisker1.Text = "Whisker1";
            this.checkWhisker1.UseVisualStyleBackColor = true;
            this.checkWhisker1.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // checkWhisker2
            // 
            this.checkWhisker2.AutoSize = true;
            this.checkWhisker2.Location = new System.Drawing.Point(765, 58);
            this.checkWhisker2.Name = "checkWhisker2";
            this.checkWhisker2.Size = new System.Drawing.Size(71, 17);
            this.checkWhisker2.TabIndex = 13;
            this.checkWhisker2.Text = "Whisker2";
            this.checkWhisker2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkWhisker2.UseVisualStyleBackColor = true;
            this.checkWhisker2.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // checkWhisker3
            // 
            this.checkWhisker3.AutoSize = true;
            this.checkWhisker3.Location = new System.Drawing.Point(765, 81);
            this.checkWhisker3.Name = "checkWhisker3";
            this.checkWhisker3.Size = new System.Drawing.Size(71, 17);
            this.checkWhisker3.TabIndex = 14;
            this.checkWhisker3.Text = "Whisker3";
            this.checkWhisker3.UseVisualStyleBackColor = true;
            this.checkWhisker3.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // checkWhisker4
            // 
            this.checkWhisker4.AutoSize = true;
            this.checkWhisker4.Location = new System.Drawing.Point(851, 35);
            this.checkWhisker4.Name = "checkWhisker4";
            this.checkWhisker4.Size = new System.Drawing.Size(71, 17);
            this.checkWhisker4.TabIndex = 15;
            this.checkWhisker4.Text = "Whisker4";
            this.checkWhisker4.UseVisualStyleBackColor = true;
            this.checkWhisker4.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // checkWhisker5
            // 
            this.checkWhisker5.AutoSize = true;
            this.checkWhisker5.Location = new System.Drawing.Point(851, 58);
            this.checkWhisker5.Name = "checkWhisker5";
            this.checkWhisker5.Size = new System.Drawing.Size(71, 17);
            this.checkWhisker5.TabIndex = 16;
            this.checkWhisker5.Text = "Whisker5";
            this.checkWhisker5.UseVisualStyleBackColor = true;
            this.checkWhisker5.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // checkWhisker6
            // 
            this.checkWhisker6.AutoSize = true;
            this.checkWhisker6.Location = new System.Drawing.Point(850, 81);
            this.checkWhisker6.Name = "checkWhisker6";
            this.checkWhisker6.Size = new System.Drawing.Size(71, 17);
            this.checkWhisker6.TabIndex = 17;
            this.checkWhisker6.Text = "Whisker6";
            this.checkWhisker6.UseVisualStyleBackColor = true;
            this.checkWhisker6.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // checkEar1
            // 
            this.checkEar1.AutoSize = true;
            this.checkEar1.Location = new System.Drawing.Point(765, 105);
            this.checkEar1.Name = "checkEar1";
            this.checkEar1.Size = new System.Drawing.Size(63, 17);
            this.checkEar1.TabIndex = 18;
            this.checkEar1.Text = "Left Ear";
            this.checkEar1.UseVisualStyleBackColor = true;
            this.checkEar1.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // checkEar2
            // 
            this.checkEar2.AutoSize = true;
            this.checkEar2.Location = new System.Drawing.Point(850, 105);
            this.checkEar2.Name = "checkEar2";
            this.checkEar2.Size = new System.Drawing.Size(70, 17);
            this.checkEar2.TabIndex = 19;
            this.checkEar2.Text = "Right Ear";
            this.checkEar2.UseVisualStyleBackColor = true;
            this.checkEar2.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // checkEye1
            // 
            this.checkEye1.AutoSize = true;
            this.checkEye1.Location = new System.Drawing.Point(765, 128);
            this.checkEye1.Name = "checkEye1";
            this.checkEye1.Size = new System.Drawing.Size(65, 17);
            this.checkEye1.TabIndex = 20;
            this.checkEye1.Text = "Left Eye";
            this.checkEye1.UseVisualStyleBackColor = true;
            this.checkEye1.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // checkEye2
            // 
            this.checkEye2.AutoSize = true;
            this.checkEye2.Location = new System.Drawing.Point(851, 128);
            this.checkEye2.Name = "checkEye2";
            this.checkEye2.Size = new System.Drawing.Size(72, 17);
            this.checkEye2.TabIndex = 21;
            this.checkEye2.Text = "Right Eye";
            this.checkEye2.UseVisualStyleBackColor = true;
            this.checkEye2.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // checkNose
            // 
            this.checkNose.AutoSize = true;
            this.checkNose.Location = new System.Drawing.Point(851, 151);
            this.checkNose.Name = "checkNose";
            this.checkNose.Size = new System.Drawing.Size(51, 17);
            this.checkNose.TabIndex = 22;
            this.checkNose.Text = "Nose";
            this.checkNose.UseVisualStyleBackColor = true;
            this.checkNose.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // checkBody
            // 
            this.checkBody.AutoSize = true;
            this.checkBody.Location = new System.Drawing.Point(748, 179);
            this.checkBody.Name = "checkBody";
            this.checkBody.Size = new System.Drawing.Size(50, 17);
            this.checkBody.TabIndex = 23;
            this.checkBody.Text = "Body";
            this.checkBody.UseVisualStyleBackColor = true;
            this.checkBody.CheckedChanged += new System.EventHandler(this.checkBody_CheckedChanged);
            // 
            // checkFoot1
            // 
            this.checkFoot1.AutoSize = true;
            this.checkFoot1.Location = new System.Drawing.Point(765, 202);
            this.checkFoot1.Name = "checkFoot1";
            this.checkFoot1.Size = new System.Drawing.Size(68, 17);
            this.checkFoot1.TabIndex = 24;
            this.checkFoot1.Text = "Left Foot";
            this.checkFoot1.UseVisualStyleBackColor = true;
            this.checkFoot1.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // checkFoot2
            // 
            this.checkFoot2.AutoSize = true;
            this.checkFoot2.Location = new System.Drawing.Point(850, 202);
            this.checkFoot2.Name = "checkFoot2";
            this.checkFoot2.Size = new System.Drawing.Size(75, 17);
            this.checkFoot2.TabIndex = 25;
            this.checkFoot2.Text = "Right Foot";
            this.checkFoot2.UseVisualStyleBackColor = true;
            this.checkFoot2.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // checkTail
            // 
            this.checkTail.AutoSize = true;
            this.checkTail.Location = new System.Drawing.Point(765, 225);
            this.checkTail.Name = "checkTail";
            this.checkTail.Size = new System.Drawing.Size(43, 17);
            this.checkTail.TabIndex = 26;
            this.checkTail.Text = "Tail";
            this.checkTail.UseVisualStyleBackColor = true;
            this.checkTail.CheckedChanged += new System.EventHandler(this.CheckParts);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 661);
            this.Controls.Add(this.checkTail);
            this.Controls.Add(this.checkFoot2);
            this.Controls.Add(this.checkFoot1);
            this.Controls.Add(this.checkBody);
            this.Controls.Add(this.checkNose);
            this.Controls.Add(this.checkEye2);
            this.Controls.Add(this.checkEye1);
            this.Controls.Add(this.checkEar2);
            this.Controls.Add(this.checkEar1);
            this.Controls.Add(this.checkWhisker6);
            this.Controls.Add(this.checkWhisker5);
            this.Controls.Add(this.checkWhisker4);
            this.Controls.Add(this.checkWhisker3);
            this.Controls.Add(this.checkWhisker2);
            this.Controls.Add(this.checkWhisker1);
            this.Controls.Add(this.checkHead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScaleY);
            this.Controls.Add(this.ScaleX);
            this.Controls.Add(this.Rotate);
            this.Controls.Add(this.translateY);
            this.Controls.Add(this.translateX);
            this.Controls.Add(this.pictureBox);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.NumericUpDown translateX;
        private System.Windows.Forms.NumericUpDown translateY;
        private System.Windows.Forms.NumericUpDown Rotate;
        private System.Windows.Forms.NumericUpDown ScaleX;
        private System.Windows.Forms.NumericUpDown ScaleY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkHead;
        private System.Windows.Forms.CheckBox checkWhisker1;
        private System.Windows.Forms.CheckBox checkWhisker2;
        private System.Windows.Forms.CheckBox checkWhisker3;
        private System.Windows.Forms.CheckBox checkWhisker4;
        private System.Windows.Forms.CheckBox checkWhisker5;
        private System.Windows.Forms.CheckBox checkWhisker6;
        private System.Windows.Forms.CheckBox checkEar1;
        private System.Windows.Forms.CheckBox checkEar2;
        private System.Windows.Forms.CheckBox checkEye1;
        private System.Windows.Forms.CheckBox checkEye2;
        private System.Windows.Forms.CheckBox checkNose;
        private System.Windows.Forms.CheckBox checkBody;
        private System.Windows.Forms.CheckBox checkFoot1;
        private System.Windows.Forms.CheckBox checkFoot2;
        private System.Windows.Forms.CheckBox checkTail;
    }
}

