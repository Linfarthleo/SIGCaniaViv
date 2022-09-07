
namespace Sistema.Interfaces_Módulos
{
    partial class Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.panelPrint = new System.Windows.Forms.Panel();
            this.facturaForma = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.facturaFecha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.facturaTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.facturaIdFact = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.facturaIdentificacion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.facturaTelefono = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.facturaCorreo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.facturaNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.facturaCant = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.facturaMedida = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.facturaGrado = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.facturaPrecioUnitario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.facturaPrecioTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrint
            // 
            this.panelPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPrint.BackgroundImage")));
            this.panelPrint.Controls.Add(this.facturaPrecioTotal);
            this.panelPrint.Controls.Add(this.facturaPrecioUnitario);
            this.panelPrint.Controls.Add(this.facturaGrado);
            this.panelPrint.Controls.Add(this.facturaMedida);
            this.panelPrint.Controls.Add(this.facturaCant);
            this.panelPrint.Controls.Add(this.facturaForma);
            this.panelPrint.Controls.Add(this.facturaFecha);
            this.panelPrint.Controls.Add(this.facturaTotal);
            this.panelPrint.Controls.Add(this.facturaIdFact);
            this.panelPrint.Controls.Add(this.facturaIdentificacion);
            this.panelPrint.Controls.Add(this.facturaTelefono);
            this.panelPrint.Controls.Add(this.facturaCorreo);
            this.panelPrint.Controls.Add(this.facturaNombre);
            this.panelPrint.Location = new System.Drawing.Point(0, 56);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(672, 839);
            this.panelPrint.TabIndex = 0;
            this.panelPrint.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrint_Paint);
            // 
            // facturaForma
            // 
            this.facturaForma.BackColor = System.Drawing.Color.Transparent;
            this.facturaForma.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.facturaForma.Location = new System.Drawing.Point(145, 775);
            this.facturaForma.Name = "facturaForma";
            this.facturaForma.Size = new System.Drawing.Size(10, 21);
            this.facturaForma.TabIndex = 7;
            this.facturaForma.Text = "?";
            // 
            // facturaFecha
            // 
            this.facturaFecha.BackColor = System.Drawing.Color.Transparent;
            this.facturaFecha.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.facturaFecha.Location = new System.Drawing.Point(145, 23);
            this.facturaFecha.Name = "facturaFecha";
            this.facturaFecha.Size = new System.Drawing.Size(107, 21);
            this.facturaFecha.TabIndex = 6;
            this.facturaFecha.Text = "Kevin Sailema";
            // 
            // facturaTotal
            // 
            this.facturaTotal.BackColor = System.Drawing.Color.Transparent;
            this.facturaTotal.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.facturaTotal.Location = new System.Drawing.Point(493, 701);
            this.facturaTotal.Name = "facturaTotal";
            this.facturaTotal.Size = new System.Drawing.Size(107, 21);
            this.facturaTotal.TabIndex = 5;
            this.facturaTotal.Text = "Kevin Sailema";
            // 
            // facturaIdFact
            // 
            this.facturaIdFact.BackColor = System.Drawing.Color.Transparent;
            this.facturaIdFact.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.facturaIdFact.Location = new System.Drawing.Point(105, 23);
            this.facturaIdFact.Name = "facturaIdFact";
            this.facturaIdFact.Size = new System.Drawing.Size(10, 21);
            this.facturaIdFact.TabIndex = 4;
            this.facturaIdFact.Text = "?";
            // 
            // facturaIdentificacion
            // 
            this.facturaIdentificacion.BackColor = System.Drawing.Color.Transparent;
            this.facturaIdentificacion.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.facturaIdentificacion.Location = new System.Drawing.Point(422, 223);
            this.facturaIdentificacion.Name = "facturaIdentificacion";
            this.facturaIdentificacion.Size = new System.Drawing.Size(107, 21);
            this.facturaIdentificacion.TabIndex = 3;
            this.facturaIdentificacion.Text = "Kevin Sailema";
            // 
            // facturaTelefono
            // 
            this.facturaTelefono.BackColor = System.Drawing.Color.Transparent;
            this.facturaTelefono.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.facturaTelefono.Location = new System.Drawing.Point(288, 204);
            this.facturaTelefono.Name = "facturaTelefono";
            this.facturaTelefono.Size = new System.Drawing.Size(107, 21);
            this.facturaTelefono.TabIndex = 2;
            this.facturaTelefono.Text = "Kevin Sailema";
            // 
            // facturaCorreo
            // 
            this.facturaCorreo.BackColor = System.Drawing.Color.Transparent;
            this.facturaCorreo.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.facturaCorreo.Location = new System.Drawing.Point(301, 185);
            this.facturaCorreo.Name = "facturaCorreo";
            this.facturaCorreo.Size = new System.Drawing.Size(107, 21);
            this.facturaCorreo.TabIndex = 1;
            this.facturaCorreo.Text = "Kevin Sailema";
            // 
            // facturaNombre
            // 
            this.facturaNombre.BackColor = System.Drawing.Color.Transparent;
            this.facturaNombre.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.facturaNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.facturaNombre.Location = new System.Drawing.Point(288, 165);
            this.facturaNombre.Name = "facturaNombre";
            this.facturaNombre.Size = new System.Drawing.Size(107, 21);
            this.facturaNombre.TabIndex = 0;
            this.facturaNombre.Text = "Kevin Sailema";
            this.facturaNombre.Click += new System.EventHandler(this.facturaNombre_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.Transparent;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Image = global::Sistema.Properties.Resources.icons8_printer_48px;
            this.btnPrint.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPrint.Location = new System.Drawing.Point(481, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(180, 45);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Imprimir Nota de Venta";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // facturaCant
            // 
            this.facturaCant.BackColor = System.Drawing.Color.Transparent;
            this.facturaCant.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.facturaCant.Location = new System.Drawing.Point(77, 344);
            this.facturaCant.Name = "facturaCant";
            this.facturaCant.Size = new System.Drawing.Size(17, 21);
            this.facturaCant.TabIndex = 8;
            this.facturaCant.Text = "10";
            // 
            // facturaMedida
            // 
            this.facturaMedida.BackColor = System.Drawing.Color.Transparent;
            this.facturaMedida.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.facturaMedida.Location = new System.Drawing.Point(129, 344);
            this.facturaMedida.Name = "facturaMedida";
            this.facturaMedida.Size = new System.Drawing.Size(45, 21);
            this.facturaMedida.TabIndex = 9;
            this.facturaMedida.Text = "Litros";
            // 
            // facturaGrado
            // 
            this.facturaGrado.BackColor = System.Drawing.Color.Transparent;
            this.facturaGrado.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.facturaGrado.Location = new System.Drawing.Point(245, 344);
            this.facturaGrado.Name = "facturaGrado";
            this.facturaGrado.Size = new System.Drawing.Size(17, 21);
            this.facturaGrado.TabIndex = 10;
            this.facturaGrado.Text = "10";
            // 
            // facturaPrecioUnitario
            // 
            this.facturaPrecioUnitario.BackColor = System.Drawing.Color.Transparent;
            this.facturaPrecioUnitario.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.facturaPrecioUnitario.Location = new System.Drawing.Point(367, 344);
            this.facturaPrecioUnitario.Name = "facturaPrecioUnitario";
            this.facturaPrecioUnitario.Size = new System.Drawing.Size(17, 21);
            this.facturaPrecioUnitario.TabIndex = 11;
            this.facturaPrecioUnitario.Text = "10";
            this.facturaPrecioUnitario.Click += new System.EventHandler(this.guna2HtmlLabel4_Click);
            // 
            // facturaPrecioTotal
            // 
            this.facturaPrecioTotal.BackColor = System.Drawing.Color.Transparent;
            this.facturaPrecioTotal.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.facturaPrecioTotal.Location = new System.Drawing.Point(521, 344);
            this.facturaPrecioTotal.Name = "facturaPrecioTotal";
            this.facturaPrecioTotal.Size = new System.Drawing.Size(17, 21);
            this.facturaPrecioTotal.TabIndex = 12;
            this.facturaPrecioTotal.Text = "10";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 749);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panelPrint);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrint;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2HtmlLabel facturaTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel facturaIdFact;
        private Guna.UI2.WinForms.Guna2HtmlLabel facturaIdentificacion;
        private Guna.UI2.WinForms.Guna2HtmlLabel facturaTelefono;
        private Guna.UI2.WinForms.Guna2HtmlLabel facturaCorreo;
        private Guna.UI2.WinForms.Guna2HtmlLabel facturaNombre;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2HtmlLabel facturaFecha;
        private Guna.UI2.WinForms.Guna2HtmlLabel facturaForma;
        private Guna.UI2.WinForms.Guna2HtmlLabel facturaPrecioTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel facturaPrecioUnitario;
        private Guna.UI2.WinForms.Guna2HtmlLabel facturaGrado;
        private Guna.UI2.WinForms.Guna2HtmlLabel facturaMedida;
        private Guna.UI2.WinForms.Guna2HtmlLabel facturaCant;
    }
}