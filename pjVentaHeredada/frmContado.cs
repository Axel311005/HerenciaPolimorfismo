using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjVentaHeredada
{
    public partial class frmContado : Form
    {

        //inicializacion del arreglo del producto

        static string[] productos =
        {
            "Lavadora","Refrigeradora","Licuadora","Extractora","Radiograbadora","DVD","BluRay"
        };

        //Variable acumuladora de totales

        double tSubTotal=0;



        public frmContado()
        {
            InitializeComponent();
        }

        private void frmContado_Load(object sender, EventArgs e)
        {
            cboProducto.DataSource = productos;
            MostrarFecha();
            MostrarHora();


            lblNeto.Text = "0.00";


        }

        private void MostrarHora()
        {
            lblHora.Text =DateTime.Now.ToShortTimeString();
        }

        private void MostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            //Objeto de la clase Contado

            Contado objC = new();

            //Datos del cliente

            objC.Cliente = txtCliente.Text;
            objC.RUC = txtRUC.Text;
            objC.Fecha = DateTime.Parse(lblFecha.Text);
            objC.Hora=DateTime.Parse(lblHora.Text);

            //Datos del producto

            objC.Producto = cboProducto.Text;
            objC.Cantidad=int.Parse(txtCantidad.Text);

            //Imprimiendo en la lista

            ListViewItem fila=new ListViewItem(objC.GetN().ToString());
            fila.SubItems.Add(objC.Producto);
            fila.SubItems.Add(objC.Cantidad.ToString());
            fila.SubItems.Add(objC.asignarPrecio().ToString("C"));
            fila.SubItems.Add(objC.CalculaSubtotal().ToString());
            lvDetalle.Items.Add(fila);
            Listado(objC);



        }

        private void Listado(Contado objC)
        {
            tSubTotal += objC.CalculaSubtotal();
            lstResumen.Items.Clear();
            lstResumen.Items.Add("*RESUMEN DE VENTA*");
            lstResumen.Items.Add("-------------------------------------");
            lstResumen.Items.Add($"CLIENTE: { objC.Cliente}");
            lstResumen.Items.Add($"RUC: { objC.RUC}");
            lstResumen.Items.Add($"FECHA: { objC.Fecha}");
            lstResumen.Items.Add($"HORA: { objC.Hora}");
            lstResumen.Items.Add("-------------------------------------");
            lstResumen.Items.Add($"SUBTOTAL: { tSubTotal.ToString("C")}");
            double descuento = objC.CalculaDescuento(tSubTotal);
            double neto = objC.CalcularNeto(tSubTotal, descuento);
            lstResumen.Items.Add($"DESCUENTO: {descuento.ToString("C")}");
            lstResumen.Items.Add($"NETO: {neto.ToString("C")}");




        }
    }
}
