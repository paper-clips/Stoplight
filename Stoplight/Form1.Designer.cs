namespace Stoplight
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            this.NorthStoplight = new System.Windows.Forms.PictureBox();
            this.NorthUpBtn = new System.Windows.Forms.Button();
            this.NorthDownBtn = new System.Windows.Forms.Button();
            this.SouthDownBtn = new System.Windows.Forms.Button();
            this.SouthUpBtn = new System.Windows.Forms.Button();
            this.SouthStoplight = new System.Windows.Forms.PictureBox();
            this.EastDownBtn = new System.Windows.Forms.Button();
            this.EastUpBtn = new System.Windows.Forms.Button();
            this.EastStoplight = new System.Windows.Forms.PictureBox();
            this.WestDownBtn = new System.Windows.Forms.Button();
            this.WestUpBtn = new System.Windows.Forms.Button();
            this.WestStoplight = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NorthMiddleBtn = new System.Windows.Forms.Button();
            this.SouthMiddleBtn = new System.Windows.Forms.Button();
            this.EastMiddleBtn = new System.Windows.Forms.Button();
            this.WestMiddleBtn = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NorthStoplight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthStoplight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastStoplight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestStoplight)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NorthStoplight
            // 
            this.NorthStoplight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NorthStoplight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NorthStoplight.Location = new System.Drawing.Point(45, 31);
            this.NorthStoplight.Name = "NorthStoplight";
            this.NorthStoplight.Size = new System.Drawing.Size(119, 269);
            this.NorthStoplight.TabIndex = 5;
            this.NorthStoplight.TabStop = false;
            // 
            // NorthUpBtn
            // 
            this.NorthUpBtn.Enabled = false;
            this.NorthUpBtn.Location = new System.Drawing.Point(72, 53);
            this.NorthUpBtn.Name = "NorthUpBtn";
            this.NorthUpBtn.Size = new System.Drawing.Size(60, 60);
            this.NorthUpBtn.TabIndex = 6;
            this.NorthUpBtn.UseVisualStyleBackColor = true;
            // 
            // NorthDownBtn
            // 
            this.NorthDownBtn.Enabled = false;
            this.NorthDownBtn.Location = new System.Drawing.Point(72, 214);
            this.NorthDownBtn.Name = "NorthDownBtn";
            this.NorthDownBtn.Size = new System.Drawing.Size(60, 60);
            this.NorthDownBtn.TabIndex = 9;
            this.NorthDownBtn.UseVisualStyleBackColor = true;
            // 
            // SouthDownBtn
            // 
            this.SouthDownBtn.Enabled = false;
            this.SouthDownBtn.Location = new System.Drawing.Point(213, 214);
            this.SouthDownBtn.Name = "SouthDownBtn";
            this.SouthDownBtn.Size = new System.Drawing.Size(60, 60);
            this.SouthDownBtn.TabIndex = 16;
            this.SouthDownBtn.UseVisualStyleBackColor = true;
            // 
            // SouthUpBtn
            // 
            this.SouthUpBtn.Enabled = false;
            this.SouthUpBtn.Location = new System.Drawing.Point(213, 53);
            this.SouthUpBtn.Name = "SouthUpBtn";
            this.SouthUpBtn.Size = new System.Drawing.Size(60, 60);
            this.SouthUpBtn.TabIndex = 15;
            this.SouthUpBtn.UseVisualStyleBackColor = true;
            // 
            // SouthStoplight
            // 
            this.SouthStoplight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SouthStoplight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SouthStoplight.Location = new System.Drawing.Point(186, 31);
            this.SouthStoplight.Name = "SouthStoplight";
            this.SouthStoplight.Size = new System.Drawing.Size(119, 269);
            this.SouthStoplight.TabIndex = 14;
            this.SouthStoplight.TabStop = false;
            // 
            // EastDownBtn
            // 
            this.EastDownBtn.Enabled = false;
            this.EastDownBtn.Location = new System.Drawing.Point(351, 214);
            this.EastDownBtn.Name = "EastDownBtn";
            this.EastDownBtn.Size = new System.Drawing.Size(60, 60);
            this.EastDownBtn.TabIndex = 19;
            this.EastDownBtn.UseVisualStyleBackColor = true;
            // 
            // EastUpBtn
            // 
            this.EastUpBtn.Enabled = false;
            this.EastUpBtn.Location = new System.Drawing.Point(351, 53);
            this.EastUpBtn.Name = "EastUpBtn";
            this.EastUpBtn.Size = new System.Drawing.Size(60, 60);
            this.EastUpBtn.TabIndex = 18;
            this.EastUpBtn.UseVisualStyleBackColor = true;
            // 
            // EastStoplight
            // 
            this.EastStoplight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EastStoplight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EastStoplight.Location = new System.Drawing.Point(324, 31);
            this.EastStoplight.Name = "EastStoplight";
            this.EastStoplight.Size = new System.Drawing.Size(119, 269);
            this.EastStoplight.TabIndex = 17;
            this.EastStoplight.TabStop = false;
            // 
            // WestDownBtn
            // 
            this.WestDownBtn.Enabled = false;
            this.WestDownBtn.Location = new System.Drawing.Point(486, 214);
            this.WestDownBtn.Name = "WestDownBtn";
            this.WestDownBtn.Size = new System.Drawing.Size(60, 60);
            this.WestDownBtn.TabIndex = 22;
            this.WestDownBtn.UseVisualStyleBackColor = true;
            // 
            // WestUpBtn
            // 
            this.WestUpBtn.Enabled = false;
            this.WestUpBtn.Location = new System.Drawing.Point(486, 53);
            this.WestUpBtn.Name = "WestUpBtn";
            this.WestUpBtn.Size = new System.Drawing.Size(60, 60);
            this.WestUpBtn.TabIndex = 21;
            this.WestUpBtn.UseVisualStyleBackColor = true;
            // 
            // WestStoplight
            // 
            this.WestStoplight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WestStoplight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WestStoplight.Location = new System.Drawing.Point(459, 31);
            this.WestStoplight.Name = "WestStoplight";
            this.WestStoplight.Size = new System.Drawing.Size(119, 269);
            this.WestStoplight.TabIndex = 20;
            this.WestStoplight.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "North";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "South";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "East";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "West";
            // 
            // NorthMiddleBtn
            // 
            this.NorthMiddleBtn.Enabled = false;
            this.NorthMiddleBtn.Location = new System.Drawing.Point(72, 133);
            this.NorthMiddleBtn.Name = "NorthMiddleBtn";
            this.NorthMiddleBtn.Size = new System.Drawing.Size(60, 60);
            this.NorthMiddleBtn.TabIndex = 27;
            this.NorthMiddleBtn.UseVisualStyleBackColor = true;
            // 
            // SouthMiddleBtn
            // 
            this.SouthMiddleBtn.Enabled = false;
            this.SouthMiddleBtn.Location = new System.Drawing.Point(213, 133);
            this.SouthMiddleBtn.Name = "SouthMiddleBtn";
            this.SouthMiddleBtn.Size = new System.Drawing.Size(60, 60);
            this.SouthMiddleBtn.TabIndex = 28;
            this.SouthMiddleBtn.UseVisualStyleBackColor = true;
            // 
            // EastMiddleBtn
            // 
            this.EastMiddleBtn.Enabled = false;
            this.EastMiddleBtn.Location = new System.Drawing.Point(351, 133);
            this.EastMiddleBtn.Name = "EastMiddleBtn";
            this.EastMiddleBtn.Size = new System.Drawing.Size(60, 60);
            this.EastMiddleBtn.TabIndex = 29;
            this.EastMiddleBtn.UseVisualStyleBackColor = true;
            // 
            // WestMiddleBtn
            // 
            this.WestMiddleBtn.Enabled = false;
            this.WestMiddleBtn.Location = new System.Drawing.Point(486, 133);
            this.WestMiddleBtn.Name = "WestMiddleBtn";
            this.WestMiddleBtn.Size = new System.Drawing.Size(60, 60);
            this.WestMiddleBtn.TabIndex = 30;
            this.WestMiddleBtn.UseVisualStyleBackColor = true;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(285, 368);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(58, 16);
            this.TimeLabel.TabIndex = 31;
            this.TimeLabel.Text = "Time: 00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 405);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.WestMiddleBtn);
            this.Controls.Add(this.EastMiddleBtn);
            this.Controls.Add(this.SouthMiddleBtn);
            this.Controls.Add(this.NorthMiddleBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WestDownBtn);
            this.Controls.Add(this.WestUpBtn);
            this.Controls.Add(this.WestStoplight);
            this.Controls.Add(this.EastDownBtn);
            this.Controls.Add(this.EastUpBtn);
            this.Controls.Add(this.EastStoplight);
            this.Controls.Add(this.SouthDownBtn);
            this.Controls.Add(this.SouthUpBtn);
            this.Controls.Add(this.SouthStoplight);
            this.Controls.Add(this.NorthDownBtn);
            this.Controls.Add(this.NorthUpBtn);
            this.Controls.Add(this.NorthStoplight);
            this.Name = "Form1";
            this.Text = "Four Way Stoplight";
            ((System.ComponentModel.ISupportInitialize)(this.NorthStoplight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthStoplight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EastStoplight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WestStoplight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NorthStoplight;
        private System.Windows.Forms.PictureBox SouthStoplight;
        private System.Windows.Forms.PictureBox EastStoplight;
        private System.Windows.Forms.PictureBox WestStoplight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button SouthUpBtn;
        public System.Windows.Forms.Button SouthDownBtn;
        public System.Windows.Forms.Button EastDownBtn;
        public System.Windows.Forms.Button EastUpBtn;
        public System.Windows.Forms.Button WestDownBtn;
        public System.Windows.Forms.Button WestUpBtn;
        public System.Windows.Forms.Button NorthUpBtn;
        public System.Windows.Forms.Button NorthDownBtn;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button NorthMiddleBtn;
        public System.Windows.Forms.Button SouthMiddleBtn;
        public System.Windows.Forms.Button EastMiddleBtn;
        public System.Windows.Forms.Button WestMiddleBtn;
        public System.Windows.Forms.Label TimeLabel;
    }
}

