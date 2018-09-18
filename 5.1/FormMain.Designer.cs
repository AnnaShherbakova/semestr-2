namespace _5._1
{
    partial class FormMain
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
            this.pBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFindBinarySearch = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox.Location = new System.Drawing.Point(0, 0);
            this.pBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(745, 540);
            this.pBox.TabIndex = 3;
            this.pBox.TabStop = false;
            this.pBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseDown);
            this.pBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseMove);
            this.pBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonFindBinarySearch);
            this.panel1.Controls.Add(this.buttonRandom);
            this.panel1.Controls.Add(this.buttonInsert);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(745, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 540);
            this.panel1.TabIndex = 2;
            // 
            // buttonFindBinarySearch
            // 
            this.buttonFindBinarySearch.Location = new System.Drawing.Point(28, 121);
            this.buttonFindBinarySearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFindBinarySearch.Name = "buttonFindBinarySearch";
            this.buttonFindBinarySearch.Size = new System.Drawing.Size(168, 71);
            this.buttonFindBinarySearch.TabIndex = 7;
            this.buttonFindBinarySearch.Text = "Найти дерево бинарного поиска";
            this.buttonFindBinarySearch.UseVisualStyleBackColor = true;
            this.buttonFindBinarySearch.Click += new System.EventHandler(this.buttonFindBinarySearch_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(23, 22);
            this.buttonRandom.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(172, 28);
            this.buttonRandom.TabIndex = 6;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(23, 73);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(172, 28);
            this.buttonInsert.TabIndex = 1;
            this.buttonInsert.Text = "Создать дерево";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 486);
            this.textBox1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 540);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFindBinarySearch;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBox1;
    }
}

