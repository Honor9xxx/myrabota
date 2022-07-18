
namespace WindowsFormsApp132
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.Lblfirst = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Increment = new System.Windows.Forms.Button();
            this.Decrement = new System.Windows.Forms.Button();
            this.Increase = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Lblresult = new System.Windows.Forms.Label();
            this.Txtresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(270, 100);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(135, 20);
            this.txtfirst.TabIndex = 2;
            this.txtfirst.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtfirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtfirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(270, 174);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(135, 20);
            this.txt2.TabIndex = 3;
            this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Lblfirst
            // 
            this.Lblfirst.AutoSize = true;
            this.Lblfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblfirst.Location = new System.Drawing.Point(91, 162);
            this.Lblfirst.Name = "Lblfirst";
            this.Lblfirst.Size = new System.Drawing.Size(106, 31);
            this.Lblfirst.TabIndex = 4;
            this.Lblfirst.Text = "2 негр:";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(91, 88);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(106, 31);
            this.Lbl2.TabIndex = 5;
            this.Lbl2.Text = "1 негр:";
            // 
            // Increment
            // 
            this.Increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Increment.Location = new System.Drawing.Point(54, 258);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(50, 50);
            this.Increment.TabIndex = 6;
            this.Increment.Text = "+";
            this.Increment.UseVisualStyleBackColor = true;
            this.Increment.Click += new System.EventHandler(this.Btn_click);
            // 
            // Decrement
            // 
            this.Decrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrement.Location = new System.Drawing.Point(161, 258);
            this.Decrement.Name = "Decrement";
            this.Decrement.Size = new System.Drawing.Size(50, 50);
            this.Decrement.TabIndex = 7;
            this.Decrement.Text = "-";
            this.Decrement.UseVisualStyleBackColor = true;
            this.Decrement.Click += new System.EventHandler(this.Btn_click);
            // 
            // Increase
            // 
            this.Increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Increase.Location = new System.Drawing.Point(270, 258);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(50, 50);
            this.Increase.TabIndex = 8;
            this.Increase.Text = "*";
            this.Increase.UseVisualStyleBackColor = true;
            this.Increase.Click += new System.EventHandler(this.Btn_click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(375, 258);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(50, 50);
            this.Divide.TabIndex = 9;
            this.Divide.Text = ":";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Btn_click);
            // 
            // Lblresult
            // 
            this.Lblresult.AutoSize = true;
            this.Lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblresult.Location = new System.Drawing.Point(31, 369);
            this.Lblresult.Name = "Lblresult";
            this.Lblresult.Size = new System.Drawing.Size(229, 39);
            this.Lblresult.TabIndex = 10;
            this.Lblresult.Text = "Итог негров:";
            // 
            // Txtresult
            // 
            this.Txtresult.AutoSize = true;
            this.Txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtresult.Location = new System.Drawing.Point(299, 370);
            this.Txtresult.Name = "Txtresult";
            this.Txtresult.Size = new System.Drawing.Size(37, 39);
            this.Txtresult.TabIndex = 11;
            this.Txtresult.Text = "0";
            this.Txtresult.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(499, 460);
            this.Controls.Add(this.Txtresult);
            this.Controls.Add(this.Lblresult);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Increase);
            this.Controls.Add(this.Decrement);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lblfirst);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txtfirst);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label Lblfirst;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Button Increment;
        private System.Windows.Forms.Button Decrement;
        private System.Windows.Forms.Button Increase;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Label Lblresult;
        private System.Windows.Forms.Label Txtresult;
    }
}