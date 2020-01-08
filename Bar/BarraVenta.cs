using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bar
{
    public partial class BarraVenta : Form
    {

        public static int idUsuario;
        public BarraVenta(int idUser)
        {
            idUsuario = idUser;
            InitializeComponent();
        }

        private void BarraVenta_Load(object sender, EventArgs e)
        {
            limpiarBotones();
            cargarMesas();
            
        }

        List<Mesa> mesas = new List<Mesa>();
        //limpia los botones para quitarle los titulos
        private void limpiarBotones()
        {
            foreach (Button boton in Controls.OfType<Button>())
            {
                //foreach (MesasBotones mesaBoton in Enum.GetValues(typeof(MesasBotones)))
                //{
                //    if (boton.Name == mesaBoton.ToString())
                //    {
                        boton.Text = "Mesa Libre"; //+ (int) mesaBoton;
                        boton.Click += new System.EventHandler(btnMesa_Click);
                //    }
                //}
            
            }
        }

        /// <summary>
        /// carga las mesas que esten en la base de datos para asignarlas al boton que correspondan
        /// si la mesa esta ocupada aparece de un color mas oscuro
        /// si la mesa esta libre apareced de un color mas brillante
        /// </summary>
        private void cargarMesas()
        {
            //Carga las mesas que estan activas y muestra en color azul las que estan ocupadas
            //se cargan las mesas como tipos de mesa para ponerla en cada una 
            DataSet1TableAdapters.obtenerMesasOcupadasTableAdapter omta = new Bar.DataSet1TableAdapters.obtenerMesasOcupadasTableAdapter();
            DataTable dtMesas = omta.GetData(null);
            
            foreach (DataRow dr in dtMesas.Rows)
            {
                Mesa mesa = new Mesa();
                mesa.IdMesa = int.Parse(dr["idMesa"].ToString());
                mesa.IdVenta = int.Parse(dr["idVenta"].ToString());
                mesa.NombreCliente = dr["alias"].ToString();
                mesa.Total = decimal.Parse(dr["total"].ToString());
                mesa.NombreMesero = dr["uid"].ToString();
                mesas.Add(mesa);
            }

            foreach (Mesa mesa in mesas)
            {
                //hacemos un switch para sacar el id de la mesa y compararla con los botones
                //cuando se cargen se cambia el color de las mesas y se les carga su info
                switch (mesa.IdMesa)
                {
                    case 1:
                        //periquera 1 
                        btnPerica1.BackColor = Color.Beige;
                        btnPerica1.Text = "Perica 1 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnPerica1, mesa.NombreMesero + " " + mesa.Total.ToString());
       
                        break;
                    case 2:
                        //periquera 2 
                        btnPerica2.BackColor = Color.Beige;
                        btnPerica2.Text = "Perica 2 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnPerica2, mesa.NombreMesero + " " + mesa.Total.ToString());
                     
                        break;
                    case 3:
                        //periquera 3
                        btnPerica3.BackColor = Color.Beige;
                        btnPerica3.Text = "Perica 3 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnPerica3, mesa.NombreMesero + " " + mesa.Total.ToString());
                       
                        break;
                    case 4:
                        //periquera 4 
                        btnPerica4.BackColor = Color.Beige;
                        btnPerica4.Text = "Perica 4 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnPerica4, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 5:
                        //periquera 5
                        btnPerica5.BackColor = Color.Beige;
                        btnPerica5.Text = "Perica 5 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnPerica5, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 6:
                        //periquera 6 
                        btnPerica6.BackColor = Color.Beige;
                        btnPerica6.Text = "Perica 6 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnPerica6, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 7:
                        //periquera 7 
                        btnPerica7.BackColor = Color.Beige;
                        btnPerica7.Text = "Perica 7 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnPerica7, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 8:
                        //periquera8 
                        btnPerica8.BackColor = Color.Beige;
                        btnPerica8.Text = "Perica 8 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnPerica8, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 9:
                        //mesa 1 
                        btnMesa1.BackColor = Color.Beige;
                        btnMesa1.Text = "Mesa 1 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnMesa1, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 10:
                        //mesa 2
                        btnMesa2.BackColor = Color.Beige;
                        btnMesa2.Text = "Mesa 2 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnMesa2, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 11:
                        //mesa 3 
                        btnMesa3.BackColor = Color.Beige;
                        btnMesa3.Text = "Mesa 3 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnMesa3, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 12:
                        //mesa 4 
                        btnMesa4.BackColor = Color.Beige;
                        btnMesa4.Text = "Mesa 4 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnMesa4, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 13:
                        //mesa 5 
                        btnMesa5.BackColor = Color.Beige;
                        btnMesa5.Text = "Mesa 5 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnMesa5, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 14:
                        //mesa 6 
                        btnMesa6.BackColor = Color.Beige;
                        btnMesa6.Text = "Mesa 6 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnMesa6, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 15:
                        //mesa 7 
                        btnMesa7.BackColor = Color.Beige;
                        btnMesa7.Text = "Mesa 7 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnMesa7, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 16:
                        //mesa 8 
                        btnMesa8.BackColor = Color.Beige;
                        btnMesa8.Text = "Mesa 8 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnMesa8, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 17:
                        //mesa 9 
                        btnMesa9.BackColor = Color.Beige;
                        btnMesa9.Text = "Mesa 9 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnMesa9, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 18:
                        //extra 1 
                        btnExtra1.BackColor = Color.Beige;
                        btnExtra1.Text = "Extra 1 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnExtra1, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 19:
                        //extra 2
                        btnExtra2.BackColor = Color.Beige;
                        btnExtra2.Text = "Extra 2 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnExtra2, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 20:
                        //extra 3
                        btnExtra3.BackColor = Color.Beige;
                        btnExtra3.Text = "Extra 3 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnExtra3, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 21:
                        //extra 4 
                        btnExtra4.BackColor = Color.Beige;
                        btnExtra4.Text = "Extra 4 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnExtra4, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 22:
                        //extra 5 
                        btnExtra5.BackColor = Color.Beige;
                        btnExtra5.Text = "Extra 5 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnExtra5, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 23:
                        //extra 6 
                        btnExtra6.BackColor = Color.Beige;
                        btnExtra6.Text = "Extra 6 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnExtra6, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 24:
                        //extra 7 
                        btnExtra7.BackColor = Color.Beige;
                        btnExtra7.Text = "Extra 7 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnExtra7, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;
                    case 25:
                        //extra 8 
                        btnExtra8.BackColor = Color.Beige;
                        btnExtra8.Text = "Extra 8 " + mesa.NombreCliente;
                        toolTip1.SetToolTip(btnExtra8, mesa.NombreMesero + " " + mesa.Total.ToString());
                        break;

                    default:
                        break;
                }

            }

            /*
            id  nombre
            1	Periquera 1
            2	Periquera 2
            3	Periquera 3
            4	Periquera 4
            5	Periquera 5
            6	Periquera 6
            7	Periquera 7
            8	Periquera 8
            9	Mesa 1
            10	Mesa 2
            11	Mesa 3
            12	Mesa 4
            13	Mesa 5
            14	Mesa 6
            15	Mesa 7
            16	Mesa 8
            17	Mesa 9
            18	Extra 1
            19	Extra 2
            20	Extra 3
            21	Extra 4
            22	Extra 5
            23	Extra 6
            24	Extra 7
            25	Extra 8*/

        }

        /// <summary>
        /// obtiene los datos del control que se mande llamar para ver la venta activa 
        /// y mandarla a la pantalla de venta 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMesa_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            string nombre = boton.Name;
           foreach(MesasBotones mesaBoton in Enum.GetValues(typeof(MesasBotones))){
               if (mesaBoton.ToString() == nombre)
               {
                   int idMesa = (int)mesaBoton;
                   foreach (Mesa mesa in mesas)
                   {
                       if (mesa.IdMesa == idMesa)
                       {
                           new Ventas(1, mesa).ShowDialog();
                           this.Show();
                           cargarMesas();
                           return;
                       }
                       
                   }

                   //obtiene la mesa que este seleccionando

                   new Ventas(1, obtenerMesaPorId((int)mesaBoton)).ShowDialog();//ventaNueva
                   this.Show();
               }
           }
           cargarMesas();
        }

        private Mesa obtenerMesaPorId(int idMesa)
        {
            Mesa mesaResult = new Mesa();
            mesaResult.IdVenta = 0;
            mesaResult.IdMesa = idMesa;
            mesaResult.Total = 0;
            return mesaResult;
        }

       
       
    }

    public enum MesasBotones
    {
        btnPerica1 = 1,
        btnPerica2 = 2,
        btnPerica3 = 3,
        btnPerica4 = 4,
        btnPerica5 = 5,
        btnPerica6 = 6,
        btnPerica7 = 7,
        btnPerica8 = 8,
        btnMesa1 = 9,
        btnMesa2 = 10,
        btnMesa3 = 11,
        btnMesa4 = 12,
        btnMesa5 = 13,
        btnMesa6 = 14,
        btnMesa7 = 15,
        btnMesa8 = 16,
        btnMesa9 = 17,
        btnExtra1 = 18,
        btnExtra2 = 19,
        btnExtra3 = 20,
        btnExtra4 = 21,
        btnExtra5 = 22,
        btnExtra6 = 23,
        btnExtra7 = 24,
        btnExtra8 = 25
    
    }

    public class Mesa 
    {

        public Mesa()
        {

        }

        private int idMesa;

        public int IdMesa
        {
            get { return idMesa; }
            set { idMesa = value; }
        }
        private int? idVenta;

        public int? IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }
        private string nombreCliente;

        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        private string nombreMesero;

        public string NombreMesero
        {
            get { return nombreMesero; }
            set { nombreMesero = value; }
        }

        private string nombreBoton;

        public string NombreBoton
        {
            get { return nombreBoton; }
            set { nombreBoton = value; }
        }



    }
}
