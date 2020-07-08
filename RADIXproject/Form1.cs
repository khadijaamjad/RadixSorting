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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterMarks em = new EnterMarks();
            em.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassMarkList Cml = new ClassMarkList();
            Cml.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewWithName VWN = new ViewWithName();
            VWN.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewWithRoll VWR = new ViewWithRoll();
            VWR.Show();
        }
    }
}
