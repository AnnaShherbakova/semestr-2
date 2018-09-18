namespace Аттестация
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataOtchislenie = new System.Windows.Forms.DataGridView();
            this.FIO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedB2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataStudents = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataOtchislenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudents)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(902, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 74);
            this.button1.TabIndex = 5;
            this.button1.Text = "Получить списки отчисления";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataOtchislenie
            // 
            this.dataOtchislenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOtchislenie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO2,
            this.Year2,
            this.MedB2,
            this.Kurs2,
            this.Group2});
            this.dataOtchislenie.Location = new System.Drawing.Point(1041, 30);
            this.dataOtchislenie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataOtchislenie.Name = "dataOtchislenie";
            this.dataOtchislenie.RowTemplate.Height = 28;
            this.dataOtchislenie.Size = new System.Drawing.Size(846, 417);
            this.dataOtchislenie.TabIndex = 6;
            // 
            // FIO2
            // 
            this.FIO2.HeaderText = "ФИО";
            this.FIO2.Name = "FIO2";
            // 
            // Year2
            // 
            this.Year2.HeaderText = "Год рождения";
            this.Year2.Name = "Year2";
            // 
            // MedB2
            // 
            this.MedB2.HeaderText = "Средние оценки за семестр";
            this.MedB2.Name = "MedB2";
            // 
            // Kurs2
            // 
            this.Kurs2.HeaderText = "Курс";
            this.Kurs2.Name = "Kurs2";
            // 
            // Group2
            // 
            this.Group2.HeaderText = "Группа";
            this.Group2.Name = "Group2";
            // 
            // dataStudents
            // 
            this.dataStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.Year,
            this.MedB,
            this.Kurs,
            this.Group});
            this.dataStudents.Location = new System.Drawing.Point(0, 30);
            this.dataStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataStudents.Name = "dataStudents";
            this.dataStudents.RowTemplate.Height = 28;
            this.dataStudents.Size = new System.Drawing.Size(860, 417);
            this.dataStudents.TabIndex = 4;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            // 
            // Year
            // 
            this.Year.HeaderText = "Год роджения";
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1648, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.createToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataOtchislenie);
            this.Controls.Add(this.dataStudents);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOtchislenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudents)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataOtchislenie;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedB2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group2;
        private System.Windows.Forms.DataGridView dataStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

