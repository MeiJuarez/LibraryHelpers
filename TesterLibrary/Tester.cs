using LibraryHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesterLibrary
{
    public partial class frmTester : Form
    {
        #region Constantes
        readonly string respuesta = "Eligue una respuesta";
        readonly string si = "SI";
        readonly string no = "No";
        #endregion
        public frmTester()
        {
            InitializeComponent();
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !ControlsHelper.SoloNumeros(e.KeyChar);
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError(ex.Message);
            }
        }

        private void btnPregunta_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxHelper.ShowQuestionYesNo(respuesta) == DialogResult.Yes)
                {
                    //si es verdadero 
                    txtRespuesta.Text = si;
                }
                else
                {
                    txtRespuesta.Text = no;
                }
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError(ex.Message);
            }
        }
    }
}
