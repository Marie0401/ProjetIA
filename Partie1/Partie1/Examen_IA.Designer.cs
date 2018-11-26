namespace Partie1bis
{
    partial class Examen_IA
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.titre = new System.Windows.Forms.Label();
            this.validerRep = new System.Windows.Forms.Button();
            this.lblNumQuestion = new System.Windows.Forms.Label();
            this.lblAffichageQuestion = new System.Windows.Forms.Label();
            this.affichagePropositionReponses = new System.Windows.Forms.GroupBox();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblPasDeRepSelectionnee = new System.Windows.Forms.Label();
            this.affichagePropositionReponses.SuspendLayout();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Location = new System.Drawing.Point(232, 26);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(144, 13);
            this.titre.TabIndex = 0;
            this.titre.Text = "Examen d\'IA - bon courage ! ";
            // 
            // validerRep
            // 
            this.validerRep.Location = new System.Drawing.Point(470, 353);
            this.validerRep.Name = "validerRep";
            this.validerRep.Size = new System.Drawing.Size(102, 40);
            this.validerRep.TabIndex = 2;
            this.validerRep.Text = "Valider la réponse";
            this.validerRep.UseVisualStyleBackColor = true;
            this.validerRep.Click += new System.EventHandler(this.validerRep_Click);
            // 
            // lblNumQuestion
            // 
            this.lblNumQuestion.AutoSize = true;
            this.lblNumQuestion.Location = new System.Drawing.Point(489, 65);
            this.lblNumQuestion.Name = "lblNumQuestion";
            this.lblNumQuestion.Size = new System.Drawing.Size(83, 13);
            this.lblNumQuestion.TabIndex = 16;
            this.lblNumQuestion.Text = "numQuestSur20";
            // 
            // lblAffichageQuestion
            // 
            this.lblAffichageQuestion.AutoSize = true;
            this.lblAffichageQuestion.Location = new System.Drawing.Point(68, 118);
            this.lblAffichageQuestion.Name = "lblAffichageQuestion";
            this.lblAffichageQuestion.Size = new System.Drawing.Size(104, 13);
            this.lblAffichageQuestion.TabIndex = 17;
            this.lblAffichageQuestion.Text = "lblAffichageQuestion";
            // 
            // affichagePropositionReponses
            // 
            this.affichagePropositionReponses.Controls.Add(this.radioButton0);
            this.affichagePropositionReponses.Controls.Add(this.radioButton3);
            this.affichagePropositionReponses.Controls.Add(this.radioButton2);
            this.affichagePropositionReponses.Controls.Add(this.radioButton1);
            this.affichagePropositionReponses.Location = new System.Drawing.Point(71, 156);
            this.affichagePropositionReponses.Name = "affichagePropositionReponses";
            this.affichagePropositionReponses.Size = new System.Drawing.Size(501, 146);
            this.affichagePropositionReponses.TabIndex = 18;
            this.affichagePropositionReponses.TabStop = false;
            this.affichagePropositionReponses.Text = "Réponses possibles : ";
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Location = new System.Drawing.Point(24, 37);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(85, 17);
            this.radioButton0.TabIndex = 3;
            this.radioButton0.TabStop = true;
            this.radioButton0.Text = "radioButton0";
            this.radioButton0.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 108);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 84);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblPasDeRepSelectionnee
            // 
            this.lblPasDeRepSelectionnee.AutoSize = true;
            this.lblPasDeRepSelectionnee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPasDeRepSelectionnee.ForeColor = System.Drawing.Color.Red;
            this.lblPasDeRepSelectionnee.Location = new System.Drawing.Point(112, 318);
            this.lblPasDeRepSelectionnee.MinimumSize = new System.Drawing.Size(120, 10);
            this.lblPasDeRepSelectionnee.Name = "lblPasDeRepSelectionnee";
            this.lblPasDeRepSelectionnee.Size = new System.Drawing.Size(402, 13);
            this.lblPasDeRepSelectionnee.TabIndex = 19;
            this.lblPasDeRepSelectionnee.Text = "Vous n\'avez pas séléctionné de réponse ! Veuillez choisir une réponse pour valide" +
    "r. ";
            this.lblPasDeRepSelectionnee.Visible = false;
            // 
            // Examen_IA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 462);
            this.Controls.Add(this.lblPasDeRepSelectionnee);
            this.Controls.Add(this.affichagePropositionReponses);
            this.Controls.Add(this.lblAffichageQuestion);
            this.Controls.Add(this.lblNumQuestion);
            this.Controls.Add(this.validerRep);
            this.Controls.Add(this.titre);
            this.Name = "Examen_IA";
            this.Text = "Examen d\'IA";
            this.Load += new System.EventHandler(this.Examen_IA_Load);
            this.affichagePropositionReponses.ResumeLayout(false);
            this.affichagePropositionReponses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button validerRep;
        private System.Windows.Forms.Label lblNumQuestion;
        private System.Windows.Forms.Label lblAffichageQuestion;
        private System.Windows.Forms.GroupBox affichagePropositionReponses;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblPasDeRepSelectionnee;
    }
}

