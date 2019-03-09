namespace WindowsFormsApplication1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.calcBTN = new System.Windows.Forms.Button();
            this.undBTN = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "length";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(287, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Area";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(169, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // calcBTN
            // 
            this.calcBTN.Location = new System.Drawing.Point(34, 84);
            this.calcBTN.Name = "calcBTN";
            this.calcBTN.Size = new System.Drawing.Size(75, 23);
            this.calcBTN.TabIndex = 6;
            this.calcBTN.Text = "Calculate";
            this.calcBTN.UseVisualStyleBackColor = true;
            this.calcBTN.Click += new System.EventHandler(this.calcBTN_Click);
            // 
            // undBTN
            // 
            this.undBTN.Location = new System.Drawing.Point(34, 114);
            this.undBTN.Name = "undBTN";
            this.undBTN.Size = new System.Drawing.Size(129, 23);
            this.undBTN.TabIndex = 7;
            this.undBTN.Text = "Add Undercoat";
            this.undBTN.UseVisualStyleBackColor = true;
            this.undBTN.Click += new System.EventHandler(this.undBTN_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(180, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 357);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.undBTN);
            this.Controls.Add(this.calcBTN);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button calcBTN;
        private System.Windows.Forms.Button undBTN;
        private System.Windows.Forms.TextBox textBox4;
    }
}

