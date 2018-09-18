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

namespace Аттестация
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Student> students = DataGridViewUtils.GridToStudents(dataStudents);
            WorkWithStudents2 obj1 = new WorkWithStudents2();
            List<Kurs> otch = new List<LogicLibrary.Kurs>();
            otch = obj1.GetListsOtchisl(students);
            DataGridViewUtils.KursesToGrid(otch, dataOtchislenie);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ClassFile obj = new ClassFile(openFileDialog1.FileName);
                List<Student> students = obj.ReadStudent();
                DataGridViewUtils.StudentToGrid(students, dataStudents);
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateDatabase newForm = new FormCreateDatabase();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCreateDatabase newForm = new FormCreateDatabase();
            newForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void dataOtchislenie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
