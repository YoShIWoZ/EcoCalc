namespace Eco_Calc
{
    partial class EcoPriceCalculator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcoPriceCalculator));
            this.buttonPrices = new System.Windows.Forms.Button();
            this.buttonSkills = new System.Windows.Forms.Button();
            this.buttonValues = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bonusMarkup = new System.Windows.Forms.NumericUpDown();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ucPrices = new Eco_Calc.ucPrices();
            this.ucSkills = new Eco_Calc.ucSkills();
            this.ucValues = new Eco_Calc.ucValues();
            ((System.ComponentModel.ISupportInitialize)(this.bonusMarkup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrices
            // 
            this.buttonPrices.Location = new System.Drawing.Point(12, 12);
            this.buttonPrices.Name = "buttonPrices";
            this.buttonPrices.Size = new System.Drawing.Size(75, 23);
            this.buttonPrices.TabIndex = 1;
            this.buttonPrices.Text = "Prices";
            this.buttonPrices.UseVisualStyleBackColor = true;
            this.buttonPrices.Click += new System.EventHandler(this.buttonPrices_Click);
            // 
            // buttonSkills
            // 
            this.buttonSkills.Location = new System.Drawing.Point(94, 12);
            this.buttonSkills.Name = "buttonSkills";
            this.buttonSkills.Size = new System.Drawing.Size(75, 23);
            this.buttonSkills.TabIndex = 2;
            this.buttonSkills.Text = "Skills";
            this.buttonSkills.UseVisualStyleBackColor = true;
            this.buttonSkills.Click += new System.EventHandler(this.buttonSkills_Click);
            // 
            // buttonValues
            // 
            this.buttonValues.Location = new System.Drawing.Point(176, 11);
            this.buttonValues.Name = "buttonValues";
            this.buttonValues.Size = new System.Drawing.Size(75, 23);
            this.buttonValues.TabIndex = 3;
            this.buttonValues.Text = "Values";
            this.buttonValues.UseVisualStyleBackColor = true;
            this.buttonValues.Click += new System.EventHandler(this.buttonValues_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(681, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Markup";
            // 
            // bonusMarkup
            // 
            this.bonusMarkup.DecimalPlaces = 2;
            this.bonusMarkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusMarkup.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.bonusMarkup.Location = new System.Drawing.Point(736, 15);
            this.bonusMarkup.Name = "bonusMarkup";
            this.bonusMarkup.Size = new System.Drawing.Size(47, 20);
            this.bonusMarkup.TabIndex = 12;
            this.bonusMarkup.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            this.bonusMarkup.ValueChanged += new System.EventHandler(this.bonusMarkup_ValueChanged);
            // 
            // ucPrices
            // 
            this.ucPrices.Location = new System.Drawing.Point(12, 41);
            this.ucPrices.Name = "ucPrices";
            this.ucPrices.Size = new System.Drawing.Size(776, 413);
            this.ucPrices.TabIndex = 6;
            // 
            // ucSkills
            // 
            this.ucSkills.Location = new System.Drawing.Point(12, 41);
            this.ucSkills.Name = "ucSkills";
            this.ucSkills.Size = new System.Drawing.Size(776, 413);
            this.ucSkills.TabIndex = 4;
            // 
            // ucValues
            // 
            this.ucValues.Location = new System.Drawing.Point(12, 41);
            this.ucValues.Name = "ucValues";
            this.ucValues.Size = new System.Drawing.Size(776, 413);
            this.ucValues.TabIndex = 5;
            // 
            // EcoPriceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bonusMarkup);
            this.Controls.Add(this.ucPrices);
            this.Controls.Add(this.ucSkills);
            this.Controls.Add(this.buttonValues);
            this.Controls.Add(this.buttonSkills);
            this.Controls.Add(this.buttonPrices);
            this.Controls.Add(this.ucValues);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 498);
            this.MinimumSize = new System.Drawing.Size(810, 498);
            this.Name = "EcoPriceCalculator";
            this.Text = "Eco Price Calculator";
            this.Load += new System.EventHandler(this.EcoPriceCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bonusMarkup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonPrices;
        private System.Windows.Forms.Button buttonSkills;
        private System.Windows.Forms.Button buttonValues;
        private ucSkills ucSkills;
        private ucValues ucValues;
        private ucPrices ucPrices;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown bonusMarkup;
    }
}

