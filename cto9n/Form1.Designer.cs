namespace cto9n
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
            this.GreenButton = new System.Windows.Forms.RadioButton();
            this.DiffOperatorButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Для початку треба описати модель";
            // 
            // GreenButton
            // 
            this.GreenButton.AutoSize = true;
            this.GreenButton.Location = new System.Drawing.Point(76, 115);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(127, 17);
            this.GreenButton.TabIndex = 1;
            this.GreenButton.Text = "через функцію Гріна";
            this.GreenButton.UseVisualStyleBackColor = true;
            this.GreenButton.CheckedChanged += new System.EventHandler(this.GreenButton_CheckedChanged);
            // 
            // DiffOperatorButton
            // 
            this.DiffOperatorButton.AutoSize = true;
            this.DiffOperatorButton.Location = new System.Drawing.Point(76, 138);
            this.DiffOperatorButton.Name = "DiffOperatorButton";
            this.DiffOperatorButton.Size = new System.Drawing.Size(179, 17);
            this.DiffOperatorButton.TabIndex = 2;
            this.DiffOperatorButton.Text = "диференціальним оператором";
            this.DiffOperatorButton.UseVisualStyleBackColor = true;
            this.DiffOperatorButton.CheckedChanged += new System.EventHandler(this.DiffOperatorButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "спосіб задання моделі";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiffOperatorButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton GreenButton;
        private System.Windows.Forms.RadioButton DiffOperatorButton;
        private System.Windows.Forms.Label label2;
    }
}

