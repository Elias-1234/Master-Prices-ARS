using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_PROYECT
{
    public partial class FormMetodoPago : Form
    {
        private string metodoPagoSeleccionado = string.Empty; // Inicializar para evitar CS8618
        private string metodoPagoTipoSeleccionado = string.Empty; // Inicializar para evitar CS8618
        private int codigoMetodoPagoSeleccionado = 0; // Variable para almacenar el código del método de pago seleccionado
        decimal totalVenta = 0; // Variable para almacenar el total de la venta
        decimal valor = 0; // Variable para almacenar el valor del botón presionado
        public FormMetodoPago()
        {
            InitializeComponent();
            this.KeyPreview = true;


        }

        public string MetodoPagoSeleccionado
        {
            get { return metodoPagoSeleccionado; }
        }

        public string MetodoPagoTipoSeleccionado
        {
            get { return metodoPagoTipoSeleccionado; }
        }
        public int CodigoMetodoPagoSeleccionado
        {
            get { return codigoMetodoPagoSeleccionado; }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Form1 form1 = Application.OpenForms["Form1"] as Form1;

                if (form1 != null)
                {
                    totalVenta = form1.Total;
                    txtTotalVenta.Text = $"Total: {totalVenta.ToString()}";
                    // Mostrar el total de la venta en formato de moneda
                    try
                    {

                        form1.Vender();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al limpiar la tabla de ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.Close(); // Cerrar el formulario
                return true; // Indicar que la tecla fue procesada
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            metodoPagoSeleccionado = "EFECTIVO";
            metodoPagoTipoSeleccionado = "EFECTIVO";
            codigoMetodoPagoSeleccionado = 1; // Asignar el código correspondiente para efectivo
            txtMetodoSeleccionado.Text = metodoPagoSeleccionado;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            metodoPagoTipoSeleccionado = "TARJETA";
            metodoPagoSeleccionado = "MASTERCARD";
            codigoMetodoPagoSeleccionado = 2; // Asignar el código correspondiente para efectivo
            txtMetodoSeleccionado.Text = metodoPagoSeleccionado;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            metodoPagoTipoSeleccionado = "TARJETA";
            metodoPagoSeleccionado = "VISA";
            codigoMetodoPagoSeleccionado = 3; // Asignar el código correspondiente para efectivo
            txtMetodoSeleccionado.Text = metodoPagoSeleccionado;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            metodoPagoTipoSeleccionado = "TARJETA";
            metodoPagoSeleccionado = "MERCADO PAGO";
            codigoMetodoPagoSeleccionado = 4; // Asignar el código correspondiente para efectivo
            txtMetodoSeleccionado.Text = metodoPagoSeleccionado;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            metodoPagoTipoSeleccionado = "TARJETA";
            metodoPagoSeleccionado = "CHIGUE";
            codigoMetodoPagoSeleccionado = 5; // Asignar el código correspondiente para efectivo
            txtMetodoSeleccionado.Text = metodoPagoSeleccionado;
        }

        private void FormMetodoPago_Load(object sender, EventArgs e)
        {
            if (codigoMetodoPagoSeleccionado == null)
            {
                metodoPagoSeleccionado = "EFECTIVO";
                metodoPagoTipoSeleccionado = "EFECTIVO";
                codigoMetodoPagoSeleccionado = 1; // Asignar el código correspondiente para efectivo
            }
        }

        private void txtEntrega_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEntrega.Text))
            {
                decimal entrega = Convert.ToDecimal(txtEntrega.Text);
                if (entrega >= totalVenta)
                {
                    decimal cambio = entrega - totalVenta;
                    txtCambio.Text = cambio.ToString();
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            valor += Convert.ToDecimal(botonPresionado.Text);
            txtEntrega.Text = valor.ToString();
        }
    }
}
