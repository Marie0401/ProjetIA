namespace Partie2
{
    partial class Examen_IA_partie2
    {
        private System.Windows.Forms.GroupBox FermesActu_groupeBx;
        private System.Windows.Forms.Label lbl_reponseOuverts;
        private System.Windows.Forms.Label lbl_reponseFermes;
        private System.Windows.Forms.TextBox txtBox_reponseFermes;
        private System.Windows.Forms.TextBox txtBox_reponseOuverts;
        private System.Windows.Forms.PictureBox Image_Graphe;
        private System.Windows.Forms.Button btn_Valider;

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
            this.FermesActu_groupeBx = new System.Windows.Forms.GroupBox();
            this.Solution_groupBox = new System.Windows.Forms.GroupBox();
            this.Reinitialiser_button = new System.Windows.Forms.Button();
            this.solutionOuvert_textBox = new System.Windows.Forms.TextBox();
            this.solutionOuvert_label = new System.Windows.Forms.Label();
            this.solutionFerme_label = new System.Windows.Forms.Label();
            this.solutionFerme_textBox = new System.Windows.Forms.TextBox();
            this.versGraphe_button = new System.Windows.Forms.Button();
            this.Reponse_groupBox = new System.Windows.Forms.GroupBox();
            this.txtBox_reponseOuverts = new System.Windows.Forms.TextBox();
            this.lbl_reponseOuverts = new System.Windows.Forms.Label();
            this.lbl_reponseFermes = new System.Windows.Forms.Label();
            this.txtBox_reponseFermes = new System.Windows.Forms.TextBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.NoeudFinal_textBox = new System.Windows.Forms.TextBox();
            this.NoeudInit_textBox = new System.Windows.Forms.TextBox();
            this.NoeudFinal_label = new System.Windows.Forms.Label();
            this.NoeudInit_label = new System.Windows.Forms.Label();
            this.Image_Graphe = new System.Windows.Forms.PictureBox();
            this.FermesActu_groupeBx.SuspendLayout();
            this.Solution_groupBox.SuspendLayout();
            this.Reponse_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Graphe)).BeginInit();
            this.SuspendLayout();
            // 
            // FermesActu_groupeBx
            // 
            this.FermesActu_groupeBx.Controls.Add(this.Solution_groupBox);
            this.FermesActu_groupeBx.Controls.Add(this.Reponse_groupBox);
            this.FermesActu_groupeBx.Controls.Add(this.NoeudFinal_textBox);
            this.FermesActu_groupeBx.Controls.Add(this.NoeudInit_textBox);
            this.FermesActu_groupeBx.Controls.Add(this.NoeudFinal_label);
            this.FermesActu_groupeBx.Controls.Add(this.NoeudInit_label);
            this.FermesActu_groupeBx.Controls.Add(this.Image_Graphe);
            this.FermesActu_groupeBx.Location = new System.Drawing.Point(12, 12);
            this.FermesActu_groupeBx.Name = "FermesActu_groupeBx";
            this.FermesActu_groupeBx.Size = new System.Drawing.Size(759, 550);
            this.FermesActu_groupeBx.TabIndex = 0;
            this.FermesActu_groupeBx.TabStop = false;
            this.FermesActu_groupeBx.Text = "Dijkstra à la main";
            // 
            // Solution_groupBox
            // 
            this.Solution_groupBox.Controls.Add(this.Reinitialiser_button);
            this.Solution_groupBox.Controls.Add(this.solutionOuvert_textBox);
            this.Solution_groupBox.Controls.Add(this.solutionOuvert_label);
            this.Solution_groupBox.Controls.Add(this.solutionFerme_label);
            this.Solution_groupBox.Controls.Add(this.solutionFerme_textBox);
            this.Solution_groupBox.Controls.Add(this.versGraphe_button);
            this.Solution_groupBox.Location = new System.Drawing.Point(392, 229);
            this.Solution_groupBox.Name = "Solution_groupBox";
            this.Solution_groupBox.Size = new System.Drawing.Size(362, 315);
            this.Solution_groupBox.TabIndex = 18;
            this.Solution_groupBox.TabStop = false;
            this.Solution_groupBox.Text = "Solution";
            // 
            // Reinitialiser_button
            // 
            this.Reinitialiser_button.Location = new System.Drawing.Point(53, 255);
            this.Reinitialiser_button.Name = "Reinitialiser_button";
            this.Reinitialiser_button.Size = new System.Drawing.Size(111, 36);
            this.Reinitialiser_button.TabIndex = 10;
            this.Reinitialiser_button.Text = "Réinisialiser";
            this.Reinitialiser_button.UseVisualStyleBackColor = true;
            this.Reinitialiser_button.Click += new System.EventHandler(this.Reinitialiser_button_Click);
            // 
            // solutionOuvert_textBox
            // 
            this.solutionOuvert_textBox.Location = new System.Drawing.Point(6, 50);
            this.solutionOuvert_textBox.Multiline = true;
            this.solutionOuvert_textBox.Name = "solutionOuvert_textBox";
            this.solutionOuvert_textBox.Size = new System.Drawing.Size(158, 188);
            this.solutionOuvert_textBox.TabIndex = 5;
            // 
            // solutionOuvert_label
            // 
            this.solutionOuvert_label.AutoSize = true;
            this.solutionOuvert_label.Location = new System.Drawing.Point(3, 33);
            this.solutionOuvert_label.Name = "solutionOuvert_label";
            this.solutionOuvert_label.Size = new System.Drawing.Size(87, 13);
            this.solutionOuvert_label.TabIndex = 3;
            this.solutionOuvert_label.Text = "Liste des ouverts";
            // 
            // solutionFerme_label
            // 
            this.solutionFerme_label.AutoSize = true;
            this.solutionFerme_label.Location = new System.Drawing.Point(194, 33);
            this.solutionFerme_label.Name = "solutionFerme_label";
            this.solutionFerme_label.Size = new System.Drawing.Size(83, 13);
            this.solutionFerme_label.TabIndex = 4;
            this.solutionFerme_label.Text = "Liste des fermés";
            // 
            // solutionFerme_textBox
            // 
            this.solutionFerme_textBox.Location = new System.Drawing.Point(197, 50);
            this.solutionFerme_textBox.Multiline = true;
            this.solutionFerme_textBox.Name = "solutionFerme_textBox";
            this.solutionFerme_textBox.Size = new System.Drawing.Size(158, 188);
            this.solutionFerme_textBox.TabIndex = 6;
            // 
            // versGraphe_button
            // 
            this.versGraphe_button.Location = new System.Drawing.Point(197, 255);
            this.versGraphe_button.Name = "versGraphe_button";
            this.versGraphe_button.Size = new System.Drawing.Size(111, 36);
            this.versGraphe_button.TabIndex = 9;
            this.versGraphe_button.Text = "Passez à l\'exercice suivant ";
            this.versGraphe_button.UseVisualStyleBackColor = true;
            // 
            // Reponse_groupBox
            // 
            this.Reponse_groupBox.Controls.Add(this.txtBox_reponseOuverts);
            this.Reponse_groupBox.Controls.Add(this.lbl_reponseOuverts);
            this.Reponse_groupBox.Controls.Add(this.lbl_reponseFermes);
            this.Reponse_groupBox.Controls.Add(this.txtBox_reponseFermes);
            this.Reponse_groupBox.Controls.Add(this.btn_Valider);
            this.Reponse_groupBox.Location = new System.Drawing.Point(6, 229);
            this.Reponse_groupBox.Name = "Reponse_groupBox";
            this.Reponse_groupBox.Size = new System.Drawing.Size(362, 315);
            this.Reponse_groupBox.TabIndex = 17;
            this.Reponse_groupBox.TabStop = false;
            this.Reponse_groupBox.Text = "Vos réponses";
            // 
            // txtBox_reponseOuverts
            // 
            this.txtBox_reponseOuverts.Location = new System.Drawing.Point(6, 50);
            this.txtBox_reponseOuverts.Multiline = true;
            this.txtBox_reponseOuverts.Name = "txtBox_reponseOuverts";
            this.txtBox_reponseOuverts.Size = new System.Drawing.Size(158, 188);
            this.txtBox_reponseOuverts.TabIndex = 5;
            // 
            // lbl_reponseOuverts
            // 
            this.lbl_reponseOuverts.AutoSize = true;
            this.lbl_reponseOuverts.Location = new System.Drawing.Point(3, 33);
            this.lbl_reponseOuverts.Name = "lbl_reponseOuverts";
            this.lbl_reponseOuverts.Size = new System.Drawing.Size(87, 13);
            this.lbl_reponseOuverts.TabIndex = 3;
            this.lbl_reponseOuverts.Text = "Liste des ouverts";
            // 
            // lbl_reponseFermes
            // 
            this.lbl_reponseFermes.AutoSize = true;
            this.lbl_reponseFermes.Location = new System.Drawing.Point(194, 33);
            this.lbl_reponseFermes.Name = "lbl_reponseFermes";
            this.lbl_reponseFermes.Size = new System.Drawing.Size(83, 13);
            this.lbl_reponseFermes.TabIndex = 4;
            this.lbl_reponseFermes.Text = "Liste des fermés";
            // 
            // txtBox_reponseFermes
            // 
            this.txtBox_reponseFermes.Location = new System.Drawing.Point(197, 50);
            this.txtBox_reponseFermes.Multiline = true;
            this.txtBox_reponseFermes.Name = "txtBox_reponseFermes";
            this.txtBox_reponseFermes.Size = new System.Drawing.Size(158, 188);
            this.txtBox_reponseFermes.TabIndex = 6;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(142, 255);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 9;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // NoeudFinal_textBox
            // 
            this.NoeudFinal_textBox.Location = new System.Drawing.Point(133, 106);
            this.NoeudFinal_textBox.Name = "NoeudFinal_textBox";
            this.NoeudFinal_textBox.Size = new System.Drawing.Size(30, 20);
            this.NoeudFinal_textBox.TabIndex = 15;
            this.NoeudFinal_textBox.Text = "6";
            // 
            // NoeudInit_textBox
            // 
            this.NoeudInit_textBox.Location = new System.Drawing.Point(133, 64);
            this.NoeudInit_textBox.Name = "NoeudInit_textBox";
            this.NoeudInit_textBox.Size = new System.Drawing.Size(30, 20);
            this.NoeudInit_textBox.TabIndex = 14;
            this.NoeudInit_textBox.Text = "0";
            // 
            // NoeudFinal_label
            // 
            this.NoeudFinal_label.AutoSize = true;
            this.NoeudFinal_label.Location = new System.Drawing.Point(66, 109);
            this.NoeudFinal_label.Name = "NoeudFinal_label";
            this.NoeudFinal_label.Size = new System.Drawing.Size(61, 13);
            this.NoeudFinal_label.TabIndex = 13;
            this.NoeudFinal_label.Text = "Noeud final";
            // 
            // NoeudInit_label
            // 
            this.NoeudInit_label.AutoSize = true;
            this.NoeudInit_label.Location = new System.Drawing.Point(62, 67);
            this.NoeudInit_label.Name = "NoeudInit_label";
            this.NoeudInit_label.Size = new System.Drawing.Size(65, 13);
            this.NoeudInit_label.TabIndex = 12;
            this.NoeudInit_label.Text = "Noeud initial";
            // 
            // Image_Graphe
            // 
            this.Image_Graphe.Image = global::Partie2.Properties.Resources.Graphe1;
            this.Image_Graphe.Location = new System.Drawing.Point(240, 19);
            this.Image_Graphe.Name = "Image_Graphe";
            this.Image_Graphe.Size = new System.Drawing.Size(336, 166);
            this.Image_Graphe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Image_Graphe.TabIndex = 10;
            this.Image_Graphe.TabStop = false;
            // 
            // Examen_IA_partie2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 575);
            this.Controls.Add(this.FermesActu_groupeBx);
            this.Name = "Examen_IA_partie2";
            this.Text = "Examen IA";
            this.FermesActu_groupeBx.ResumeLayout(false);
            this.FermesActu_groupeBx.PerformLayout();
            this.Solution_groupBox.ResumeLayout(false);
            this.Solution_groupBox.PerformLayout();
            this.Reponse_groupBox.ResumeLayout(false);
            this.Reponse_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Graphe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox NoeudFinal_textBox;
        private System.Windows.Forms.TextBox NoeudInit_textBox;
        private System.Windows.Forms.Label NoeudFinal_label;
        private System.Windows.Forms.Label NoeudInit_label;
        private System.Windows.Forms.GroupBox Reponse_groupBox;
        private System.Windows.Forms.GroupBox Solution_groupBox;
        private System.Windows.Forms.TextBox solutionOuvert_textBox;
        private System.Windows.Forms.Label solutionOuvert_label;
        private System.Windows.Forms.Label solutionFerme_label;
        private System.Windows.Forms.TextBox solutionFerme_textBox;
        private System.Windows.Forms.Button versGraphe_button;
        private System.Windows.Forms.Button Reinitialiser_button;
    }
}

