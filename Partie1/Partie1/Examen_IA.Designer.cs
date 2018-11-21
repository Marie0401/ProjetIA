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
            this.question = new System.Windows.Forms.Label();
            this.affichageQuestion = new System.Windows.Forms.ListBox();
            this.validerRep = new System.Windows.Forms.Button();
            this.affichagePropositionReponses = new System.Windows.Forms.ListBox();
            this.reponses = new System.Windows.Forms.Label();
            this.comboBoxChoixRep = new System.Windows.Forms.ComboBox();
            this.lblNumQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Location = new System.Drawing.Point(232, 26);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(144, 13);
            this.question.TabIndex = 0;
            this.question.Text = "Examen d\'IA - bon courage ! ";
            // 
            // affichageQuestion
            // 
            this.affichageQuestion.FormattingEnabled = true;
            this.affichageQuestion.Location = new System.Drawing.Point(68, 107);
            this.affichageQuestion.Name = "affichageQuestion";
            this.affichageQuestion.Size = new System.Drawing.Size(504, 43);
            this.affichageQuestion.TabIndex = 1;
            // 
            // validerRep
            // 
            this.validerRep.Location = new System.Drawing.Point(497, 360);
            this.validerRep.Name = "validerRep";
            this.validerRep.Size = new System.Drawing.Size(75, 40);
            this.validerRep.TabIndex = 2;
            this.validerRep.Text = "Valider la réponse";
            this.validerRep.UseVisualStyleBackColor = true;
            this.validerRep.Click += new System.EventHandler(this.validerRep_Click);
            // 
            // affichagePropositionReponses
            // 
            this.affichagePropositionReponses.FormattingEnabled = true;
            this.affichagePropositionReponses.Location = new System.Drawing.Point(68, 184);
            this.affichagePropositionReponses.Name = "affichagePropositionReponses";
            this.affichagePropositionReponses.Size = new System.Drawing.Size(504, 95);
            this.affichagePropositionReponses.TabIndex = 5;
            // 
            // reponses
            // 
            this.reponses.AutoSize = true;
            this.reponses.Location = new System.Drawing.Point(68, 310);
            this.reponses.Name = "reponses";
            this.reponses.Size = new System.Drawing.Size(98, 13);
            this.reponses.TabIndex = 6;
            this.reponses.Text = "Choix de réponse : ";
            // 
            // comboBoxChoixRep
            // 
            this.comboBoxChoixRep.FormattingEnabled = true;
            this.comboBoxChoixRep.Location = new System.Drawing.Point(71, 338);
            this.comboBoxChoixRep.Name = "comboBoxChoixRep";
            this.comboBoxChoixRep.Size = new System.Drawing.Size(116, 21);
            this.comboBoxChoixRep.TabIndex = 15;
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
            // Examen_IA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 462);
            this.Controls.Add(this.lblNumQuestion);
            this.Controls.Add(this.comboBoxChoixRep);
            this.Controls.Add(this.reponses);
            this.Controls.Add(this.affichagePropositionReponses);
            this.Controls.Add(this.validerRep);
            this.Controls.Add(this.affichageQuestion);
            this.Controls.Add(this.question);
            this.Name = "Examen_IA";
            this.Text = "Examen d\'IA";
            this.Load += new System.EventHandler(this.Examen_IA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.ListBox affichageQuestion;
        private System.Windows.Forms.Button validerRep;
        private System.Windows.Forms.ListBox affichagePropositionReponses;
        private System.Windows.Forms.Label reponses;
        private System.Windows.Forms.ComboBox comboBoxChoixRep;
        private System.Windows.Forms.Label lblNumQuestion;
    }
}

