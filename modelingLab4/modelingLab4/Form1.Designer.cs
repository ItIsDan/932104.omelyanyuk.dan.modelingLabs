﻿namespace modelingLab4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.activate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.scaleSP = new System.Windows.Forms.NumericUpDown();
            this.timerSP = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 452);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Новая карта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // activate
            // 
            this.activate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.activate.Location = new System.Drawing.Point(383, 503);
            this.activate.Name = "activate";
            this.activate.Size = new System.Drawing.Size(94, 21);
            this.activate.TabIndex = 2;
            this.activate.Text = "Запустить";
            this.activate.UseVisualStyleBackColor = true;
            this.activate.Click += new System.EventHandler(this.activate_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(170, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Минимум для появления";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(170, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Максимум для появления";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Максимум соседей";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Минимум соседей";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clear.Location = new System.Drawing.Point(383, 533);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 21);
            this.clear.TabIndex = 2;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Масштаб";
            // 
            // scaleSP
            // 
            this.scaleSP.Location = new System.Drawing.Point(72, 542);
            this.scaleSP.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.scaleSP.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.scaleSP.Name = "scaleSP";
            this.scaleSP.Size = new System.Drawing.Size(62, 20);
            this.scaleSP.TabIndex = 21;
            this.scaleSP.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.scaleSP.ValueChanged += new System.EventHandler(this.scaleSP_ValueChanged);
            // 
            // timerSP
            // 
            this.timerSP.Location = new System.Drawing.Point(199, 542);
            this.timerSP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timerSP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timerSP.Name = "timerSP";
            this.timerSP.Size = new System.Drawing.Size(62, 20);
            this.timerSP.TabIndex = 23;
            this.timerSP.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.timerSP.ValueChanged += new System.EventHandler(this.timerSP_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Интервал";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 476);
            this.textBox1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 504);
            this.textBox2.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 25;
            this.textBox2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(310, 507);
            this.textBox4.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(46, 20);
            this.textBox4.TabIndex = 27;
            this.textBox4.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(310, 479);
            this.textBox3.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 20);
            this.textBox3.TabIndex = 26;
            this.textBox3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 569);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.timerSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.scaleSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.activate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button activate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown scaleSP;
        private System.Windows.Forms.NumericUpDown timerSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown textBox1;
        private System.Windows.Forms.NumericUpDown textBox2;
        private System.Windows.Forms.NumericUpDown textBox4;
        private System.Windows.Forms.NumericUpDown textBox3;
    }
}

