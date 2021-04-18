using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            //string nombre = "Eve";
            //MessageBox.Show($"Hola {nombre}","Saludo",MessageBoxButtons.YesNoCancel);//Salta una ventana de TXT, lepone de titulo al cuadro de txt saludo
            //mesagge box buttons me da la opcion de ponerle si no cancelar y eso


            string nombre = this.TxtBoxNombre.Text;//hay que poner punto txt para qeu guarde lo que entra por teclado
            


            //validaciones por siuel usuario no iungresó nada 

            if(validarNombre(nombre))
            {
                nombre = nombre.Trim();//Quita espacios en blanco al principio y al final
                MessageBox.Show($"Hola {nombre}", "Saludo", MessageBoxButtons.YesNoCancel);//Salta una ventana de TXT, lepone de titulo al cuadro de txt saludo
            }
            else
            {
                DialogResult result= MessageBox.Show("Desea continuar?", "Alerta", MessageBoxButtons.YesNo); //DialogResult toma lo que ponemos en los botones si no
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }

           
            

        }
        private bool validarNombre(string nombre)
        {
            bool retorno=true;

            if (string.IsNullOrWhiteSpace(nombre))//valido que no haya espacio en blanco o no haya escrito nada
            {
                MessageBox.Show($"Error! Debe ingresar un nombre", "Error", MessageBoxButtons.OK);
                retorno = false;
            }
            return retorno;


        }
    }
}
