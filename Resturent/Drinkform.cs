using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturent
{
    public partial class Drinkform : Form
    {
        public Drinkform()
        {
            InitializeComponent();
        }

        private void Drinkform_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
