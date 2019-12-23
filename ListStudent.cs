using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace form3
{
    public partial class ListStudent : Form
    {
        List<Student> students;
        public ListStudent(List<Student> students)
        {
            this.students = students;
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ListStudent_Load(object sender, EventArgs e)
        {
            this.listBox.DataSource = this.students;
        }
        public void selectEdit()
        {
            this.edit.Checked = true;
        }
        public void selectDelete()
        {
            this.delete.Checked = true;
        }
        private void delete_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.listBox.SelectedItem.ToString();
            Student s = new Student();
            s.Name = name;
            int i = listBox.SelectedIndex;
            if (delete.Checked)
            {
                if(i!=-1)
                {
                students.RemoveAt(i);
                this.listBox.DataSource = null;
                this.listBox.DataSource = students;
                }
            }
            else
            {
                Student ss = students[i];
                //Form2 as  new Form2(ss);
                Form2 s2 = new Form2(ss);
                s2.Visible = true;
            }
        }

        private void edit_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
