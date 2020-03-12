namespace PingPongV4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Gamefield = new System.Windows.Forms.Panel();
            this.Schläger = new System.Windows.Forms.Panel();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.lblpunkte = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Schlager = new System.Windows.Forms.VScrollBar();
            this.Gamefield.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Gamefield
            // 
            this.Gamefield.BackColor = System.Drawing.Color.ForestGreen;
            this.Gamefield.Controls.Add(this.Schläger);
            this.Gamefield.Controls.Add(this.Ball);
            this.Gamefield.Location = new System.Drawing.Point(0, 0);
            this.Gamefield.Name = "Gamefield";
            this.Gamefield.Size = new System.Drawing.Size(600, 300);
            this.Gamefield.TabIndex = 0;
            this.Gamefield.Paint += new System.Windows.Forms.PaintEventHandler(this.Gamefield_Paint);
            // 
            // Schläger
            // 
            this.Schläger.BackColor = System.Drawing.Color.Black;
            this.Schläger.Location = new System.Drawing.Point(577, 150);
            this.Schläger.Name = "Schläger";
            this.Schläger.Size = new System.Drawing.Size(20, 50);
            this.Schläger.TabIndex = 1;
            this.Schläger.Paint += new System.Windows.Forms.PaintEventHandler(this.Schläger_Paint);
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Ball.Location = new System.Drawing.Point(283, 126);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(25, 25);
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            this.Ball.Click += new System.EventHandler(this.Ball_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(12, 318);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(80, 31);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblpunkte
            // 
            this.lblpunkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpunkte.Location = new System.Drawing.Point(402, 318);
            this.lblpunkte.Name = "lblpunkte";
            this.lblpunkte.Size = new System.Drawing.Size(100, 31);
            this.lblpunkte.TabIndex = 2;
            this.lblpunkte.Text = "Punkte :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(508, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 3;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Schlager
            // 
            this.Schlager.LargeChange = 0;
            this.Schlager.Location = new System.Drawing.Point(603, 0);
            this.Schlager.Name = "Schlager";
            this.Schlager.Size = new System.Drawing.Size(31, 300);
            this.Schlager.SmallChange = 0;
            this.Schlager.TabIndex = 4;
            this.Schlager.Value = 50;
            this.Schlager.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Schlager_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Schlager);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblpunkte);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.Gamefield);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Gamefield.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Gamefield;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label lblpunkte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel Schläger;
        private System.Windows.Forms.VScrollBar Schlager;
    }
}

