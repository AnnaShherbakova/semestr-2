namespace _4._1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DrawBallsButton = new System.Windows.Forms.Button();
            this.ShowGraficButton = new System.Windows.Forms.Button();
            this.fillRandonbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberElementTextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(78, 258);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 262);
            this.panel1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 77);
            this.button1.TabIndex = 18;
            this.button1.Text = "Старт анимации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DrawBallsButton
            // 
            this.DrawBallsButton.Location = new System.Drawing.Point(295, 57);
            this.DrawBallsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawBallsButton.Name = "DrawBallsButton";
            this.DrawBallsButton.Size = new System.Drawing.Size(66, 29);
            this.DrawBallsButton.TabIndex = 17;
            this.DrawBallsButton.Text = "ok";
            this.DrawBallsButton.UseVisualStyleBackColor = true;
            this.DrawBallsButton.Click += new System.EventHandler(this.DrawBallsButton_Click);
            // 
            // ShowGraficButton
            // 
            this.ShowGraficButton.Location = new System.Drawing.Point(1078, 57);
            this.ShowGraficButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowGraficButton.Name = "ShowGraficButton";
            this.ShowGraficButton.Size = new System.Drawing.Size(362, 74);
            this.ShowGraficButton.TabIndex = 16;
            this.ShowGraficButton.Text = "Показать зависимость количества обменов и сравнений от количества элементов";
            this.ShowGraficButton.UseVisualStyleBackColor = true;
            this.ShowGraficButton.Click += new System.EventHandler(this.ShowGraficButton_Click);
            // 
            // fillRandonbutton
            // 
            this.fillRandonbutton.Location = new System.Drawing.Point(74, 148);
            this.fillRandonbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fillRandonbutton.Name = "fillRandonbutton";
            this.fillRandonbutton.Size = new System.Drawing.Size(213, 54);
            this.fillRandonbutton.TabIndex = 15;
            this.fillRandonbutton.Text = "Заполнить случайными числами";
            this.fillRandonbutton.UseVisualStyleBackColor = true;
            this.fillRandonbutton.Click += new System.EventHandler(this.fillRandonbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введите количество элементов для сорторовки от 1 до 10";
            // 
            // numberElementTextBox
            // 
            this.numberElementTextBox.Location = new System.Drawing.Point(78, 61);
            this.numberElementTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberElementTextBox.Name = "numberElementTextBox";
            this.numberElementTextBox.Size = new System.Drawing.Size(213, 22);
            this.numberElementTextBox.TabIndex = 13;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend7.Alignment = System.Drawing.StringAlignment.Center;
            legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend7.Name = "Legend1";
            legend8.Alignment = System.Drawing.StringAlignment.Center;
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.Name = "Legend2";
            this.chart1.Legends.Add(legend7);
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(905, 148);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Сравнения";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend2";
            series8.Name = "Обмены";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(714, 514);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 674);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DrawBallsButton);
            this.Controls.Add(this.ShowGraficButton);
            this.Controls.Add(this.fillRandonbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberElementTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DrawBallsButton;
        private System.Windows.Forms.Button ShowGraficButton;
        private System.Windows.Forms.Button fillRandonbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberElementTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

