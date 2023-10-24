using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSystem
{
    public partial class Form1 : Form
    {
        private DataTable dataTable1 = new DataTable();
        private DataTable dataTable2 = new DataTable();
        public Form1()
        {
            InitializeComponent();
            textBox_Title.TextChanged += TextBox_Title_TextChanged;
            textBox_Author.TextChanged += TextBox_Author_TextChanged;
            textBox_Description.TextChanged += TextBox_Description_TextChanged;
            textBox_Info.TextChanged += TextBox_Info_TextChanged;
            textBox_CountOfQuest.TextChanged += TextBox_CountOfQuest_TextChanged;
            textBox_MaxPoint.TextChanged += TextBox_MaxPoint_TextChanged;
            domainUpDown_Min_pas.TextChanged += DomainUpDown_Min_pas_TextChanged;
           
            dataTable1.Columns.Add("Question", typeof(string));
            dataTable2.Columns.Add("Poin", typeof(int));
            dataGridView1.DataSource = dataTable1;

            dataTable2.Columns.Add("Answer", typeof(string));
            dataTable2.Columns.Add("Is right", typeof(bool));

            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;
            dataGridView2.CellEndEdit += DataGridView2_CellEndEdit;
        }

        private void DataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if(rowIndex >= 0 && columnIndex >= 0)
            {
                string answer = dataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
                bool isRight = Convert.ToBoolean(dataGridView2.Rows[rowIndex].Cells[1].Value);
            }
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if(rowIndex >= 0 && columnIndex >= 0)
            {
                string question = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                int point = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[1].Value);
            }
        }

        private void DomainUpDown_Min_pas_TextChanged(object sender, EventArgs e)
        {
            string min_pas = domainUpDown_Min_pas.Text;
        }

        private void TextBox_MaxPoint_TextChanged(object sender, EventArgs e)
        {
            string maxPoint = textBox_MaxPoint.Text;
        }

        private void TextBox_CountOfQuest_TextChanged(object sender, EventArgs e)
        {
            string countOfQuest = textBox_CountOfQuest.Text;
        }

        private void TextBox_Info_TextChanged(object sender, EventArgs e)
        {
            string info = textBox_Info.Text;
        }

        private void TextBox_Description_TextChanged(object sender, EventArgs e)
        {
            string description = textBox_Description.Text;
        }

        private void TextBox_Author_TextChanged(object sender, EventArgs e)
        {
            string author = textBox_Author.Text;
        }

        private void TextBox_Title_TextChanged(object sender, EventArgs e)
        {
            string title = textBox_Title.Text;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
