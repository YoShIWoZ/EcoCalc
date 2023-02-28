namespace Eco_Calc
{
    partial class ucPrices
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxPrices = new System.Windows.Forms.GroupBox();
            this.selectFurnace = new System.Windows.Forms.ComboBox();
            this.ucAdvancedBaking = new Eco_Calc.ucAdvancedBaking();
            this.ucMilling = new Eco_Calc.ucMilling();
            this.selectedSkill = new System.Windows.Forms.ComboBox();
            this.ucAdvancedCooking = new Eco_Calc.ucAdvancedCooking();
            this.ucHewing = new Eco_Calc.ucHewing();
            this.ucButchery = new Eco_Calc.ucButchery();
            this.ucAdvancedCampfireCooking = new Eco_Calc.ucAdvancedCampfireCooking();
            this.ucCooking = new Eco_Calc.ucCooking();
            this.ucAdvancedSmelting = new Eco_Calc.ucAdvancedSmelting();
            this.ucSmelting = new Eco_Calc.ucSmelting();
            this.boxPrices.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxPrices
            // 
            this.boxPrices.Controls.Add(this.selectFurnace);
            this.boxPrices.Controls.Add(this.ucAdvancedBaking);
            this.boxPrices.Controls.Add(this.ucMilling);
            this.boxPrices.Controls.Add(this.selectedSkill);
            this.boxPrices.Controls.Add(this.ucAdvancedCooking);
            this.boxPrices.Controls.Add(this.ucHewing);
            this.boxPrices.Controls.Add(this.ucButchery);
            this.boxPrices.Controls.Add(this.ucAdvancedCampfireCooking);
            this.boxPrices.Controls.Add(this.ucCooking);
            this.boxPrices.Controls.Add(this.ucAdvancedSmelting);
            this.boxPrices.Controls.Add(this.ucSmelting);
            this.boxPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPrices.Location = new System.Drawing.Point(0, 0);
            this.boxPrices.Name = "boxPrices";
            this.boxPrices.Size = new System.Drawing.Size(776, 413);
            this.boxPrices.TabIndex = 9;
            this.boxPrices.TabStop = false;
            this.boxPrices.Text = "Prices";
            // 
            // selectFurnace
            // 
            this.selectFurnace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectFurnace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFurnace.FormattingEnabled = true;
            this.selectFurnace.Items.AddRange(new object[] {
            "Using Bloomery",
            "Using Blast Furnace"});
            this.selectFurnace.Location = new System.Drawing.Point(183, 25);
            this.selectFurnace.Name = "selectFurnace";
            this.selectFurnace.Size = new System.Drawing.Size(170, 21);
            this.selectFurnace.TabIndex = 18;
            this.selectFurnace.SelectedIndexChanged += new System.EventHandler(this.selectFurnace_SelectedIndexChanged);
            // 
            // ucAdvancedBaking
            // 
            this.ucAdvancedBaking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAdvancedBaking.Location = new System.Drawing.Point(6, 47);
            this.ucAdvancedBaking.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucAdvancedBaking.Name = "ucAdvancedBaking";
            this.ucAdvancedBaking.Size = new System.Drawing.Size(763, 360);
            this.ucAdvancedBaking.TabIndex = 12;
            // 
            // ucMilling
            // 
            this.ucMilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMilling.Location = new System.Drawing.Point(7, 47);
            this.ucMilling.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucMilling.Name = "ucMilling";
            this.ucMilling.Size = new System.Drawing.Size(762, 360);
            this.ucMilling.TabIndex = 11;
            // 
            // selectedSkill
            // 
            this.selectedSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedSkill.FormattingEnabled = true;
            this.selectedSkill.Items.AddRange(new object[] {
            "Advanced Baking",
            "Advanced Campfire Cooking",
            "Advanced Cooking",
            "Advanced Smelting",
            "Baking",
            "Basic Engineering",
            "Bricklaying",
            "Butchery",
            "Cement",
            "Cooking",
            "Cutting Edge Cooking",
            "Electronics",
            "Farming",
            "Fertilizers",
            "Gathering",
            "Glassworking",
            "Hewing",
            "Hunting",
            "Industry",
            "Logging",
            "Lumber",
            "Mechanics",
            "Milling",
            "Mining",
            "Mortaring",
            "Oil Drilling",
            "Paper Milling",
            "Self Improvement",
            "Smelting",
            "Tailoring"});
            this.selectedSkill.Location = new System.Drawing.Point(7, 25);
            this.selectedSkill.Name = "selectedSkill";
            this.selectedSkill.Size = new System.Drawing.Size(170, 21);
            this.selectedSkill.TabIndex = 8;
            this.selectedSkill.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ucAdvancedCooking
            // 
            this.ucAdvancedCooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAdvancedCooking.Location = new System.Drawing.Point(6, 47);
            this.ucAdvancedCooking.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucAdvancedCooking.Name = "ucAdvancedCooking";
            this.ucAdvancedCooking.Size = new System.Drawing.Size(763, 360);
            this.ucAdvancedCooking.TabIndex = 10;
            // 
            // ucHewing
            // 
            this.ucHewing.AutoSize = true;
            this.ucHewing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucHewing.Location = new System.Drawing.Point(6, 47);
            this.ucHewing.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucHewing.Name = "ucHewing";
            this.ucHewing.Size = new System.Drawing.Size(763, 360);
            this.ucHewing.TabIndex = 9;
            // 
            // ucButchery
            // 
            this.ucButchery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucButchery.Location = new System.Drawing.Point(6, 47);
            this.ucButchery.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucButchery.Name = "ucButchery";
            this.ucButchery.Size = new System.Drawing.Size(763, 360);
            this.ucButchery.TabIndex = 13;
            // 
            // ucAdvancedCampfireCooking
            // 
            this.ucAdvancedCampfireCooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAdvancedCampfireCooking.Location = new System.Drawing.Point(6, 47);
            this.ucAdvancedCampfireCooking.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucAdvancedCampfireCooking.Name = "ucAdvancedCampfireCooking";
            this.ucAdvancedCampfireCooking.Size = new System.Drawing.Size(763, 360);
            this.ucAdvancedCampfireCooking.TabIndex = 14;
            // 
            // ucCooking
            // 
            this.ucCooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCooking.Location = new System.Drawing.Point(6, 47);
            this.ucCooking.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucCooking.Name = "ucCooking";
            this.ucCooking.Size = new System.Drawing.Size(763, 360);
            this.ucCooking.TabIndex = 15;
            // 
            // ucAdvancedSmelting
            // 
            this.ucAdvancedSmelting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAdvancedSmelting.Location = new System.Drawing.Point(6, 47);
            this.ucAdvancedSmelting.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucAdvancedSmelting.Name = "ucAdvancedSmelting";
            this.ucAdvancedSmelting.Size = new System.Drawing.Size(763, 360);
            this.ucAdvancedSmelting.TabIndex = 16;
            // 
            // ucSmelting
            // 
            this.ucSmelting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSmelting.Location = new System.Drawing.Point(6, 47);
            this.ucSmelting.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ucSmelting.Name = "ucSmelting";
            this.ucSmelting.Size = new System.Drawing.Size(763, 360);
            this.ucSmelting.TabIndex = 17;
            // 
            // ucPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boxPrices);
            this.Name = "ucPrices";
            this.Size = new System.Drawing.Size(776, 413);
            this.Load += new System.EventHandler(this.Prices_Load);
            this.boxPrices.ResumeLayout(false);
            this.boxPrices.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxPrices;
        private System.Windows.Forms.ComboBox selectedSkill;
        public ucHewing ucHewing;
        public ucAdvancedCooking ucAdvancedCooking;
        public ucMilling ucMilling;
        public ucAdvancedBaking ucAdvancedBaking;
        public ucButchery ucButchery;
        public ucAdvancedCampfireCooking ucAdvancedCampfireCooking;
        public ucCooking ucCooking;
        public ucAdvancedSmelting ucAdvancedSmelting;
        public ucSmelting ucSmelting;
        public System.Windows.Forms.ComboBox selectFurnace;
    }
}
