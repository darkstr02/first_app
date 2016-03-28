using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoOT
{
    public partial class frmFiltrar : Form
    {
        public frmFiltrar()
        {
            InitializeComponent();
        }

        private void frmFiltrar_Load(object sender, EventArgs e)
        {
            //Llenar CheckBox ComboBoxes aquí!!
            checkBoxComboBox1.Items.Add("Item1");
            checkBoxComboBox1.Items.Add("Item2");
        }

        private void checkBoxComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
