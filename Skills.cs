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
    public partial class ucSkills : UserControl
    {
        public decimal reducedAdvancedBaking;
        public decimal reducedAdvancedCampfireCooking;
        public decimal reducedHewing;
        public decimal reducedAdvancedCooking;
        public decimal reducedMilling;
        public decimal reducedButchery;
        public decimal reducedCooking;
        public decimal reducedAdvancedSmelting;
        public decimal reducedSmelting;

        public ucSkills()
        {
            InitializeComponent();
        }

        private void ucSkills_Load(object sender, EventArgs e)
        {
            valueAdvancedBaking.SelectedIndex = 0;
            valueAdvancedCampfireCooking.SelectedIndex = 0;
            valueAdvancedCooking.SelectedIndex = 0;
            valueAdvancedSmelting.SelectedIndex = 0;
            valueBaking.SelectedIndex = 0;
            valueBasicEngineering.SelectedIndex = 0;
            valueBricklaying.SelectedIndex = 0;
            valueButchery.SelectedIndex = 0;
            valueCement.SelectedIndex = 0;
            valueCooking.SelectedIndex = 0;
            valueCuttingEdgeCooking.SelectedIndex = 0;
            valueElectronics.SelectedIndex = 0;
            valueFarming.SelectedIndex = 0;
            valueFertilizers.SelectedIndex = 0;
            valueGathering.SelectedIndex = 0;
            valueGlassworking.SelectedIndex = 0;
            valueHewing.SelectedIndex = 0;
            valueHunting.SelectedIndex = 0;
            valueIndustry.SelectedIndex = 0;
            valueLogging.SelectedIndex = 0;
            valueLumber.SelectedIndex = 0;
            valueMechanics.SelectedIndex = 0;
            valueMilling.SelectedIndex = 0;
            valueMining.SelectedIndex = 0;
            valueMortaring.SelectedIndex = 0;
            valueOilDrilling.SelectedIndex = 0;
            valuePaperMilling.SelectedIndex = 0;
            valueSelfImprovement.SelectedIndex = 0;
            valueSmelting.SelectedIndex = 0;
            valueTailoring.SelectedIndex = 0;
        }

        private void valueAdvancedBaking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valueAdvancedBaking.SelectedIndex == 0)
                reducedAdvancedBaking = 1.0M;
            if (valueAdvancedBaking.SelectedIndex == 1)
                reducedAdvancedBaking = 0.50M;
            if (valueAdvancedBaking.SelectedIndex == 2)
                reducedAdvancedBaking = 0.45M;
            if (valueAdvancedBaking.SelectedIndex == 3)
                reducedAdvancedBaking = 0.40M;
            if (valueAdvancedBaking.SelectedIndex == 4)
                reducedAdvancedBaking = 0.35M;
            if (valueAdvancedBaking.SelectedIndex == 5)
                reducedAdvancedBaking = 0.30M;
            if (valueAdvancedBaking.SelectedIndex == 6)
                reducedAdvancedBaking = 0.25M;
            if (valueAdvancedBaking.SelectedIndex == 7)
                reducedAdvancedBaking = 0.20M;
        }

        private void valueAdvancedCooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valueAdvancedCooking.SelectedIndex == 0)
                reducedAdvancedCooking = 1.0M;
            if (valueAdvancedCooking.SelectedIndex == 1)
                reducedAdvancedCooking = 0.50M;
            if (valueAdvancedCooking.SelectedIndex == 2)
                reducedAdvancedCooking = 0.45M;
            if (valueAdvancedCooking.SelectedIndex == 3)
                reducedAdvancedCooking = 0.40M;
            if (valueAdvancedCooking.SelectedIndex == 4)
                reducedAdvancedCooking = 0.35M;
            if (valueAdvancedCooking.SelectedIndex == 5)
                reducedAdvancedCooking = 0.30M;
            if (valueAdvancedCooking.SelectedIndex == 6)
                reducedAdvancedCooking = 0.25M;
            if (valueAdvancedCooking.SelectedIndex == 7)
                reducedAdvancedCooking = 0.20M;
        }

        private void valueHewing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valueHewing.SelectedIndex == 0)
                reducedHewing = 1.0M;
            if (valueHewing.SelectedIndex == 1)
                reducedHewing = 0.50M;
            if (valueHewing.SelectedIndex == 2)
                reducedHewing = 0.45M;
            if (valueHewing.SelectedIndex == 3)
                reducedHewing = 0.40M;
            if (valueHewing.SelectedIndex == 4)
                reducedHewing = 0.35M;
            if (valueHewing.SelectedIndex == 5)
                reducedHewing = 0.30M;
            if (valueHewing.SelectedIndex == 6)
                reducedHewing = 0.25M;
            if (valueHewing.SelectedIndex == 7)
                reducedHewing = 0.20M;
        }
        private void valueMilling_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valueMilling.SelectedIndex == 0)
                reducedMilling = 1.0M;
            if (valueMilling.SelectedIndex == 1)
                reducedMilling = 0.50M;
            if (valueMilling.SelectedIndex == 2)
                reducedMilling = 0.45M;
            if (valueMilling.SelectedIndex == 3)
                reducedMilling = 0.40M;
            if (valueMilling.SelectedIndex == 4)
                reducedMilling = 0.35M;
            if (valueMilling.SelectedIndex == 5)
                reducedMilling = 0.30M;
            if (valueMilling.SelectedIndex == 6)
                reducedMilling = 0.25M;
            if (valueMilling.SelectedIndex == 7)
                reducedMilling = 0.20M;
        }

        private void valueButchery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valueButchery.SelectedIndex == 0)
                reducedButchery = 1.0M;
            if (valueButchery.SelectedIndex == 1)
                reducedButchery = 0.50M;
            if (valueButchery.SelectedIndex == 2)
                reducedButchery = 0.45M;
            if (valueButchery.SelectedIndex == 3)
                reducedButchery = 0.40M;
            if (valueButchery.SelectedIndex == 4)
                reducedButchery = 0.35M;
            if (valueButchery.SelectedIndex == 5)
                reducedButchery = 0.30M;
            if (valueButchery.SelectedIndex == 6)
                reducedButchery = 0.25M;
            if (valueButchery.SelectedIndex == 7)
                reducedButchery = 0.20M;
        }

        private void valueAdvancedCampfireCooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valueAdvancedCampfireCooking.SelectedIndex == 0)
                reducedAdvancedCampfireCooking = 1.0M;
            if (valueAdvancedCampfireCooking.SelectedIndex == 1)
                reducedAdvancedCampfireCooking = 0.50M;
            if (valueAdvancedCampfireCooking.SelectedIndex == 2)
                reducedAdvancedCampfireCooking = 0.45M;
            if (valueAdvancedCampfireCooking.SelectedIndex == 3)
                reducedAdvancedCampfireCooking = 0.40M;
            if (valueAdvancedCampfireCooking.SelectedIndex == 4)
                reducedAdvancedCampfireCooking = 0.35M;
            if (valueAdvancedCampfireCooking.SelectedIndex == 5)
                reducedAdvancedCampfireCooking = 0.30M;
            if (valueAdvancedCampfireCooking.SelectedIndex == 6)
                reducedAdvancedCampfireCooking = 0.25M;
            if (valueAdvancedCampfireCooking.SelectedIndex == 7)
                reducedAdvancedCampfireCooking = 0.20M;
        }

        private void valueCooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valueCooking.SelectedIndex == 0)
                reducedCooking = 1.0M;
            if (valueCooking.SelectedIndex == 1)
                reducedCooking = 0.50M;
            if (valueCooking.SelectedIndex == 2)
                reducedCooking = 0.45M;
            if (valueCooking.SelectedIndex == 3)
                reducedCooking = 0.40M;
            if (valueCooking.SelectedIndex == 4)
                reducedCooking = 0.35M;
            if (valueCooking.SelectedIndex == 5)
                reducedCooking = 0.30M;
            if (valueCooking.SelectedIndex == 6)
                reducedCooking = 0.25M;
            if (valueCooking.SelectedIndex == 7)
                reducedCooking = 0.20M;
        }

        private void valueAdvancedSmelting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valueAdvancedSmelting.SelectedIndex == 0)
                reducedAdvancedSmelting = 1.0M;
            if (valueAdvancedSmelting.SelectedIndex == 1)
                reducedAdvancedSmelting = 0.50M;
            if (valueAdvancedSmelting.SelectedIndex == 2)
                reducedAdvancedSmelting = 0.45M;
            if (valueAdvancedSmelting.SelectedIndex == 3)
                reducedAdvancedSmelting = 0.40M;
            if (valueAdvancedSmelting.SelectedIndex == 4)
                reducedAdvancedSmelting = 0.35M;
            if (valueAdvancedSmelting.SelectedIndex == 5)
                reducedAdvancedSmelting = 0.30M;
            if (valueAdvancedSmelting.SelectedIndex == 6)
                reducedAdvancedSmelting = 0.25M;
            if (valueAdvancedSmelting.SelectedIndex == 7)
                reducedAdvancedSmelting = 0.20M;
        }

        private void valueSmelting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valueSmelting.SelectedIndex == 0)
                reducedSmelting = 1.0M;
            if (valueSmelting.SelectedIndex == 1)
                reducedSmelting = 0.50M;
            if (valueSmelting.SelectedIndex == 2)
                reducedSmelting = 0.45M;
            if (valueSmelting.SelectedIndex == 3)
                reducedSmelting = 0.40M;
            if (valueSmelting.SelectedIndex == 4)
                reducedSmelting = 0.35M;
            if (valueSmelting.SelectedIndex == 5)
                reducedSmelting = 0.30M;
            if (valueSmelting.SelectedIndex == 6)
                reducedSmelting = 0.25M;
            if (valueSmelting.SelectedIndex == 7)
                reducedSmelting = 0.20M;
        }
    }
}
