namespace AB01
{
    partial class frmTaschenrechner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOperator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraktion = new System.Windows.Forms.Button();
            this.btnMultiplikation = new System.Windows.Forms.Button();
            this.btnMittelwert = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnPotenz = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(374, 46);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(0, 13);
            this.lblOperator.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ergebnis:";
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.Location = new System.Drawing.Point(564, 43);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(203, 20);
            this.lblErgebnis.TabIndex = 2;
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(268, 43);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 20);
            this.txtOperand1.TabIndex = 3;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(401, 43);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 20);
            this.txtOperand2.TabIndex = 4;
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(426, 92);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(88, 23);
            this.btnAddition.TabIndex = 5;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraktion
            // 
            this.btnSubtraktion.Location = new System.Drawing.Point(426, 121);
            this.btnSubtraktion.Name = "btnSubtraktion";
            this.btnSubtraktion.Size = new System.Drawing.Size(88, 23);
            this.btnSubtraktion.TabIndex = 6;
            this.btnSubtraktion.Text = "Subtraktion";
            this.btnSubtraktion.UseVisualStyleBackColor = true;
            this.btnSubtraktion.Click += new System.EventHandler(this.btnSubtraktion_Click);
            // 
            // btnMultiplikation
            // 
            this.btnMultiplikation.Location = new System.Drawing.Point(426, 150);
            this.btnMultiplikation.Name = "btnMultiplikation";
            this.btnMultiplikation.Size = new System.Drawing.Size(88, 23);
            this.btnMultiplikation.TabIndex = 7;
            this.btnMultiplikation.Text = "Multiplikation";
            this.btnMultiplikation.UseVisualStyleBackColor = true;
            this.btnMultiplikation.Click += new System.EventHandler(this.btnMultiplikation_Click);
            // 
            // btnMittelwert
            // 
            this.btnMittelwert.Location = new System.Drawing.Point(324, 92);
            this.btnMittelwert.Name = "btnMittelwert";
            this.btnMittelwert.Size = new System.Drawing.Size(87, 23);
            this.btnMittelwert.TabIndex = 8;
            this.btnMittelwert.Text = "Mittelwert";
            this.btnMittelwert.UseVisualStyleBackColor = true;
            this.btnMittelwert.Click += new System.EventHandler(this.btnMittelwert_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(323, 121);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(88, 23);
            this.btnDivision.TabIndex = 9;
            this.btnDivision.Text = "Division";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPotenz
            // 
            this.btnPotenz.Location = new System.Drawing.Point(324, 150);
            this.btnPotenz.Name = "btnPotenz";
            this.btnPotenz.Size = new System.Drawing.Size(87, 23);
            this.btnPotenz.TabIndex = 10;
            this.btnPotenz.Text = "Potenz";
            this.btnPotenz.UseVisualStyleBackColor = true;
            this.btnPotenz.Click += new System.EventHandler(this.btnPotenz_Click);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(324, 179);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(87, 23);
            this.Max.TabIndex = 11;
            this.Max.Text = "Maximum";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.Max_Click);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(426, 179);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(88, 23);
            this.Min.TabIndex = 12;
            this.Min.Text = "Minimum";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // frmTaschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.btnPotenz);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMittelwert);
            this.Controls.Add(this.btnMultiplikation);
            this.Controls.Add(this.btnSubtraktion);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperator);
            this.Name = "frmTaschenrechner";
            this.Tag = "g";
            this.Text = "Taschenrechner";
            this.Load += new System.EventHandler(this.frmTaschenrechner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraktion;
        private System.Windows.Forms.Button btnMultiplikation;
        private System.Windows.Forms.Button btnMittelwert;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnPotenz;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Min;
    }
}

