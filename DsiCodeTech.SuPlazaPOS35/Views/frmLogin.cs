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
    }
}
