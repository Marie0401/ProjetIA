namespace Partie1bis
{
    partial class AffichageFinal
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
            this.lblMsgFin = new System.Windows.Forms.Label();
            this.lblAffichageScoreFinal = new System.Windows.Forms.Label();
            this.btnFinTest = new System.Windows.Forms.Button();
            this.lblMesgDeFin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMsgFin
            // 
            this.lblMsgFin.AutoSize = true;
            this.lblMsgFin.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgFin.Location = new System.Drawing.Point(121, 136);
            this.lblMsgFin.Name = "lblMsgFin";
            this.lblMsgFin.Size = new System.Drawing.Size(394, 24);
            this.lblMsgFin.TabIndex = 0;
            this.lblMsgFin.Text = "Le test est terminé ! Voici votre score : ";
            // 
            // lblAffichageScoreFinal
            // 
            this.lblAffichageScoreFinal.AutoSize = true;
            this.lblAffichageScoreFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffichageScoreFinal.ForeColor = System.Drawing.Color.Black;
            this.lblAffichageScoreFinal.Location = new System.Drawing.Point(176, 243);
            this.lblAffichageScoreFinal.Name = "lblAffichageScoreFinal";
            this.lblAffichageScoreFinal.Size = new System.Drawing.Size(390, 42);
            this.lblAffichageScoreFinal.TabIndex = 1;
            this.lblAffichageScoreFinal.Text = "lblAffichageScoreFinal";
            // 
            // btnFinTest
            // 
            this.btnFinTest.Location = new System.Drawing.Point(228, 437);
            this.btnFinTest.Name = "btnFinTest";
            this.btnFinTest.Size = new System.Drawing.Size(167, 63);
            this.btnFinTest.TabIndex = 2;
            this.btnFinTest.Text = "Quitter le test";
            this.btnFinTest.UseVisualStyleBackColor = true;
            this.btnFinTest.Click += new System.EventHandler(this.btnFinTest_Click);
            // 
            // lblMesgDeFin
            // 
            this.lblMesgDeFin.AutoSize = true;
            this.lblMesgDeFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesgDeFin.Location = new System.Drawing.Point(158, 391);
            this.lblMesgDeFin.Name = "lblMesgDeFin";
            this.lblMesgDeFin.Size = new System.Drawing.Size(294, 20);
            this.lblMesgDeFin.TabIndex = 3;
            this.lblMesgDeFin.Text = "Merci pour votre participation, à bientôt ! ";
            // 
            // AffichageFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 621);
            this.Controls.Add(this.lblMesgDeFin);
            this.Controls.Add(this.btnFinTest);
            this.Controls.Add(this.lblAffichageScoreFinal);
            this.Controls.Add(this.lblMsgFin);
            this.Name = "AffichageFinal";
            this.Text = "Affichage du score final ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsgFin;
        private System.Windows.Forms.Label lblAffichageScoreFinal;
        private System.Windows.Forms.Button btnFinTest;
        private System.Windows.Forms.Label lblMesgDeFin;
    }
}