namespace Аттестация
{
    partial class FormCreateDatabase
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
            this.fillRandomButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.dataStudent = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // fillRandomButton
            // 
            this.fillRandomButton.Location = new System.Drawing.Point(1118, 222);
            this.fillRandomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fillRandomButton.Name = "fillRandomButton";
            this.fillRandomButton.Size = new System.Drawing.Size(100, 98);
            this.fillRandomButton.TabIndex = 7;
            this.fillRandomButton.Text = "Заполнить случайно";
            this.fillRandomButton.UseVisualStyleBackColor = true;
            this.fillRandomButton.Click += new System.EventHandler(this.fillRandomButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(1118, 40);
            this.createButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(105, 160);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Создать базу данных";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // dataStudent
            // 
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.Year,
            this.MedB,
            this.Kurs,
            this.Group});
            this.dataStudent.Location = new System.Drawing.Point(79, 40);
            this.dataStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.RowTemplate.Height = 28;
            this.dataStudent.Size = new System.Drawing.Size(1015, 444);
            this.dataStudent.TabIndex = 4;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            // 
            // Year
            // 
            this.Year.HeaderText = "Год рождения";
            this.Year.Name = "Year";
            // 
            // MedB
            // 
            this.MedB.HeaderText = "Средние оценки за семестры";
            this.MedB.Name = "MedB";
            // 
            // Kurs
            // 
            this.Kurs.HeaderText = "Курс";
            this.Kurs.Name = "Kurs";
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.Name = "Group";
            // 
            // FormCreateDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 530);
            this.Controls.Add(this.fillRandomButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dataStudent);
            this.Name = "FormCreateDatabase";
            this.Text = "FormCreateDatabase";
            this.Load += new System.EventHandler(this.FormCreateDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fillRandomButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
    }
}