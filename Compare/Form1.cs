using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compare
{
    public partial class Comparison : Form
    {
        public Comparison()
        {
            InitializeComponent();
        }

         

        private void richTextBoxMaster_TextChanged(object sender, EventArgs e)
        {
            




            //richTextBox3.Controls.Add(onlyFirstList);
            // richTextBox3.Controls.Add(onlySecondList);
            // richTextBox3.Controls.Add(bothList);




        }

        private void Compare_Click(object sender, EventArgs e)
        {
            var master = richTextBox1.Text.Split('\n').ToList();
            var current = richTextBox2.Text.Split('\n').ToList();

            var onlyFirstList = master.Except(current).ToList();
            
            var onlySecondList = current.Except(master).ToList();
            
            var bothList = master.Intersect(current);
            richTextBox2.Clear();
            richTextBox1.Clear();

            //richTextBox3.Controls.Add(onlyFirstList);
            //richTextBox3.Controls.Add(onlySecondList);
            ///richTextBox3.Controls.Add(bothList);
            var str = onlyFirstList.ToString();

            richTextBox3.Lines = onlyFirstList.ToArray() ; 
            richTextBox4.Lines = onlySecondList.ToArray();
            //richTextBox.AppendText(bothList.ToString());
            richTextBox5.Lines = bothList.ToArray();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
