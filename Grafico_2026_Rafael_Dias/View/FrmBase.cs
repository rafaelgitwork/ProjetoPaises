using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafico_2026_Rafael_Dias.View
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        public virtual void Sair()
        {
            Close();
        }

        public virtual void ConhecaObj(object obj, object ctrl)
        {

        }

        private void brnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }
    }
}
