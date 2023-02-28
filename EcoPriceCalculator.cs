using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco_Calc
{
    public partial class EcoPriceCalculator : Form
    {
        public EcoPriceCalculator()
        {
            InitializeComponent();
        }
        private decimal Price(TextBox item ,bool bonus, decimal skill, decimal value1, decimal factor1, decimal value2 = 0M, decimal factor2 = 0M, decimal value3 = 0M, decimal factor3 = 0M, decimal value4 = 0M, decimal factor4 = 0M, decimal value5 = 0M, decimal factor5 = 0M)
        {
            if (bonus)
            {
                item.Text = PriceMarkup((factor1 * value1 + factor2 * value2 + factor3 * value3 + factor4 * value4 + factor5 * value5) * skill * 0.9M);
                return (factor1 * value1 + factor2 * value2 + factor3 * value3 + factor4 * value4 + factor5 * value5) * skill * 0.9M;
            }
            else
            {
                item.Text = PriceMarkup((factor1 * value1 + factor2 * value2 + factor3 * value3 + factor4 * value4 + factor5 * value5) * skill);
                return (factor1 * value1 + factor2 * value2 + factor3 * value3 + factor4 * value4 + factor5 * value5) * skill;
            }

        }
        private string PriceMarkup(decimal item)
        {
            return (item * bonusMarkup.Value).ToString("F");
        }
        public void CalculatePrices()
        {
            bool bonusHewing = ucSkills.bonusHewing.Checked;
            decimal reducedHewing = ucSkills.reducedHewing;
            bool bonusMilling = ucSkills.bonusMilling.Checked;
            decimal reducedMilling = ucSkills.reducedMilling;
            bool bonusAdvancedCooking = ucSkills.bonusAdvancedCooking.Checked;
            decimal reducedAdvancedCooking = ucSkills.reducedAdvancedCooking;
            bool bonusAdvancedBaking = ucSkills.bonusAdvancedBaking.Checked;
            decimal reducedAdvancedBaking = ucSkills.reducedAdvancedBaking;
            bool bonusButchery = ucSkills.bonusButchery.Checked;
            decimal reducedButchery = ucSkills.reducedButchery;
            bool bonusAdvancedCampfireCooking = ucSkills.bonusAdvancedCampfireCooking.Checked;
            decimal reducedCampfireCooking = ucSkills.reducedAdvancedCampfireCooking;
            bool bonusCooking = ucSkills.bonusCooking.Checked;
            decimal reducedCooking = ucSkills.reducedCooking;
            bool bonusAdvancedSmelting = ucSkills.bonusAdvancedSmelting.Checked;
            decimal reducedAdvancedSmelting = ucSkills.reducedAdvancedSmelting;
            bool bonusSmelting = ucSkills.bonusSmelting.Checked;
            decimal reducedSmelting = ucSkills.reducedSmelting;

            //Base Material
            decimal valueLog = ucValues.valueLog.Value;
            decimal valueStone = ucValues.valueStone.Value;
            decimal valuePlantFibers = ucValues.valuePlantFibers.Value;
            decimal valueIronOre = ucValues.valueIronOre.Value;

            decimal valueBeet = ucValues.valueBeet.Value;
            decimal valueWheat = ucValues.valueWheat.Value;
            decimal valueCamasBulb = ucValues.valueCamasBulb.Value;
            decimal valueCorn = ucValues.valueCorn.Value;
            decimal valueHuckleberries = ucValues.valueHuckleberries.Value;
            decimal valueBeans = ucValues.valueBeans.Value;
            decimal valueAcorn = ucValues.valueAcorn.Value;
            decimal valueRice = ucValues.valueRice.Value;
            decimal valuePineapple = ucValues.valuePineapple.Value;
            decimal valueFiddleheads = ucValues.valueFiddleheads.Value;
            decimal valueTomato = ucValues.valueTomato.Value;
            decimal valuePricklyPearFruit = ucValues.valuePricklyPearFruit.Value;
            decimal valueCriminiMushrooms = ucValues.valueCriminiMushrooms.Value;
            decimal valuePumpkin = ucValues.valuePumpkin.Value;

            decimal valueBighornCarcass = ucValues.valueBighornCarcass.Value;
            decimal valueHareCarcass = ucValues.valueHareCarcass.Value;
            decimal valueMountainGoatCarcass = ucValues.valueMountainGoatCarcass.Value;
            decimal valueOtterCarcass = ucValues.valueOtterCarcass.Value;
            decimal valueTurkeyCarcass = ucValues.valueTurkeyCarcass.Value;
            decimal valueFoxCarcass = ucValues.valueFoxCarcass.Value;
            decimal valueDeerCarcass = ucValues.valueDeerCarcass.Value;
            decimal valueElkCarcass = ucValues.valueElkCarcass.Value;
            decimal valueBisonCarcass = ucValues.valueBisonCarcass.Value;
            decimal valueWolfCarcass = ucValues.valueWolfCarcass.Value;

            //Hewing
            decimal valueHewnLog = Price(ucPrices.ucHewing.valueHewnLog, bonusHewing, reducedHewing, valueLog, 2);
            decimal valueBoard = Price(ucPrices.ucHewing.valueBoard, bonusHewing, reducedHewing, valueLog, 6 / 2);
            Price(ucPrices.ucHewing.valueButcheryTable, bonusHewing, reducedHewing, valueBoard, 40, valueLog, 40);
            Price(ucPrices.ucHewing.valueCarpentryTable, bonusHewing, reducedHewing, valueLog, 30, valueStone, 30);
            Price(ucPrices.ucHewing.valueContractBoard, bonusHewing, reducedHewing, valueHewnLog, 40, valueBoard, 20);
            Price(ucPrices.ucHewing.valueDistributionStation, bonusHewing, reducedHewing, valueHewnLog, 30);
            Price(ucPrices.ucHewing.valueDoor, bonusHewing, reducedHewing, valueLog, 12);
            Price(ucPrices.ucHewing.valueFishTrap, bonusHewing, reducedHewing, valueHewnLog, 30);
            Price(ucPrices.ucHewing.valueFishery, bonusHewing, reducedHewing, valueLog, 30);
            Price(ucPrices.ucHewing.valueRealEstateDesk, bonusHewing, reducedHewing, valueHewnLog, 30, valueBoard, 30, valuePlantFibers, 50);
            Price(ucPrices.ucHewing.valueSmallHangingHewnLogSign, bonusHewing, reducedHewing, valueBoard, 10, valueHewnLog, 8);
            Price(ucPrices.ucHewing.valueSmallStandingHewnLogSign, bonusHewing, reducedHewing, valueBoard, 10, valueHewnLog, 8);
            Price(ucPrices.ucHewing.valueTable, bonusHewing, reducedHewing, valueHewnLog, 40, valueBoard, 50);
            Price(ucPrices.ucHewing.valueTailoringTable, bonusHewing, reducedHewing, valueBoard, 50, valuePlantFibers, 60);
            Price(ucPrices.ucHewing.valueWainwrightTable, bonusHewing, reducedHewing, valueBoard, 60, valueHewnLog, 60);
            Price(ucPrices.ucHewing.valueHewnLogDoor, bonusHewing, reducedHewing, valueHewnLog, 12);
            Price(ucPrices.ucHewing.valueSmallWoodCart, bonusHewing, reducedHewing, valueHewnLog, 10, valueBoard, 15);
            Price(ucPrices.ucHewing.valueWheelbarrow, bonusHewing, reducedHewing, valueHewnLog, 10, valueBoard, 15);
            Price(ucPrices.ucHewing.valueWoodenStrawBed, bonusHewing, reducedHewing, valueHewnLog, 35, valueBoard, 30, valuePlantFibers, 40);
            Price(ucPrices.ucHewing.valueChair, bonusHewing, reducedHewing, valueHewnLog, 30, valueBoard, 30, valuePlantFibers, 30);
            Price(ucPrices.ucHewing.valueWoodenLatrine, bonusHewing, reducedHewing, valueHewnLog, 30, valueBoard, 40);
            Price(ucPrices.ucHewing.valueSmallTable, bonusHewing, reducedHewing, valueHewnLog, 20, valueBoard, 30);
            Price(ucPrices.ucHewing.valueLargeStandingHewnLogSign, bonusHewing, reducedHewing, valueBoard, 10, valueHewnLog, 20);
            Price(ucPrices.ucHewing.valueIcebox, bonusHewing, reducedHewing, valueHewnLog, 30, valueBoard, 20);
            Price(ucPrices.ucHewing.valueLargeHangingHewnLogSign, bonusHewing, reducedHewing, valueBoard, 10, valueHewnLog, 20);

            //Milling
            decimal valueSugarBeet = Price(ucPrices.ucMilling.valueSugarBeet, bonusMilling, reducedMilling, valueBeet, 15M / 3M);
            decimal valueCamasPaste = Price(ucPrices.ucMilling.valueCamasPaste, bonusMilling, reducedMilling, valueCamasBulb, 10);
            decimal valueFlour = Price(ucPrices.ucMilling.valueFlour, bonusMilling, reducedMilling, valueWheat, 20);
            decimal valueCornmeal = Price(ucPrices.ucMilling.valueCornmeal, bonusMilling, reducedMilling, valueCorn, 10);
            decimal valueCerealGermCorn = Price(ucPrices.ucMilling.valueCerealGermCorn, bonusMilling, reducedMilling, valueCorn, 10M / 2M);
            decimal valueCerealGermWheat = Price(ucPrices.ucMilling.valueCerealGermWheat, bonusMilling, reducedMilling, valueWheat, 20);
            decimal valueOil = Price(ucPrices.ucMilling.valueOil, bonusMilling, reducedMilling, valueCerealGermCorn, 30);
            decimal valueSugarHuckleberries = Price(ucPrices.ucMilling.valueSugarHuckleberries, bonusMilling, reducedMilling, valueHuckleberries, 20);
            decimal valueBeanPaste = Price(ucPrices.ucMilling.valueBeanPaste, bonusMilling, reducedMilling, valueBeans, 15);
            decimal valueAcornPowder = Price(ucPrices.ucMilling.valueAcornPowder, bonusMilling, reducedMilling, valueAcorn, 10);

            //Butchery
            decimal valueRawMeatBighorn = Price(ucPrices.ucButchery.valueRawMeatBighorn, bonusButchery, reducedButchery, valueBighornCarcass, 1M / 6M);
            decimal valueRawMeatHare = Price(ucPrices.ucButchery.valuelRawMeatHare, bonusButchery, reducedButchery, valueHareCarcass, 1);
            decimal valueScrapMeat = Price(ucPrices.ucButchery.valueScrapMeat, bonusButchery, reducedButchery, valueRawMeatHare, 20M / 5M);
            decimal valuePrimeCut = Price(ucPrices.ucButchery.valuePrimeCut, bonusButchery, reducedButchery, valueRawMeatHare, 40);
            decimal valueRawSausage = Price(ucPrices.ucButchery.valueRawSausage, bonusButchery, reducedButchery, valueScrapMeat, 20);
            decimal valueRawRoast = Price(ucPrices.ucButchery.valueRawRoast, bonusButchery, reducedButchery, valueRawMeatHare, 20);
            decimal valuePreparedMeat = Price(ucPrices.ucButchery.valuePreparedMeat, bonusButchery, reducedButchery, valueRawMeatHare, 10);

            //Advanced Campfire Cooking
            decimal valueRenderFat = Price(ucPrices.ucAdvancedCampfireCooking.valueRenderFat, bonusAdvancedCampfireCooking, reducedCampfireCooking, valueRawMeatHare, 6M / 2M);
            decimal valueBannock = Price(ucPrices.ucAdvancedCampfireCooking.valueBannock, bonusAdvancedCampfireCooking, reducedCampfireCooking, valueWheat, 30, valueRenderFat, 3);
            Price(ucPrices.ucAdvancedCampfireCooking.valueCharredSausage, bonusAdvancedCampfireCooking, reducedCampfireCooking, valueRawSausage, 4);
            Price(ucPrices.ucAdvancedCampfireCooking.valueFiddleheadSalad, bonusAdvancedCampfireCooking, reducedCampfireCooking, valueFiddleheads, 20, valueBeet, 5, valueHuckleberries, 20, valueTomato, 5);
            Price(ucPrices.ucAdvancedCampfireCooking.valueFriedTomatoes, bonusAdvancedCampfireCooking, reducedCampfireCooking, valueTomato, 8, valueRenderFat, 5);
            decimal valueWheatPorridge = Price(ucPrices.ucAdvancedCampfireCooking.valueWheatPorridge, bonusAdvancedCampfireCooking, reducedCampfireCooking, valueWheat, 15, valueHuckleberries, 20);
            decimal valueCampfireRoast = Price(ucPrices.ucAdvancedCampfireCooking.valueCampfireRoast, bonusAdvancedCampfireCooking, reducedCampfireCooking, valueRawRoast, 3);
            Price(ucPrices.ucAdvancedCampfireCooking.valueCampfireStew, bonusAdvancedCampfireCooking, reducedCampfireCooking, valueScrapMeat, 30, valueCamasBulb, 10, valueCorn, 10, valueRenderFat, 3);
            Price(ucPrices.ucAdvancedCampfireCooking.valueWildStew, bonusAdvancedCampfireCooking, reducedCampfireCooking, valueHuckleberries, 30, valueBeet, 10, valueBeans * 4M, 10);

            //Cooking
            decimal valueBasicSaldPMR = Price(ucPrices.ucCooking.valueBasicSaladPMR, bonusCooking, reducedCooking, valuePricklyPearFruit, 10, valueCriminiMushrooms, 10, valueRice, 20);
            decimal valueMeatStock = Price(ucPrices.ucCooking.valueMeatStock, bonusCooking, reducedCooking, valueScrapMeat, 20);
            decimal valueVegetableMedley = Price(ucPrices.ucCooking.valueVegetableMedleyCC, bonusCooking, reducedCooking, valueCorn, 15, valueCamasBulb, 15);
            decimal valueFruitSaladPP = Price(ucPrices.ucCooking.valueFruitSaladPP, bonusCooking, reducedCooking, valuePricklyPearFruit, 15, valuePumpkin, 10);

            //Advanced Cooking
            decimal valueYeast = Price(ucPrices.ucAdvancedCooking.valueYeast, bonusAdvancedCooking, reducedAdvancedCooking, valueSugarBeet, 10);
            decimal valueRefineTallow = Price(ucPrices.ucAdvancedCooking.valueRefineTallow, bonusAdvancedCooking, reducedAdvancedCooking, valueRenderFat, 18);
            decimal valueBoiledRice = Price(ucPrices.ucAdvancedCooking.valueBoiledRice, bonusAdvancedCooking, reducedAdvancedCooking, valueRice, 20);
            Price(ucPrices.ucAdvancedCooking.valueCornFritters, bonusAdvancedCooking, reducedAdvancedCooking, valueCornmeal, 15, valueCorn, 10, valueOil, 10);
            decimal valueHuckleberryExtract = Price(ucPrices.ucAdvancedCooking.valueHuckleberryExtract, bonusAdvancedCooking, reducedAdvancedCooking, valueHuckleberries, 50);
            decimal valueInfusedOil = Price(ucPrices.ucAdvancedCooking.valueInfusedOil, bonusAdvancedCooking, reducedAdvancedCooking, valueOil, 4, valueHuckleberryExtract, 4);
            Price(ucPrices.ucAdvancedCooking.valuePineappleFriendRice, bonusAdvancedCooking, reducedAdvancedCooking, valuePineapple, 10, valueBoiledRice, 10, valueScrapMeat, 20);
            Price(ucPrices.ucAdvancedCooking.valueSearedMeat, bonusAdvancedCooking, reducedAdvancedCooking, valuePrimeCut, 5, valueInfusedOil, 4);
            decimal valueSimpleSyrup = Price(ucPrices.ucAdvancedCooking.valueSimpleSyrup, bonusAdvancedCooking, reducedAdvancedCooking, valueSugarBeet, 20);
            decimal valueTortilla = Price(ucPrices.ucAdvancedCooking.valueTortilla, bonusAdvancedCooking, reducedAdvancedCooking, valueCornmeal, 5);
            decimal valueWildMix = Price(ucPrices.ucAdvancedCooking.valueWildMix, bonusAdvancedCooking, reducedAdvancedCooking, valueBasicSaldPMR, 4, valueHuckleberryExtract, 4);
            Price(ucPrices.ucAdvancedCooking.valueBoiledSausage, bonusAdvancedCooking, reducedAdvancedCooking, valueRawSausage, 10, valueMeatStock, 10);
            Price(ucPrices.ucAdvancedCooking.valueElkTaco, bonusAdvancedCooking, reducedAdvancedCooking, valueScrapMeat, 30, valueTortilla, 5, valueWildMix, 5);
            Price(ucPrices.ucAdvancedCooking.valueFriedHareHaunches, bonusAdvancedCooking, reducedAdvancedCooking, valuePreparedMeat, 10, valueFlour, 20, valueOil, 10);
            Price(ucPrices.ucAdvancedCooking.valueBearSUPREME, bonusAdvancedCooking, reducedAdvancedCooking, valuePrimeCut, 10, valueVegetableMedley, 5, valueMeatStock, 5, valueInfusedOil, 5);
            Price(ucPrices.ucAdvancedCooking.valueCrimsonSalad, bonusAdvancedCooking, reducedAdvancedCooking, valueBasicSaldPMR, 4, valueInfusedOil, 5, valueBeet, 10, valueTomato, 10);
            Price(ucPrices.ucAdvancedCooking.valueSweetSalad, bonusAdvancedCooking, reducedAdvancedCooking, valueBasicSaldPMR, 4, valueFruitSaladPP, 4, valueSimpleSyrup, 10);


            //Advanced Baking
            Price(ucPrices.ucAdvancedBaking.valueBearclaw, bonusAdvancedBaking, reducedAdvancedBaking, valueFlour, 8, valueSugarBeet, 8, valueYeast, 3);
            Price(ucPrices.ucAdvancedBaking.valueBread, bonusAdvancedBaking, reducedAdvancedBaking, valueFlour, 6, valueYeast, 3);
            Price(ucPrices.ucAdvancedBaking.valueCamasBread, bonusAdvancedBaking, reducedAdvancedBaking, valueFlour, 10, valueCamasPaste, 5, valueYeast, 3);
            Price(ucPrices.ucAdvancedBaking.valueMacaroons, bonusAdvancedBaking, reducedAdvancedBaking, valueFlour, 10, valueSimpleSyrup, 5, valueHuckleberryExtract, 10);
            Price(ucPrices.ucAdvancedBaking.valueElkWellington, bonusAdvancedBaking, reducedAdvancedBaking, valueFlour, 20, valueYeast, 5, valuePrimeCut, 5);

            //Smelting
            decimal valueIronBarBloom = Price(ucPrices.ucSmelting.valueIronBarBloom, bonusSmelting, reducedSmelting, valueIronOre, 20);
            decimal valueIronBarBlast = Price(ucPrices.ucSmelting.valueIronBarBlast, bonusSmelting, reducedSmelting, valueIronOre, 10);
            if (ucPrices.usedFurnace == 0)
                Price(ucPrices.ucSmelting.valueAnvil, bonusSmelting, reducedSmelting, valueIronBarBloom, 30);
            else if (ucPrices.usedFurnace == 1)
                Price(ucPrices.ucSmelting.valueAnvil, bonusSmelting, reducedSmelting, valueIronBarBlast, 30);
        }


        private void buttonValues_Click(object sender, EventArgs e)
        {
            ucSkills.Hide();
            ucPrices.Hide();
            ucValues.Show();
            ucValues.BringToFront();
        }

        private void buttonSkills_Click(object sender, EventArgs e)
        {
            ucValues.Hide();
            ucPrices.Hide();
            ucSkills.Show();
            ucSkills.BringToFront();
        }

        private void buttonPrices_Click(object sender, EventArgs e)
        {
            CalculatePrices();
            ucValues.Hide();
            ucSkills.Hide();
            ucPrices.Show();
            ucPrices.BringToFront();
        }

        private void EcoPriceCalculator_Load(object sender, EventArgs e)
        {
            CalculatePrices();
        }

        private void bonusMarkup_ValueChanged(object sender, EventArgs e)
        {
            CalculatePrices();
        }
    }
}
