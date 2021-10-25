
namespace CS315_Project_2
{
    partial class Converter
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
            this.inputTextFrom = new System.Windows.Forms.TextBox();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelCalculation = new System.Windows.Forms.Label();
            this.textBoxCalculation = new System.Windows.Forms.RichTextBox();
            this.checkBoxDecimal = new System.Windows.Forms.CheckBox();
            this.inputTextTo = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.labelInputFrom = new System.Windows.Forms.Label();
            this.labelInputTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextFrom
            // 
            this.inputTextFrom.Location = new System.Drawing.Point(116, 137);
            this.inputTextFrom.Name = "inputTextFrom";
            this.inputTextFrom.Size = new System.Drawing.Size(100, 20);
            this.inputTextFrom.TabIndex = 0;
            this.inputTextFrom.TextChanged += new System.EventHandler(this.inputTextFrom_TextChanged);
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "Inch (in)",
            "Centimeter (cm)",
            "Foot (ft)",
            "Yard (yd)",
            "Mile (mi)",
            "Kilometer (km)",
            "Liter",
            "Gallon"});
            this.comboBoxFrom.Location = new System.Drawing.Point(116, 89);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFrom.TabIndex = 1;
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrom_SelectedIndexChanged);
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "Inch (in)",
            "Centimeter (cm)",
            "Foot (ft)",
            "Yard (yd)",
            "Mile (mi)",
            "Kilometer (km)",
            "Liter",
            "Gallon"});
            this.comboBoxTo.Location = new System.Drawing.Point(291, 89);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTo.TabIndex = 2;
            this.comboBoxTo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTo_SelectedIndexChanged);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelFrom.Location = new System.Drawing.Point(113, 50);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(44, 17);
            this.labelFrom.TabIndex = 3;
            this.labelFrom.Text = "From";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelTo.Location = new System.Drawing.Point(288, 50);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(27, 17);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "To";
            // 
            // labelCalculation
            // 
            this.labelCalculation.AutoSize = true;
            this.labelCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalculation.Location = new System.Drawing.Point(12, 330);
            this.labelCalculation.Name = "labelCalculation";
            this.labelCalculation.Size = new System.Drawing.Size(85, 16);
            this.labelCalculation.TabIndex = 5;
            this.labelCalculation.Text = "Calculation";
            // 
            // textBoxCalculation
            // 
            this.textBoxCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCalculation.Location = new System.Drawing.Point(116, 304);
            this.textBoxCalculation.Name = "textBoxCalculation";
            this.textBoxCalculation.Size = new System.Drawing.Size(302, 61);
            this.textBoxCalculation.TabIndex = 6;
            this.textBoxCalculation.Text = "This is a calculation\nlskdfj\nAnother calculation";
            // 
            // checkBoxDecimal
            // 
            this.checkBoxDecimal.AutoSize = true;
            this.checkBoxDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDecimal.Location = new System.Drawing.Point(267, 253);
            this.checkBoxDecimal.Name = "checkBoxDecimal";
            this.checkBoxDecimal.Size = new System.Drawing.Size(145, 20);
            this.checkBoxDecimal.TabIndex = 7;
            this.checkBoxDecimal.Text = "2 decimal places";
            this.checkBoxDecimal.UseVisualStyleBackColor = true;
            // 
            // inputTextTo
            // 
            this.inputTextTo.Location = new System.Drawing.Point(116, 253);
            this.inputTextTo.Name = "inputTextTo";
            this.inputTextTo.Size = new System.Drawing.Size(100, 20);
            this.inputTextTo.TabIndex = 8;
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.Green;
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonConvert.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonConvert.Location = new System.Drawing.Point(116, 187);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(90, 35);
            this.buttonConvert.TabIndex = 9;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(224, 187);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(90, 35);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSwap
            // 
            this.buttonSwap.BackColor = System.Drawing.Color.Black;
            this.buttonSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSwap.ForeColor = System.Drawing.Color.White;
            this.buttonSwap.Location = new System.Drawing.Point(328, 187);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(90, 35);
            this.buttonSwap.TabIndex = 11;
            this.buttonSwap.Text = "Swap";
            this.buttonSwap.UseVisualStyleBackColor = false;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // labelInputFrom
            // 
            this.labelInputFrom.AutoSize = true;
            this.labelInputFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputFrom.Location = new System.Drawing.Point(12, 141);
            this.labelInputFrom.Name = "labelInputFrom";
            this.labelInputFrom.Size = new System.Drawing.Size(69, 16);
            this.labelInputFrom.TabIndex = 12;
            this.labelInputFrom.Text = "Inches....";
            // 
            // labelInputTo
            // 
            this.labelInputTo.AutoSize = true;
            this.labelInputTo.Enabled = false;
            this.labelInputTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputTo.Location = new System.Drawing.Point(12, 257);
            this.labelInputTo.Name = "labelInputTo";
            this.labelInputTo.Size = new System.Drawing.Size(102, 16);
            this.labelInputTo.TabIndex = 13;
            this.labelInputTo.Text = "Centimeters...";
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.labelInputTo);
            this.Controls.Add(this.labelInputFrom);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.inputTextTo);
            this.Controls.Add(this.checkBoxDecimal);
            this.Controls.Add(this.textBoxCalculation);
            this.Controls.Add(this.labelCalculation);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.inputTextFrom);
            this.Name = "Converter";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextFrom;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelCalculation;
        private System.Windows.Forms.RichTextBox textBoxCalculation;
        private System.Windows.Forms.CheckBox checkBoxDecimal;
        private System.Windows.Forms.TextBox inputTextTo;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Label labelInputFrom;
        private System.Windows.Forms.Label labelInputTo;
    }
}

