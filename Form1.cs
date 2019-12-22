using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace form3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Student s1 = new Student();

            s1.Name = "Zain Ahmed Baig";
            s1.Age = 22;
            s1.Cgpa = 3.1f;
            s1.Gender = "Male";

            students.Add(s1);
            s1 = new Student();

            s1.Name = "Junaid Bin Naseem";
            s1.Age = 22;
            s1.Cgpa = 2.8f;
            s1.Gender = "Male";

            students.Add(s1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListStudent ls = new ListStudent(this.students);
            ls.selectEdit();
            ls.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(students);
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListStudent ls = new ListStudent(this.students);
            ls.selectDelete();
            ls.Show();
        }
    }
}
