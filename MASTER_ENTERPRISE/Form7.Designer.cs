namespace MASTER_ENTERPRISE
{
    partial class Form7
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
            button1 = new Button();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(33, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(438, 160);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "PRODUCTO";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "INGRESOS";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "EGRESOS";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "DETALLE";
            Column4.Name = "Column4";
            // 
            // button1
            // 
            button1.Location = new Point(33, 51);
            button1.Name = "button1";
            button1.Size = new Size(253, 23);
            button1.TabIndex = 1;
            button1.Text = "AÑADIR PRODUCTO COMPRADO";
            button1.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.List;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 17;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(381, 121);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(66, 21);
            iconButton1.TabIndex = 3;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(335, 51);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(102, 23);
            iconButton2.TabIndex = 4;
            iconButton2.Text = "ELIMINAR";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 311);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form7";
            Text = "INGRESOS EGRESOS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}