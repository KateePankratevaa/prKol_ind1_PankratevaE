using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace ИЗ2
{
    public partial class Form1 : Form
    {
        string file;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void button1_Click_1(object sender, EventArgs e)
        {
            string line;
            Queue<Member> all = new Queue<Member>();
            StreamReader file = new StreamReader("members.txt");
            while ((line = file.ReadLine()) != null)
            {
                Member m = new Member();
                string[] t = line.Split(',');
                m.surname = t[0];
                m.name = t[1];
                m.patronymic = t[2];
                m.pol = t[3];
                m.age = t[4];
                m.salary = t[5];
                all.Enqueue(m);
            }
            label1.Text = "мужчины\n";
            foreach (Member member in all)
                if (member.pol.Trim() == "муж")
                    label1.Text = member.pol.Trim();
            label1.Text = "\nженщины\n";
            foreach (Member member in all)
                if (member.pol.Trim() == "жен")
                    label1.Text = member.pol.Trim();
            Console.ReadKey();
        }
    }
}
