
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
    public partial class Food : Form
    {
        Formfood food;
        Desertform desert;
        Drinkform drink;
        Snaksform snaks;


        public Food()
        {
            InitializeComponent();
        }

        private void Food_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (snaks == null)
            {
                snaks = new Snaksform();
                snaks.FormClosed += Dashboard_FormClosed;
                snaks.MdiParent = this;
                snaks.Show();
            }
            else
            {
                snaks.Activate();
            }
        }
        private void sidebar_Tick(object sender, EventArgs e)
        {

        }

        private void btnnavi_Click(object sender, EventArgs e)
        {

        }


        private void btnfood_Click(object sender, EventArgs e)
        {
            if (food == null)
            {
                food = new Formfood();
                food.FormClosed += Dashboard_FormClosed;
                food.MdiParent = this;
                food.Show();
            }
            else
            {
                food.Activate();
            }
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            food = null;
            desert = null;
            drink = null;
            snaks = null;
        }

        private void btndesert_Click(object sender, EventArgs e)
        {
            if (desert == null)
            {
                desert = new Desertform();
                desert.FormClosed += Dashboard_FormClosed;
                desert.MdiParent = this;
                desert.Show();
            }
            else
            {
                desert.Activate();
            }
        }

        private void btndrink_Click(object sender, EventArgs e)
        {
            if (drink == null)
            {
                drink = new Drinkform();
                drink.FormClosed += Dashboard_FormClosed;
                drink.MdiParent = this;
                drink.Show();
            }
            else
            {
                drink.Activate();
            }
        }
    }
}
