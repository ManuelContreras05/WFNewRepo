using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <sumary>
/// Fecha: Marzo 2 de 2023 
/// Autor: Jose contreras 
/// Descripcion: Dibujar una linea con clase 
/// </sumary>>

namespace WFrectangulo
{
    public partial class Form1 : Form
    {
        public const double x1 = 0;
        public const double y1 = 0;
        public const double x2 = 0;
        public const double y2 = 0;
        Graphics grafica; 
        public Form1()
        {
            InitializeComponent();
            grafica = CreateGraphics();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnDibujo_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = int.Parse(txtX.Text);
                int y1 = int.Parse(txtY.Text);
                int x2 = int.Parse(txtX2.Text);
                int y2 = int.Parse(txtY2.Text);

                ClsLinea rec = new ClsLinea(x1, y1, x2, y2);
                Pen pen = new Pen(Brushes.Black);
                grafica.DrawLine(pen, rec.obtenX(), rec.cambiarY(), rec.cambiarX2(), rec.cambiarY2());

                pictureBox1.Invalidate();

                txtConteo.Text = Convert.ToString(ClsLinea.obtengCuenta());
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
