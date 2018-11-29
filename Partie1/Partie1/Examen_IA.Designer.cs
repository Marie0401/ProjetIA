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
            this.btnValiderRep = new System.Windows.Forms.Button();
            this.lblNumQuestion = new System.Windows.Forms.Label();
            this.lblAffichageQuestion = new System.Windows.Forms.Label();
            this.affichagePropositionReponses = new System.Windows.Forms.GroupBox();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblPasDeRepSelectionnee = new System.Windows.Forms.Label();
            this.gpbxReponse = new System.Windows.Forms.GroupBox();
            this.lblBonneReponse = new System.Windows.Forms.Label();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.btnQuestionSuivante = new System.Windows.Forms.Button();
            this.affichagePropositionReponses.SuspendLayout();
            this.gpbxReponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(186, 19);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(257, 24);
            this.titre.TabIndex = 0;
            this.titre.Text = "Examen d\'IA - bon courage ! ";
            // 
            // btnValiderRep
            // 
            this.btnValiderRep.Location = new System.Drawing.Point(461, 537);
            this.btnValiderRep.Name = "btnValiderRep";
            this.btnValiderRep.Size = new System.Drawing.Size(111, 55);
            this.btnValiderRep.TabIndex = 2;
            this.btnValiderRep.Text = "Valider la réponse";
            this.btnValiderRep.UseVisualStyleBackColor = true;
            this.btnValiderRep.Click += new System.EventHandler(this.validerRep_Click);
            // 
            // lblNumQuestion
            // 
            this.lblNumQuestion.AutoSize = true;
            this.lblNumQuestion.Location = new System.Drawing.Point(489, 70);
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
            this.affichagePropositionReponses.Size = new System.Drawing.Size(501, 232);
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
            this.radioButton3.Location = new System.Drawing.Point(24, 170);
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
            this.radioButton2.Location = new System.Drawing.Point(24, 125);
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
            this.radioButton1.Location = new System.Drawing.Point(24, 83);
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
            this.lblPasDeRepSelectionnee.ForeColor = System.Drawing.Color.Black;
            this.lblPasDeRepSelectionnee.Location = new System.Drawing.Point(112, 407);
            this.lblPasDeRepSelectionnee.MinimumSize = new System.Drawing.Size(120, 10);
            this.lblPasDeRepSelectionnee.Name = "lblPasDeRepSelectionnee";
            this.lblPasDeRepSelectionnee.Size = new System.Drawing.Size(402, 13);
            this.lblPasDeRepSelectionnee.TabIndex = 19;
            this.lblPasDeRepSelectionnee.Text = "Vous n\'avez pas séléctionné de réponse ! Veuillez choisir une réponse pour valide" +
    "r. ";
            this.lblPasDeRepSelectionnee.Visible = false;
            // 
            // gpbxReponse
            // 
            this.gpbxReponse.Controls.Add(this.lblBonneReponse);
            this.gpbxReponse.Location = new System.Drawing.Point(71, 440);
            this.gpbxReponse.Name = "gpbxReponse";
            this.gpbxReponse.Size = new System.Drawing.Size(501, 77);
            this.gpbxReponse.TabIndex = 20;
            this.gpbxReponse.TabStop = false;
            this.gpbxReponse.Text = "La bonne réponse était : ";
            this.gpbxReponse.Visible = false;
            // 
            // lblBonneReponse
            // 
            this.lblBonneReponse.AutoSize = true;
            this.lblBonneReponse.Location = new System.Drawing.Point(21, 30);
            this.lblBonneReponse.Name = "lblBonneReponse";
            this.lblBonneReponse.Size = new System.Drawing.Size(91, 13);
            this.lblBonneReponse.TabIndex = 0;
            this.lblBonneReponse.Text = "lblBonneReponse";
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.Location = new System.Drawing.Point(71, 69);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(44, 13);
            this.lblScoreTotal.TabIndex = 21;
            this.lblScoreTotal.Text = "Score : ";
            // 
            // btnQuestionSuivante
            // 
            this.btnQuestionSuivante.Location = new System.Drawing.Point(235, 537);
            this.btnQuestionSuivante.Name = "btnQuestionSuivante";
            this.btnQuestionSuivante.Size = new System.Drawing.Size(124, 55);
            this.btnQuestionSuivante.TabIndex = 22;
            this.btnQuestionSuivante.Text = "Question suivante ";
            this.btnQuestionSuivante.UseVisualStyleBackColor = true;
            this.btnQuestionSuivante.Visible = false;
            this.btnQuestionSuivante.Click += new System.EventHandler(this.btnQuestionSuivante_Click);
            // 
            // Examen_IA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 620);
            this.Controls.Add(this.btnQuestionSuivante);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.gpbxReponse);
            this.Controls.Add(this.lblPasDeRepSelectionnee);
            this.Controls.Add(this.affichagePropositionReponses);
            this.Controls.Add(this.lblAffichageQuestion);
            this.Controls.Add(this.lblNumQuestion);
            this.Controls.Add(this.btnValiderRep);
            this.Controls.Add(this.titre);
            this.Name = "Examen_IA";
            this.Text = "Examen d\'IA";
            this.Load += new System.EventHandler(this.Examen_IA_Load);
            this.affichagePropositionReponses.ResumeLayout(false);
            this.affichagePropositionReponses.PerformLayout();
            this.gpbxReponse.ResumeLayout(false);
            this.gpbxReponse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button btnValiderRep;
        private System.Windows.Forms.Label lblNumQuestion;
        private System.Windows.Forms.Label lblAffichageQuestion;
        private System.Windows.Forms.GroupBox affichagePropositionReponses;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblPasDeRepSelectionnee;
        private System.Windows.Forms.GroupBox gpbxReponse;
        private System.Windows.Forms.Label lblBonneReponse;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Button btnQuestionSuivante;
    }
}

