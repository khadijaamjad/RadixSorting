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

namespace RADIXproject
{
    public partial class EnterMarks : Form
    {
        public static List<Student> StuList = new List<Student>();

        public EnterMarks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tot = CalculateTotal();
            int grd=int.Parse(textBox7.Text);
            int s1= int.Parse(textBox1.Text);
            int s2= int.Parse(textBox2.Text);
            int s3= int.Parse(textBox3.Text);
            int s4= int.Parse(textBox4.Text);
            int s5= int.Parse(textBox5.Text);
            int s6= int.Parse(textBox6.Text);
            int roll=int.Parse(textBox9.Text);
            string n= textBox8.Text;
            int[] arr= {s1,s2,s3,s4,s5,s6};
             Student s=new Student(n, tot,roll ,arr,grd);
            label9.Text = tot.ToString();
            StuList.Add(s);
            SaveToFile();
            switch (grd)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    MessageBox.Show("Total Marks Added!");
                    break;
                default:
                    MessageBox.Show("Invalid class entered!");
                    break;
            }
        }
        private int CalculateTotal()
        {
            int tot = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text) + int.Parse(textBox6.Text);
            return tot;
        }
        private void ClearText()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        public static void SaveToFile()
        {
            using (TextWriter tw = new StreamWriter("StudentData.txt"))
            {
                foreach (Student stu in StuList)
                {
                    tw.WriteLine(string.Format("NAME: {0} - CLASS: {1} - TOTAL: {2}", stu.NameStu, stu.clas,stu.TotalMarks));
                }
            }
        }
    }
}
