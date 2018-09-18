using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLibrary;
using System.IO;

namespace _3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ClassFile obj = new ClassFile(openFileDialog1.FileName);
                    OriginalTextBox.Text = obj.FileToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при открытии файла");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ClassFile obj = new ClassFile(saveFileDialog1.FileName);
                obj.StringToFile(ResultTextBox.Text);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                MyQueue originalQueue = new MyQueue();
                originalQueue = ConvertUtils.StringToMyQueue(OriginalTextBox.Text);
                originalQueue.AddPositiveItemAfterNegative();
                ResultTextBox.Text = ConvertUtils.MyQueueToString(originalQueue);
                MessageBox.Show("Готово");
            }
            catch
            {
                MessageBox.Show("Ошибка при работе со стеком");
            }
        }
    }
}
