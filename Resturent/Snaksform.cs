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
    public partial class Snaksform : Form
    {
        public Snaksform()
        {
            InitializeComponent();
        }

        private void Snaksform_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
