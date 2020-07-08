using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RADIXproject
{
    public partial class ClassMarkList : Form
    {

        public ClassMarkList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClassMarkList_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           int cl=int.Parse(textBox1.Text);
            List<int> temp=new List<int>();
            List<int> temp1 = new List<int>();
            foreach (Student stu in EnterMarks.StuList)
            {
                if (int.Parse(textBox1.Text) == stu.clas)
                {
                    temp.Add(stu.TotalMarks);                    
                }
            }
            temp1 = RadixSortMarks.RAD(temp);
            var wra = (from j in temp1 select new { Value = j }).ToArray();
            grid.DataSource = wra;
          
            
        }
       
       
          
        }
    }
