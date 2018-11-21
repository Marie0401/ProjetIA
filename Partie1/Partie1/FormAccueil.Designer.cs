namespace Partie1bis
{
    partial class FormAccueil
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
            this.btnCommencerTest = new System.Windows.Forms.Button();
            this.lblPhraseAccueil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommencerTest
            // 
            this.btnCommencerTest.Location = new System.Drawing.Point(203, 267);
            this.btnCommencerTest.Name = "btnCommencerTest";
            this.btnCommencerTest.Size = new System.Drawing.Size(246, 70);
            this.btnCommencerTest.TabIndex = 0;
            this.btnCommencerTest.Text = "Commencer le test ";
            this.btnCommencerTest.UseVisualStyleBackColor = true;
            this.btnCommencerTest.Click += new System.EventHandler(this.btnCommencerTest_Click);
            // 
            // lblPhraseAccueil
            // 
            this.lblPhraseAccueil.AutoSize = true;
            this.lblPhraseAccueil.Location = new System.Drawing.Point(58, 154);
            this.lblPhraseAccueil.Name = "lblPhraseAccueil";
            this.lblPhraseAccueil.Size = new System.Drawing.Size(540, 13);
            this.lblPhraseAccueil.TabIndex = 1;
            this.lblPhraseAccueil.Text = "Bonjour ! Bienvenue à cet examen d\'intelligence artificielle.  20 questions vont " +
    "vous être posées. Êtes vous prêt ?";
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 461);
            this.Controls.Add(this.lblPhraseAccueil);
            this.Controls.Add(this.btnCommencerTest);
            this.Name = "FormAccueil";
            this.Text = "FormAccueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommencerTest;
        private System.Windows.Forms.Label lblPhraseAccueil;
    }
}