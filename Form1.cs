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


        private void CambiarColorControl(string controlName, Color color)
        {
            Control[] controls = this.Controls.Find(controlName, true);
            if (controls.Length > 0)
            {
                if (controls[0] is Label label)
                {
                    label.BackColor = color;
                }
                else if (controls[0] is PictureBox picture)
                {
                    picture.BackColor = color;
                }
            }
        }
        
        
        private void Cambiarimagen(string pictureName, Image nuevaImagen)
        {
            Control[] controls = this.Controls.Find(pictureName, true);
            if (controls.Length > 0 && controls[0] is PictureBox picture)
            {
                picture.Image = nuevaImagen;
            }
        }
        private void CambiarNombreLabel(string labelName, string nuevoNombre)
        {
            Control[] controls = this.Controls.Find(labelName, true);
            if (controls.Length > 0 && controls[0] is Label label)
            {
                label.Text = nuevoNombre;
            }
        }


        private void SubirPiso_Click(object sender, EventArgs e)
        {
            CambiarColorControl("lbl" + textBox1.Text, Color.Gray);
            CambiarColorControl("picture" + textBox1.Text, Color.Gray);
            CambiarNombreLabel("lbl" + textBox1.Text, " ");
            Cambiarimagen("picture" + textBox1.Text, WindowsFormsApp2.Properties.Resources.spray1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CambiarColorControl("lbl" + textBox1.Text, Color.PaleGreen);
            CambiarColorControl("picture" + textBox1.Text, Color.PaleGreen);
            CambiarNombreLabel("lbl" + textBox1.Text, " ");
            Cambiarimagen("picture" + textBox1.Text, null);
            

        }

        private void CargarNombre_Click(object sender, EventArgs e)
        {

            CambiarColorControl("lbl" + textBox1.Text, Color.Orange);
            CambiarColorControl("picture" + textBox1.Text, Color.Orange);
            CambiarNombreLabel("lbl" + textBox1.Text, Nombre.Text);
            Cambiarimagen("picture" + textBox1.Text, null);
            
            if (!ValidarNumero(textBox1.Text))
            {
                
                MessageBox.Show("Esa habitación no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        
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

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool ValidarNumero(string texto)
        {
            int value;
            if (int.TryParse(texto, out value))
            {
                
                if ((value >= 101 && value <= 106) || (value >= 201 && value <= 206))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
