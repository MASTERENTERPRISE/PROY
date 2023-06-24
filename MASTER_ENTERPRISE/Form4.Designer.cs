namespace MASTER_ENTERPRISE
{
    partial class Form4
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
            label14 = new Label();
            label8 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(247, 119);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 31;
            label14.Text = "9999 BS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(191, 119);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 30;
            label8.Text = "PRECIO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 43);
            label2.Name = "label2";
            label2.Size = new Size(143, 15);
            label2.TabIndex = 29;
            label2.Text = "NOMBRE DEL PRODUCTO";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(191, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 73);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 172);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 32;
            label1.Text = "CANTIDAD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 213);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 33;
            label3.Text = "NOMBRE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 251);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 34;
            label4.Text = "DIRECCION:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 290);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 35;
            label5.Text = "TELEFONO:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(33, 23);
            textBox1.TabIndex = 36;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 213);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 23);
            textBox2.TabIndex = 37;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(132, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 23);
            textBox3.TabIndex = 38;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 282);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 39;
            // 
            // button1
            // 
            button1.Location = new Point(210, 343);
            button1.Name = "button1";
            button1.Size = new Size(143, 23);
            button1.TabIndex = 40;
            button1.Text = "Reservar Pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(365, 413);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label14);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Name = "Form4";
            Text = "PRODUCTO";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        private Label label8;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}