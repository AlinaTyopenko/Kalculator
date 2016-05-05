﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Calc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ClickTwo);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClickTwo);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(108, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 47);
            this.button4.TabIndex = 6;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ClickTwo);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClickTwo);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(184, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "Sin";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ClickOne);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(184, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 36);
            this.button6.TabIndex = 8;
            this.button6.Text = "Cos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ClickOne);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(184, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 36);
            this.button7.TabIndex = 9;
            this.button7.Text = "√";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ClickOne);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(184, 132);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 36);
            this.button8.TabIndex = 10;
            this.button8.Text = "e";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ClickOne);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(245, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 35);
            this.button9.TabIndex = 11;
            this.button9.Text = "Tan";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ClickOne);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(245, 91);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 35);
            this.button10.TabIndex = 12;
            this.button10.Text = "2ная";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.ClickOne);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(245, 132);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 35);
            this.button11.TabIndex = 13;
            this.button11.Text = "^3";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ClickOne);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(246, 7);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(54, 35);
            this.button12.TabIndex = 14;
            this.button12.Text = "log";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.ClickOne);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(306, 7);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(54, 35);
            this.button13.TabIndex = 15;
            this.button13.Text = "atan";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.ClickTwo);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(306, 48);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(54, 35);
            this.button14.TabIndex = 16;
            this.button14.Text = "UgolCos";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.ClickOne);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(306, 91);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(54, 35);
            this.button15.TabIndex = 17;
            this.button15.Text = "x^";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.ClickTwo);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(306, 133);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(54, 35);
            this.button16.TabIndex = 18;
            this.button16.Text = "%x";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.ClickTwo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 231);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
    }
}

