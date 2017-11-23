using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Vista {
    public partial class Principal : Form {

        TextBox[] txtBox;
        Label[] lbl;
        public BindingList<Empleado> lista;

        int n = 4;
        int space = 20;
        int yIni = 150;


        private frmGestionProductos formGestionProd = null;
        private fmrRegistrarSolicitudSuministro formSoliSumin = null;
        private UsuarioBL gestorEmpleado;
        private BindingList<Empleado> listaEmpleadosConectados;

        
        public Principal() {
            InitializeComponent();
            this.formGestionProd = new frmGestionProductos();
            this.formSoliSumin = new fmrRegistrarSolicitudSuministro();
            gestorEmpleado = new UsuarioBL();
            actualizarChat();

            //listaEmpleadosConectados = gestorEmpleado.obtenerEmpleadosConectados();
            byte[] data = new byte[1024];
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 8888);

            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.Bind(endPoint);

            Console.WriteLine("Waiting for client...");

            EndPoint remote = (EndPoint)endPoint;

            int recv = sck.ReceiveFrom(data, ref remote);

            Console.WriteLine("Mensaje del admin(java): " + Encoding.ASCII.GetString(data, 0, recv));

        }

        public void actualizarChat()
        {
            //gestorEmpleado = new UsuarioBL();            
            BindingList<Empleado> lista = new BindingList<Empleado>();
            //Thread hilo = new Thread(() => gestorEmpleado.obtenerEmpleadosConectados(lista));
            //gestorEmpleado.obtenerEmpleadosConectados(lista);

            //hilo.Start();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void btnBuscarProd_Click(object sender, EventArgs e) {
            frmGestionProductos frmProd = new frmGestionProductos();            
            frmProd.Show();
        }

        private void btnRegSolSum_Click(object sender, EventArgs e) {
            fmrRegistrarSolicitudSuministro frmSol = new fmrRegistrarSolicitudSuministro();
            frmSol.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonMenu_Click(object sender, EventArgs e)
        {
            if(sideMenu.Width == 50)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 260;
                
            }
        }

        private void Bus_Click(object sender, EventArgs e)
        {
            //this.formGestionProd = new frmGestionProductos();
            this.formGestionProd.TopLevel = false;
            this.formGestionProd.Visible = true;
            this.formSoliSumin.Visible = false;
            this.Controls.Add(this.formGestionProd);            
            this.ArrangeFormSize(1);
            this.formSoliSumin.Hide();
        }

        private void Principal_SizeChange(object sender, EventArgs e)
        {
            this.ArrangeFormSize(1);
        }

        private void ArrangeFormSize(int opcion)
        {
            if(opcion == 1)
                this.formGestionProd.Location = new Point(this.ClientSize.Width - this.formGestionProd.Width-160, this.ClientSize.Height - this.formGestionProd.Height-20);
            else if(opcion == 2)
                this.formSoliSumin.Location = new Point(this.ClientSize.Width - this.formSoliSumin.Width-160, this.ClientSize.Height - this.formSoliSumin.Height-40);
        }

        private void botonSolSumin_Click(object sender, EventArgs e)
        {
            //this.formSoliSumin = new fmrRegistrarSolicitudSuministro();
            this.formSoliSumin.TopLevel = false;
            this.formSoliSumin.Visible = true;
            this.Controls.Add(this.formSoliSumin);
            this.ArrangeFormSize(2);
            this.formGestionProd.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //gestorEmpleado = new UsuarioBL();
            //BindingList<Empleado> lista = new BindingList<Empleado>();
            //Thread hilo = new Thread(() => gestorEmpleado.obtenerEmpleadosConectados(lista));
            //gestorEmpleado.obtenerEmpleadosConectados(lista);
            gestorEmpleado = new UsuarioBL();
            BindingList<Empleado> lista = new BindingList<Empleado>();
            lista = gestorEmpleado.obtenerEmpleadosConectados();

            n = lista.Count();
            Console.WriteLine(n);

            txtBox = new TextBox[n];
            lbl = new Label[n];


            int space = 20;

            for (int i = 0; i < n; i++)
            {
                Empleado emp = lista[i];

                txtBox[i] = new TextBox();
                txtBox[i].Name = "n" + i;
                txtBox[i].Text = emp.NombreEmpleado;

                lbl[i] = new Label();
                lbl[i].ForeColor = System.Drawing.Color.Red;
                lbl[i].Name = "n" + (i+1);
                lbl[i].Text = "n" + (i+1);
            }


            for (int i = 0; i < n; i++)
            {
                txtBox[i].Visible = true;
                lbl[i].Visible = true;
                txtBox[i].Location = new Point(1090, yIni + space);
                txtBox[i].BringToFront();
                lbl[i].Location = new Point(1060, yIni + space);
                lbl[i].BringToFront();
                this.Controls.Add(txtBox[i]);
                this.Controls.Add(lbl[i]);
                space += 50;

            }

            this.panelChat.SendToBack();
        }
    }
}
