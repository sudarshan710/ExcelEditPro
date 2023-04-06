namespace ExcelEditPro
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            excelSrc = new Label();
            textBox1 = new TextBox();
            uploadBtn = new Button();
            path = new Label();
            dataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // excelSrc
            // 
            excelSrc.AutoSize = true;
            excelSrc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            excelSrc.Location = new Point(12, 68);
            excelSrc.Name = "excelSrc";
            excelSrc.Size = new Size(251, 28);
            excelSrc.TabIndex = 0;
            excelSrc.Text = "Enter source to excel sheet :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(269, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 34);
            textBox1.TabIndex = 1;
            // 
            // uploadBtn
            // 
            uploadBtn.FlatStyle = FlatStyle.Popup;
            uploadBtn.Location = new Point(823, 69);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(130, 46);
            uploadBtn.TabIndex = 2;
            uploadBtn.Text = "Upload";
            uploadBtn.UseVisualStyleBackColor = true;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // path
            // 
            path.AutoSize = true;
            path.Location = new Point(269, 109);
            path.Name = "path";
            path.Size = new Size(151, 20);
            path.TabIndex = 3;
            path.Text = "This is the path of file";
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Dock = DockStyle.Bottom;
            dataGrid.Location = new Point(0, 377);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 29;
            dataGrid.Size = new Size(1198, 424);
            dataGrid.TabIndex = 4;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 801);
            Controls.Add(dataGrid);
            Controls.Add(path);
            Controls.Add(uploadBtn);
            Controls.Add(textBox1);
            Controls.Add(excelSrc);
            MaximumSize = new Size(1216, 848);
            MinimumSize = new Size(1216, 848);
            Name = "Main";
            Text = "ExcelEditPro";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label excelSrc;
        private TextBox textBox1;
        private Button uploadBtn;
        private Label path;
        private DataGridView dataGrid;
    }
}