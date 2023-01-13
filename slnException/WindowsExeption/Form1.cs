using slnException;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsExeption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico1 = new Medico("Valentino");
                MessageBox.Show($"Nombre del medico: {medico1.Nombre}");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEspacio_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico1 = new Medico("Valentino Martinez");
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCaracteres_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico1 = new Medico("");
                MessageBox.Show(medico1.Nombre);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
