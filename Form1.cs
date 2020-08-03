using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloFacturas
{
    public partial class Form1 : Form
    {
        
       
        List<ClsFactura> Listafactura = new List<ClsFactura>();
        public Form1()
        {
            InitializeComponent();
            
            
             
                
               
        }
        
        public void GuardarFactura()
        {
            ClsFactura factura = new ClsFactura(int.Parse(txtFactura.Text), txtProveedor.Text, txtDetalle.Text, int.Parse(txtTotales.Text));
            Listafactura.Add(factura);
            MessageBox.Show("Factura ingresada correctamente.\nNumero: " + txtFactura.Text + "\nProveedor: " + txtProveedor.Text +
                            "\nDetalle: " + txtDetalle.Text + "\nTotal: $" + txtTotales.Text);
        }

        public void btnIngresar_Click(object sender, EventArgs e)
        {
            GuardarFactura();
           



        }

        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }


        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo Puede ingresar Numeros", "Modulo Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtTotales_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTotales_KeyDown(object sender, KeyEventArgs e)
        {
          if ( e.KeyCode == Keys.Enter)
            {
                if (txtFactura.Text.Equals("")|| txtProveedor.Text.Equals("")|| txtDetalle.Text.Equals("") || txtTotales.Equals(""))
                {
                    MessageBox.Show("Debe ingrear todos los datos requeridos", "Modulo Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GuardarFactura();
                }
            }

        }
    }
   
}
