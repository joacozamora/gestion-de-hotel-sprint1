using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyPress += textBox1_KeyPress;

        }

        private void SubirPiso_Click(object sender, EventArgs e)
        {
            string labelName = "lbl" + textBox1.Text;
            string pictureName = "picture" + textBox1.Text;
            Control[] controls = this.Controls.Find(labelName, true);
            Control[] repair = this.Controls.Find(pictureName, true);
            if (controls.Length > 0 || repair.Length > 0)
            {
                Label label = (Label)controls[0];
                label.BackColor = Color.Gray;
                PictureBox picture = (PictureBox)repair[0];
                picture.BackColor = Color.Gray;
                picture.Image = WindowsFormsApp2.Properties.Resources.spray1;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string labelName = "lbl" + textBox1.Text;
            string pictureName = "picture" + textBox1.Text;
            Control[] controls = this.Controls.Find(labelName, true);
            Control[] repair = this.Controls.Find(pictureName, true);
            if (controls.Length > 0 || repair.Length > 0)
            {
                Label label = (Label)controls[0];
                label.BackColor = Color.PaleGreen;
                label.Text = "";
                PictureBox picture = (PictureBox)repair[0];
                picture.BackColor = Color.PaleGreen;
                picture.Image = null;
            }

        }
        private void CargarNombre_Click(object sender, EventArgs e)
        {
            string labelName = "lbl" + textBox1.Text;
            string pictureName = "picture" + textBox1.Text;
            Control[] controls = this.Controls.Find(labelName, true);
            Control[] repair = this.Controls.Find(pictureName, true);
            if (controls.Length > 0 || repair.Length > 0)
            {
                Label label = (Label)controls[0];
                label.BackColor = Color.Orange;
                label.Text = Nombre.Text;
                Nombre.Text = "";
                PictureBox picture = (PictureBox)repair[0];
                picture.BackColor = Color.Orange;
                picture.Image = null;
            }
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        /*public int subodepiso(int subirpiso)
        {
            int tablapiso;
            int numerodepiso = (int)numericUpDown1.Value;
            if (subirpiso == 1)
            {
                tabControl1.SelectedIndex = 1;
                tablapiso = tabControl1.SelectedIndex;
            }
            else
            {
                tabControl1.SelectedIndex = 2;
                tablapiso = tabControl1.SelectedIndex;
            }
            return subirpiso;
        }*/
        public void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int SubirPiso = Convert.ToInt32(numericUpDown1.Value);

            if (SubirPiso == 1) 
            {
                tabControl1.SelectedTab = tabPage1;
            }
            else if (SubirPiso == 2)
            {
                tabControl1.SelectedTab = tabPage2;
            }
            
            
        }

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
