using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DsiCodeTech.SuPlazaPOS35.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            #region Posicionamiento dela pantalla en el centro
            this.CenterToScreen();
            #endregion
            InitializeComponent();
        }

        private void btnDispose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            #region Liberacion de la memoria
            System.GC.Collect();
            #endregion
        }

        #region variables globales del sistema 
        private static readonly NLog.Logger logger = LogManager.GetCurrentClassLogger();
        #endregion

        #region Evento del Boton Login
        private void btnAuth_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                logger.Error($"Ocurrio un error en el sistema: {ex}");
                logger.Error($"El modulo que genero el error: {this.Name}");
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        #endregion
    }
}
