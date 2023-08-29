namespace Assignment2
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
            this.label1 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.ch1 = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fnametxt = new System.Windows.Forms.TextBox();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.gr1 = new System.Windows.Forms.RadioButton();
            this.gr2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.n2 = new System.Windows.Forms.RadioButton();
            this.n1 = new System.Windows.Forms.RadioButton();
            this.ch2 = new System.Windows.Forms.CheckBox();
            this.output = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(291, 128);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(199, 31);
            this.nametxt.TabIndex = 1;
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ch1.Location = new System.Drawing.Point(291, 333);
            this.ch1.Margin = new System.Windows.Forms.Padding(4);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(116, 29);
            this.ch1.TabIndex = 2;
            this.ch1.Text = "Football";
            this.ch1.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.submit.Location = new System.Drawing.Point(161, 491);
            this.submit.Margin = new System.Windows.Forms.Padding(4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(112, 32);
            this.submit.TabIndex = 3;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Father name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address(City)";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(28, 284);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(89, 25);
            this.gender.TabIndex = 7;
            this.gender.Text = "Gender";
            this.gender.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hobbies";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nationality";
            // 
            // fnametxt
            // 
            this.fnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxt.Location = new System.Drawing.Point(291, 176);
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(199, 31);
            this.fnametxt.TabIndex = 10;
            // 
            // citytxt
            // 
            this.citytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citytxt.Location = new System.Drawing.Point(291, 224);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(199, 31);
            this.citytxt.TabIndex = 11;
            // 
            // gr1
            // 
            this.gr1.AutoSize = true;
            this.gr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gr1.Location = new System.Drawing.Point(291, 284);
            this.gr1.Name = "gr1";
            this.gr1.Size = new System.Drawing.Size(81, 29);
            this.gr1.TabIndex = 12;
            this.gr1.TabStop = true;
            this.gr1.Text = "Male";
            this.gr1.UseVisualStyleBackColor = true;
            this.gr1.CheckedChanged += new System.EventHandler(this.gr1_CheckedChanged);
            // 
            // gr2
            // 
            this.gr2.AutoSize = true;
            this.gr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gr2.Location = new System.Drawing.Point(411, 282);
            this.gr2.Name = "gr2";
            this.gr2.Size = new System.Drawing.Size(107, 29);
            this.gr2.TabIndex = 13;
            this.gr2.TabStop = true;
            this.gr2.Text = "Female";
            this.gr2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.n2);
            this.panel1.Controls.Add(this.n1);
            this.panel1.Location = new System.Drawing.Point(291, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 42);
            this.panel1.TabIndex = 14;
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.n2.Location = new System.Drawing.Point(123, 3);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(88, 29);
            this.n2.TabIndex = 1;
            this.n2.TabStop = true;
            this.n2.Text = "Other";
            this.n2.UseVisualStyleBackColor = true;
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.n1.Location = new System.Drawing.Point(3, 3);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(94, 29);
            this.n1.TabIndex = 0;
            this.n1.TabStop = true;
            this.n1.Text = "Indian";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.CheckedChanged += new System.EventHandler(this.n1_CheckedChanged);
            // 
            // ch2
            // 
            this.ch2.AutoSize = true;
            this.ch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ch2.Location = new System.Drawing.Point(414, 333);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(105, 29);
            this.ch2.TabIndex = 15;
            this.ch2.Text = "Cricket";
            this.ch2.UseVisualStyleBackColor = true;
            this.ch2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.SystemColors.Highlight;
            this.output.Location = new System.Drawing.Point(326, 505);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 25);
            this.output.TabIndex = 16;
            this.output.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.output);
            this.Controls.Add(this.ch2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gr2);
            this.Controls.Add(this.gr1);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.fnametxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Assignment2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.CheckBox ch1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fnametxt;
        private System.Windows.Forms.TextBox citytxt;
        private System.Windows.Forms.RadioButton gr1;
        private System.Windows.Forms.RadioButton gr2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton n2;
        private System.Windows.Forms.RadioButton n1;
        private System.Windows.Forms.CheckBox ch2;
        private System.Windows.Forms.Label output;
    }
}

