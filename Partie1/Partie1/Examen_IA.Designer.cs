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
            this.numQuestionSur20 = new System.Windows.Forms.ListBox();
            this.affichagePropositionReponses = new System.Windows.Forms.ListBox();
            this.reponses = new System.Windows.Forms.Label();
            this.radioButtonRepA = new System.Windows.Forms.RadioButton();
            this.radioButtonRepB = new System.Windows.Forms.RadioButton();
            this.radioButtonRepC = new System.Windows.Forms.RadioButton();
            this.radioButtonRepD = new System.Windows.Forms.RadioButton();
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
            // 
            // numQuestionSur20
            // 
            this.numQuestionSur20.FormattingEnabled = true;
            this.numQuestionSur20.Location = new System.Drawing.Point(474, 53);
            this.numQuestionSur20.Name = "numQuestionSur20";
            this.numQuestionSur20.Size = new System.Drawing.Size(98, 30);
            this.numQuestionSur20.TabIndex = 4;
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
            // radioButtonRepA
            // 
            this.radioButtonRepA.AutoSize = true;
            this.radioButtonRepA.Location = new System.Drawing.Point(68, 343);
            this.radioButtonRepA.Name = "radioButtonRepA";
            this.radioButtonRepA.Size = new System.Drawing.Size(81, 17);
            this.radioButtonRepA.TabIndex = 10;
            this.radioButtonRepA.TabStop = true;
            this.radioButtonRepA.Text = "Réponse A ";
            this.radioButtonRepA.UseVisualStyleBackColor = true;
            // 
            // radioButtonRepB
            // 
            this.radioButtonRepB.AutoSize = true;
            this.radioButtonRepB.Location = new System.Drawing.Point(259, 343);
            this.radioButtonRepB.Name = "radioButtonRepB";
            this.radioButtonRepB.Size = new System.Drawing.Size(78, 17);
            this.radioButtonRepB.TabIndex = 11;
            this.radioButtonRepB.TabStop = true;
            this.radioButtonRepB.Text = "Réponse B";
            this.radioButtonRepB.UseVisualStyleBackColor = true;
            // 
            // radioButtonRepC
            // 
            this.radioButtonRepC.AutoSize = true;
            this.radioButtonRepC.Location = new System.Drawing.Point(68, 383);
            this.radioButtonRepC.Name = "radioButtonRepC";
            this.radioButtonRepC.Size = new System.Drawing.Size(81, 17);
            this.radioButtonRepC.TabIndex = 12;
            this.radioButtonRepC.TabStop = true;
            this.radioButtonRepC.Text = "Réponse C ";
            this.radioButtonRepC.UseVisualStyleBackColor = true;
            // 
            // radioButtonRepD
            // 
            this.radioButtonRepD.AutoSize = true;
            this.radioButtonRepD.Location = new System.Drawing.Point(256, 383);
            this.radioButtonRepD.Name = "radioButtonRepD";
            this.radioButtonRepD.Size = new System.Drawing.Size(102, 17);
            this.radioButtonRepD.TabIndex = 13;
            this.radioButtonRepD.TabStop = true;
            this.radioButtonRepD.Text = "D, la réponse D ";
            this.radioButtonRepD.UseVisualStyleBackColor = true;
            // 
            // Examen_IA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 462);
            this.Controls.Add(this.radioButtonRepD);
            this.Controls.Add(this.radioButtonRepC);
            this.Controls.Add(this.radioButtonRepB);
            this.Controls.Add(this.radioButtonRepA);
            this.Controls.Add(this.reponses);
            this.Controls.Add(this.affichagePropositionReponses);
            this.Controls.Add(this.numQuestionSur20);
            this.Controls.Add(this.validerRep);
            this.Controls.Add(this.affichageQuestion);
            this.Controls.Add(this.question);
            this.Name = "Examen_IA";
            this.Text = "Examen d\'IA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.ListBox affichageQuestion;
        private System.Windows.Forms.Button validerRep;
        private System.Windows.Forms.ListBox numQuestionSur20;
        private System.Windows.Forms.ListBox affichagePropositionReponses;
        private System.Windows.Forms.Label reponses;
        private System.Windows.Forms.RadioButton radioButtonRepA;
        private System.Windows.Forms.RadioButton radioButtonRepB;
        private System.Windows.Forms.RadioButton radioButtonRepC;
        private System.Windows.Forms.RadioButton radioButtonRepD;
    }
}

