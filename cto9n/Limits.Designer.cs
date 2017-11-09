namespace cto9n
{
    partial class Limits
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
            this.areaButton = new System.Windows.Forms.Button();
            this.primCondButton = new System.Windows.Forms.Button();
            this.boundCondButton = new System.Windows.Forms.Button();
            this.areaType = new System.Windows.Forms.Panel();
            this.bounded = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.boundTime = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.areaBounds = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.edgeCond = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.primCond = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.primConfirm = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.edgeConfirm = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.empty = new System.Windows.Forms.Panel();
            this.areaType.SuspendLayout();
            this.boundTime.SuspendLayout();
            this.areaBounds.SuspendLayout();
            this.edgeCond.SuspendLayout();
            this.primCond.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Можна вказати такі параметри: просторово-часову область, початкові та крайові умо" +
    "ви";
            // 
            // areaButton
            // 
            this.areaButton.Location = new System.Drawing.Point(12, 37);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(75, 23);
            this.areaButton.TabIndex = 1;
            this.areaButton.Text = "область";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // primCondButton
            // 
            this.primCondButton.Location = new System.Drawing.Point(342, 37);
            this.primCondButton.Name = "primCondButton";
            this.primCondButton.Size = new System.Drawing.Size(113, 23);
            this.primCondButton.TabIndex = 2;
            this.primCondButton.Text = "початкові умови";
            this.primCondButton.UseVisualStyleBackColor = true;
            this.primCondButton.Click += new System.EventHandler(this.primCondButton_Click);
            // 
            // boundCondButton
            // 
            this.boundCondButton.Location = new System.Drawing.Point(703, 37);
            this.boundCondButton.Name = "boundCondButton";
            this.boundCondButton.Size = new System.Drawing.Size(108, 23);
            this.boundCondButton.TabIndex = 3;
            this.boundCondButton.Text = "крайові умови";
            this.boundCondButton.UseVisualStyleBackColor = true;
            this.boundCondButton.Click += new System.EventHandler(this.boundCondButton_Click);
            // 
            // areaType
            // 
            this.areaType.Controls.Add(this.bounded);
            this.areaType.Controls.Add(this.label2);
            this.areaType.Enabled = false;
            this.areaType.Location = new System.Drawing.Point(12, 81);
            this.areaType.Name = "areaType";
            this.areaType.Size = new System.Drawing.Size(280, 139);
            this.areaType.TabIndex = 8;
            this.areaType.Paint += new System.Windows.Forms.PaintEventHandler(this.areaType_Paint);
            // 
            // bounded
            // 
            this.bounded.Location = new System.Drawing.Point(6, 37);
            this.bounded.Name = "bounded";
            this.bounded.Size = new System.Drawing.Size(75, 23);
            this.bounded.TabIndex = 2;
            this.bounded.Text = "обмежена";
            this.bounded.UseVisualStyleBackColor = true;
            this.bounded.Click += new System.EventHandler(this.bounded_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Вкажіть тип просторової області";
            // 
            // boundTime
            // 
            this.boundTime.Controls.Add(this.button1);
            this.boundTime.Controls.Add(this.label4);
            this.boundTime.Controls.Add(this.textBox1);
            this.boundTime.Controls.Add(this.label3);
            this.boundTime.Location = new System.Drawing.Point(12, 81);
            this.boundTime.Name = "boundTime";
            this.boundTime.Size = new System.Drawing.Size(280, 139);
            this.boundTime.TabIndex = 8;
            this.boundTime.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.timeConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Вкажіть кінцевий момент часу Т";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "T = ";
            // 
            // areaBounds
            // 
            this.areaBounds.Controls.Add(this.label9);
            this.areaBounds.Controls.Add(this.label8);
            this.areaBounds.Controls.Add(this.label7);
            this.areaBounds.Controls.Add(this.label6);
            this.areaBounds.Controls.Add(this.textBox5);
            this.areaBounds.Controls.Add(this.textBox4);
            this.areaBounds.Controls.Add(this.textBox3);
            this.areaBounds.Controls.Add(this.textBox2);
            this.areaBounds.Controls.Add(this.button2);
            this.areaBounds.Controls.Add(this.label5);
            this.areaBounds.Location = new System.Drawing.Point(12, 81);
            this.areaBounds.Name = "areaBounds";
            this.areaBounds.Size = new System.Drawing.Size(280, 139);
            this.areaBounds.TabIndex = 4;
            this.areaBounds.Visible = false;
            this.areaBounds.Paint += new System.Windows.Forms.PaintEventHandler(this.areaBounds_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 26);
            this.label9.TabIndex = 9;
            this.label9.Text = "Задайте чотири точки - межі змінних \r\nаргументів х та у";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Yb = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Xb = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ya = ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(151, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(37, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 30);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(37, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.boundsConfirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ха = ";
            // 
            // edgeCond
            // 
            this.edgeCond.Controls.Add(this.label16);
            this.edgeCond.Controls.Add(this.label15);
            this.edgeCond.Controls.Add(this.label14);
            this.edgeCond.Controls.Add(this.label13);
            this.edgeCond.Controls.Add(this.textBox10);
            this.edgeCond.Controls.Add(this.textBox9);
            this.edgeCond.Controls.Add(this.textBox8);
            this.edgeCond.Controls.Add(this.textBox7);
            this.edgeCond.Controls.Add(this.edgeConfirm);
            this.edgeCond.Controls.Add(this.label12);
            this.edgeCond.Enabled = false;
            this.edgeCond.Location = new System.Drawing.Point(579, 81);
            this.edgeCond.Name = "edgeCond";
            this.edgeCond.Size = new System.Drawing.Size(280, 139);
            this.edgeCond.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Fyb(x, t) =";
            // 
            // primCond
            // 
            this.primCond.Controls.Add(this.textBox6);
            this.primCond.Controls.Add(this.label11);
            this.primCond.Controls.Add(this.primConfirm);
            this.primCond.Controls.Add(this.label10);
            this.primCond.Enabled = false;
            this.primCond.Location = new System.Drawing.Point(296, 81);
            this.primCond.Name = "primCond";
            this.primCond.Size = new System.Drawing.Size(280, 139);
            this.primCond.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(54, 63);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(209, 20);
            this.textBox6.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "F0(x) = ";
            // 
            // primConfirm
            // 
            this.primConfirm.Location = new System.Drawing.Point(100, 96);
            this.primConfirm.Name = "primConfirm";
            this.primConfirm.Size = new System.Drawing.Size(75, 23);
            this.primConfirm.TabIndex = 1;
            this.primConfirm.Text = "OK";
            this.primConfirm.UseVisualStyleBackColor = true;
            this.primConfirm.Click += new System.EventHandler(this.primConfirm_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Треба задати початкову умову - функцію\r\n від координати х";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Fya(x, t) =";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Fxb(y, t) =";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Fxa(y, t) =";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(60, 87);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(217, 20);
            this.textBox10.TabIndex = 5;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(60, 69);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(217, 20);
            this.textBox9.TabIndex = 4;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(60, 49);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(217, 20);
            this.textBox8.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(60, 29);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(217, 20);
            this.textBox7.TabIndex = 2;
            // 
            // edgeConfirm
            // 
            this.edgeConfirm.Location = new System.Drawing.Point(145, 113);
            this.edgeConfirm.Name = "edgeConfirm";
            this.edgeConfirm.Size = new System.Drawing.Size(33, 23);
            this.edgeConfirm.TabIndex = 1;
            this.edgeConfirm.Text = "OK";
            this.edgeConfirm.UseVisualStyleBackColor = true;
            this.edgeConfirm.Click += new System.EventHandler(this.edgeConfirm_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "Треба задати крайові умови -- функції \r\nвід часу t на всіх краях прямокутної обла" +
    "сті ";
            // 
            // empty
            // 
            this.empty.Location = new System.Drawing.Point(49, 332);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(280, 139);
            this.empty.TabIndex = 10;
            // 
            // Limits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 342);
            this.Controls.Add(this.edgeCond);
            this.Controls.Add(this.areaBounds);
            this.Controls.Add(this.boundTime);
            this.Controls.Add(this.primCond);
            this.Controls.Add(this.empty);
            this.Controls.Add(this.areaType);
            this.Controls.Add(this.boundCondButton);
            this.Controls.Add(this.primCondButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.label1);
            this.Name = "Limits";
            this.Text = "Limits";
            this.Load += new System.EventHandler(this.Limits_Load);
            this.areaType.ResumeLayout(false);
            this.areaType.PerformLayout();
            this.boundTime.ResumeLayout(false);
            this.boundTime.PerformLayout();
            this.areaBounds.ResumeLayout(false);
            this.areaBounds.PerformLayout();
            this.edgeCond.ResumeLayout(false);
            this.edgeCond.PerformLayout();
            this.primCond.ResumeLayout(false);
            this.primCond.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button primCondButton;
        private System.Windows.Forms.Button boundCondButton;
        private System.Windows.Forms.Panel areaType;
        private System.Windows.Forms.Panel boundTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bounded;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel areaBounds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel edgeCond;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button edgeConfirm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel primCond;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button primConfirm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel empty;
    }
}