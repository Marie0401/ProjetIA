﻿namespace Partie1bis
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
            this.lblPhraseAccueil1 = new System.Windows.Forms.Label();
            this.lblPhraseAccueil2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommencerTest
            // 
            this.btnCommencerTest.Location = new System.Drawing.Point(158, 267);
            this.btnCommencerTest.Name = "btnCommencerTest";
            this.btnCommencerTest.Size = new System.Drawing.Size(246, 70);
            this.btnCommencerTest.TabIndex = 0;
            this.btnCommencerTest.Text = "Commencer le test ";
            this.btnCommencerTest.UseVisualStyleBackColor = true;
            this.btnCommencerTest.Click += new System.EventHandler(this.btnCommencerTest_Click);
            // 
            // lblPhraseAccueil1
            // 
            this.lblPhraseAccueil1.AutoSize = true;
            this.lblPhraseAccueil1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhraseAccueil1.Location = new System.Drawing.Point(30, 109);
            this.lblPhraseAccueil1.Name = "lblPhraseAccueil1";
            this.lblPhraseAccueil1.Size = new System.Drawing.Size(508, 24);
            this.lblPhraseAccueil1.TabIndex = 1;
            this.lblPhraseAccueil1.Text = "Bonjour ! Bienvenue à cet examen d\'intelligence artificielle. ";
            // 
            // lblPhraseAccueil2
            // 
            this.lblPhraseAccueil2.AutoSize = true;
            this.lblPhraseAccueil2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhraseAccueil2.Location = new System.Drawing.Point(89, 182);
            this.lblPhraseAccueil2.Name = "lblPhraseAccueil2";
            this.lblPhraseAccueil2.Size = new System.Drawing.Size(403, 18);
            this.lblPhraseAccueil2.TabIndex = 2;
            this.lblPhraseAccueil2.Text = "Une série de questions va vous être posée. Êtes vous prêt ?";
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 461);
            this.Controls.Add(this.lblPhraseAccueil2);
            this.Controls.Add(this.lblPhraseAccueil1);
            this.Controls.Add(this.btnCommencerTest);
            this.Name = "FormAccueil";
            this.Text = "FormAccueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommencerTest;
        private System.Windows.Forms.Label lblPhraseAccueil1;
        private System.Windows.Forms.Label lblPhraseAccueil2;
    }
}