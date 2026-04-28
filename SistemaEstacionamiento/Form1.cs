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

namespace SistemaEstacionamiento
{
    public partial class Form1 : Form
    { Usuario usuario = new Usuario();
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario.username = textBox1.Text;
            usuario.contraseña = textBox2.Text;

            if (Usuario.Validar(usuario.username, usuario.contraseña))
            {
                MessageBox.Show("Bienvenido al sistema");

                Form2 formulario = new Form2();
                formulario.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto \nInténtalo otra vez");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
    
}
