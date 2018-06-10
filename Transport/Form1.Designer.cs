namespace Transport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VolumeBar = new System.Windows.Forms.NumericUpDown();
            this.GewichtBar = new System.Windows.Forms.NumericUpDown();
            this.AfstandInBar = new System.Windows.Forms.NumericUpDown();
            this.VloeibaarBox = new System.Windows.Forms.CheckBox();
            this.AfstandUitBar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.WaardenBar = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GewichtBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AfstandInBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AfstandUitBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaardenBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Volume (m³)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gewicht (kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Afstand binnen nederland (km)";
            // 
            // VolumeBar
            // 
            this.VolumeBar.DecimalPlaces = 1;
            this.VolumeBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeBar.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.VolumeBar.Location = new System.Drawing.Point(36, 44);
            this.VolumeBar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VolumeBar.Size = new System.Drawing.Size(120, 26);
            this.VolumeBar.TabIndex = 6;
            this.VolumeBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VolumeBar.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // GewichtBar
            // 
            this.GewichtBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GewichtBar.Location = new System.Drawing.Point(36, 76);
            this.GewichtBar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.GewichtBar.Name = "GewichtBar";
            this.GewichtBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GewichtBar.Size = new System.Drawing.Size(120, 26);
            this.GewichtBar.TabIndex = 7;
            this.GewichtBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GewichtBar.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // AfstandInBar
            // 
            this.AfstandInBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfstandInBar.Location = new System.Drawing.Point(36, 108);
            this.AfstandInBar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AfstandInBar.Name = "AfstandInBar";
            this.AfstandInBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AfstandInBar.Size = new System.Drawing.Size(120, 26);
            this.AfstandInBar.TabIndex = 8;
            this.AfstandInBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AfstandInBar.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // VloeibaarBox
            // 
            this.VloeibaarBox.AutoSize = true;
            this.VloeibaarBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VloeibaarBox.Location = new System.Drawing.Point(36, 204);
            this.VloeibaarBox.Name = "VloeibaarBox";
            this.VloeibaarBox.Size = new System.Drawing.Size(95, 24);
            this.VloeibaarBox.TabIndex = 9;
            this.VloeibaarBox.Text = "Vloeibaar";
            this.VloeibaarBox.UseVisualStyleBackColor = true;
            this.VloeibaarBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AfstandUitBar
            // 
            this.AfstandUitBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfstandUitBar.Location = new System.Drawing.Point(36, 140);
            this.AfstandUitBar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.AfstandUitBar.Name = "AfstandUitBar";
            this.AfstandUitBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AfstandUitBar.Size = new System.Drawing.Size(120, 26);
            this.AfstandUitBar.TabIndex = 11;
            this.AfstandUitBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AfstandUitBar.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Afstand buiten nederland (km)";
            // 
            // WaardenBar
            // 
            this.WaardenBar.DecimalPlaces = 2;
            this.WaardenBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaardenBar.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.WaardenBar.Location = new System.Drawing.Point(36, 172);
            this.WaardenBar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.WaardenBar.Name = "WaardenBar";
            this.WaardenBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WaardenBar.Size = new System.Drawing.Size(120, 26);
            this.WaardenBar.TabIndex = 12;
            this.WaardenBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WaardenBar.ValueChanged += new System.EventHandler(this.WaardenBar_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Waarden van de laading (€)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 46);
            this.label6.TabIndex = 14;
            this.label6.Text = "€0,00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Meer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Minder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Binnenland  : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Buitenland  : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Douane      : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 458);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 19);
            this.label11.TabIndex = 27;
            this.label11.Text = "Volume/km   : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 494);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 19);
            this.label12.TabIndex = 28;
            this.label12.Text = "Gewicht/km  : ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(153, 494);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 19);
            this.label17.TabIndex = 29;
            this.label17.Text = "€0,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(153, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 19);
            this.label13.TabIndex = 30;
            this.label13.Text = "€0,00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(153, 386);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 19);
            this.label14.TabIndex = 31;
            this.label14.Text = "€0,00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(153, 422);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 19);
            this.label15.TabIndex = 32;
            this.label15.Text = "€0,00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(153, 458);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 19);
            this.label16.TabIndex = 33;
            this.label16.Text = "€0,00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-12, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 1);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(-21, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 1);
            this.panel2.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WaardenBar);
            this.Controls.Add(this.AfstandUitBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VloeibaarBox);
            this.Controls.Add(this.AfstandInBar);
            this.Controls.Add(this.GewichtBar);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Transport";
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GewichtBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AfstandInBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AfstandUitBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaardenBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown VolumeBar;
        private System.Windows.Forms.NumericUpDown GewichtBar;
        private System.Windows.Forms.NumericUpDown AfstandInBar;
        private System.Windows.Forms.CheckBox VloeibaarBox;
        private System.Windows.Forms.NumericUpDown AfstandUitBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown WaardenBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

