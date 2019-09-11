using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            int numero, total, contador;
            numero = int.Parse(txtnumero.Text);
            contador = 0;
            int limite = 10;
            for (int i = 1; i <= limite; i++)
                
            {
               
                 contador = contador+1;
                total = numero * contador;
                
              
                
               
                dgtabla.Rows.Add(numero, contador.ToString(), total.ToString());
               

               

            }

           


        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

            dgtabla.Rows.Clear();


            txtnumero.Text = "";
            txtnumero.Focus();
        }
    }
}
