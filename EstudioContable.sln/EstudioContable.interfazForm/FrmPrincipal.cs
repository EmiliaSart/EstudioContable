using EstudioContable.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudioContable.interfazForm
{
    public partial class FrmPrincipal : Form
    {
        private EstudioNegocio estudioNegocio;
        public FrmPrincipal()
        {
            InitializeComponent();

            estudioNegocio = new EstudioNegocio();
        }
    }
}
