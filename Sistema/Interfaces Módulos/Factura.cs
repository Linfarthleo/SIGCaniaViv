using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace Sistema.Interfaces_Módulos
{
    public partial class Factura : Form
    {

        public string Date, Nombres, Identificacion, Direccion, IDFact, Telefono, Correo, Section, Estado;
        public string CantAlcohol, Medida, GradoAlcohol, PrecioUnitario, PrecioTotal;

        public Image img = null;
        public Factura()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("M/d/yyyy");

        }
        private void Print(Panel pnl) 
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void facturaNombre_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void facturaCant_Click(object sender, EventArgs e)
        {

        }

        private Bitmap memoryimg;
        
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));

        }
        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnPrint, "Imprimir factura");

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void btnPrint_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            facturaFecha.Text = Date;
            facturaNombre.Text = Nombres;
            facturaIdentificacion.Text = Identificacion;
            facturaCorreo.Text = Direccion;
            facturaIdFact.Text = IDFact;
            facturaTelefono.Text = Telefono;
            facturaCorreo.Text = Correo;       
            facturaForma.Text = Section;
            facturaCant.Text = CantAlcohol;
            facturaMedida.Text = Medida;
            facturaGrado.Text = GradoAlcohol;
            facturaPrecioUnitario.Text = PrecioUnitario;
            facturaPrecioTotal.Text = PrecioTotal;
            facturaTotal.Text = PrecioTotal;
            facturaEstado.Text = Estado;
        }

        private void panelPrint_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
