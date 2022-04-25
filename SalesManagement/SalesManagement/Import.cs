using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }

        Mod modify = new Mod();
        private void Import_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
        }
    }
}
