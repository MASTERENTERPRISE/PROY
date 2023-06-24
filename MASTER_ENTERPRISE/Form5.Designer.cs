namespace MASTER_ENTERPRISE
{
    partial class Form5
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1036, 273);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "CLIENTE";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "DIRECCION";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "TELEFONO";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "PRODUCTO";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "CODIGO";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "CANTIDAD ";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "PRECIO";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "FECHA";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "HORA";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "ENTREGADO";
            Column10.Name = "Column10";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 22);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "FECHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 22);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "CODIGO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 25);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 3;
            label3.Text = "PRODUCTO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(85, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(360, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(556, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(662, 25);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1060, 420);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form5";
            Text = "LISTA DE PEDIDOS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}