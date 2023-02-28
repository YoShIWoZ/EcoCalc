using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco_Calc
{
    public partial class ucPrices : UserControl
    {
        public int usedFurnace;
        public ucPrices()
        {
            InitializeComponent();
        }

        private void Prices_Load(object sender, EventArgs e)
        {
            selectedSkill.SelectedIndex = 0;
            selectFurnace.SelectedIndex = 0;

            if (selectedSkill.SelectedIndex != 0)
                ucAdvancedBaking.Hide();
            if (selectedSkill.SelectedIndex != 1)
                ucAdvancedCampfireCooking.Hide();
            if (selectedSkill.SelectedIndex != 2)
                ucAdvancedCooking.Hide();
            if (selectedSkill.SelectedIndex != 3)
                ucAdvancedSmelting.Hide();
            if (selectedSkill.SelectedIndex != 7)
                ucButchery.Hide();
            if (selectedSkill.SelectedIndex != 9)
                ucCooking.Hide();
            if (selectedSkill.SelectedIndex != 16)
                ucHewing.Hide();
            if (selectedSkill.SelectedIndex != 22)
                ucMilling.Hide();
            if (selectedSkill.SelectedIndex != 28)
            {
                ucSmelting.Hide();
                selectFurnace.Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedSkill.SelectedIndex != 0)
                ucAdvancedBaking.Hide();
            else
                ucAdvancedBaking.Show();

            if (selectedSkill.SelectedIndex != 1)
                ucAdvancedCampfireCooking.Hide();
            else
                ucAdvancedCampfireCooking.Show();

            if (selectedSkill.SelectedIndex != 2)
                ucAdvancedCooking.Hide();
            else
                ucAdvancedCooking.Show();

            if (selectedSkill.SelectedIndex != 3)
                ucAdvancedSmelting.Hide();
            else
                ucAdvancedSmelting.Show();

            if (selectedSkill.SelectedIndex != 7)
                ucButchery.Hide();
            else
                ucButchery.Show();

            if (selectedSkill.SelectedIndex != 9)
                ucCooking.Hide();
            else
                ucCooking.Show();

            if (selectedSkill.SelectedIndex != 16)
                ucHewing.Hide();
            else
                ucHewing.Show();


            if (selectedSkill.SelectedIndex != 22)
                ucMilling.Hide();
            else
                ucMilling.Show();

            if (selectedSkill.SelectedIndex != 28)
            {
                ucSmelting.Hide();
                selectFurnace.Hide();
            }
            else
            {
                ucSmelting.Show();
                selectFurnace.Show();
            }
        }

        private void selectFurnace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectFurnace.SelectedIndex == 0)
            {
                usedFurnace = 0;
                (Parent as EcoPriceCalculator).CalculatePrices();
            }
            else if (selectFurnace.SelectedIndex == 1)
            {
                usedFurnace = 1;
                (Parent as EcoPriceCalculator).CalculatePrices();
            }
        }
    }
}
