namespace _6
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonEyler = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExample3 = new System.Windows.Forms.Button();
            this.buttonExample2 = new System.Windows.Forms.Button();
            this.buttonExample1 = new System.Windows.Forms.Button();
            this.buttonGamilton = new System.Windows.Forms.Button();
            this.textBoxExit = new System.Windows.Forms.TextBox();
            this.textBoxEntrance = new System.Windows.Forms.TextBox();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(639, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 82);
            this.button1.TabIndex = 28;
            this.button1.Text = "Загрузить граф";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(639, 62);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(895, 480);
            this.pictureBox.TabIndex = 27;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            // 
            // buttonEyler
            // 
            this.buttonEyler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEyler.Location = new System.Drawing.Point(1253, 583);
            this.buttonEyler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEyler.Name = "buttonEyler";
            this.buttonEyler.Size = new System.Drawing.Size(296, 82);
            this.buttonEyler.TabIndex = 26;
            this.buttonEyler.Text = "Пути, не пересекающиеся по дорогам";
            this.buttonEyler.UseVisualStyleBackColor = true;
            this.buttonEyler.Click += new System.EventHandler(this.buttonEyler_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 619);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Выходы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Входы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(635, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Визуализация:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Матрица смежности:";
            // 
            // buttonExample3
            // 
            this.buttonExample3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExample3.Location = new System.Drawing.Point(426, 699);
            this.buttonExample3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExample3.Name = "buttonExample3";
            this.buttonExample3.Size = new System.Drawing.Size(133, 40);
            this.buttonExample3.TabIndex = 21;
            this.buttonExample3.Text = "Пример 3";
            this.buttonExample3.UseVisualStyleBackColor = true;
            this.buttonExample3.Click += new System.EventHandler(this.buttonExample3_Click);
            // 
            // buttonExample2
            // 
            this.buttonExample2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExample2.Location = new System.Drawing.Point(223, 699);
            this.buttonExample2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExample2.Name = "buttonExample2";
            this.buttonExample2.Size = new System.Drawing.Size(133, 40);
            this.buttonExample2.TabIndex = 20;
            this.buttonExample2.Text = "Пример 2";
            this.buttonExample2.UseVisualStyleBackColor = true;
            this.buttonExample2.Click += new System.EventHandler(this.buttonExample2_Click);
            // 
            // buttonExample1
            // 
            this.buttonExample1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExample1.Location = new System.Drawing.Point(26, 699);
            this.buttonExample1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExample1.Name = "buttonExample1";
            this.buttonExample1.Size = new System.Drawing.Size(133, 40);
            this.buttonExample1.TabIndex = 19;
            this.buttonExample1.Text = "Пример 1";
            this.buttonExample1.UseVisualStyleBackColor = true;
            this.buttonExample1.Click += new System.EventHandler(this.buttonExample1_Click);
            // 
            // buttonGamilton
            // 
            this.buttonGamilton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGamilton.Location = new System.Drawing.Point(951, 583);
            this.buttonGamilton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGamilton.Name = "buttonGamilton";
            this.buttonGamilton.Size = new System.Drawing.Size(296, 82);
            this.buttonGamilton.TabIndex = 18;
            this.buttonGamilton.Text = "Пути, не пересекающиеся по узлам";
            this.buttonGamilton.UseVisualStyleBackColor = true;
            this.buttonGamilton.Click += new System.EventHandler(this.buttonGamilton_Click);
            // 
            // textBoxExit
            // 
            this.textBoxExit.Location = new System.Drawing.Point(26, 645);
            this.textBoxExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExit.Name = "textBoxExit";
            this.textBoxExit.Size = new System.Drawing.Size(534, 22);
            this.textBoxExit.TabIndex = 17;
            // 
            // textBoxEntrance
            // 
            this.textBoxEntrance.Location = new System.Drawing.Point(26, 583);
            this.textBoxEntrance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEntrance.Name = "textBoxEntrance";
            this.textBoxEntrance.Size = new System.Drawing.Size(534, 22);
            this.textBoxEntrance.TabIndex = 16;
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvMatrix.Location = new System.Drawing.Point(26, 62);
            this.dgvMatrix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.RowTemplate.Height = 28;
            this.dgvMatrix.Size = new System.Drawing.Size(533, 480);
            this.dgvMatrix.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 873);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonEyler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExample3);
            this.Controls.Add(this.buttonExample2);
            this.Controls.Add(this.buttonExample1);
            this.Controls.Add(this.buttonGamilton);
            this.Controls.Add(this.textBoxExit);
            this.Controls.Add(this.textBoxEntrance);
            this.Controls.Add(this.dgvMatrix);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Click += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonEyler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExample3;
        private System.Windows.Forms.Button buttonExample2;
        private System.Windows.Forms.Button buttonExample1;
        private System.Windows.Forms.Button buttonGamilton;
        private System.Windows.Forms.TextBox textBoxExit;
        private System.Windows.Forms.TextBox textBoxEntrance;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

