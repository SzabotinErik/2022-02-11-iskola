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

namespace IskolaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var sor in File.ReadAllLines("nevek.txt"))
            {
                listBox1.Items.Add(sor);
            }
        }

        private void btntörlés_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                //hiba
                MessageBox.Show("Nem jelölt ki tanulot");
            }
            
        }

        private void btnMentés_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("nevekNEW.txt");
                sw.WriteLine(listBox1);
                sw.Close();
                MessageBox.Show("Sikeres mentés!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"sikertelen mentés! \n {ex}"); 
               
            }
            
        }
    }
}
