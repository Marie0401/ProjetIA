namespace Partie2
{
    partial class Examen_IA_partie2
    {
        private System.Windows.Forms.GroupBox groupeBx_Titre;
        private System.Windows.Forms.Label lbl_OuvertsActuels;
        private System.Windows.Forms.Label lbl_FermesActuels;
        private System.Windows.Forms.Label lbl_OuvertsSuivants;
        private System.Windows.Forms.Label lbl_FermesSuivants;
        private System.Windows.Forms.TextBox txtBox_ListeFermes;
        private System.Windows.Forms.TextBox txtBox_ListeOuverts;
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
            this.groupeBx_Titre = new System.Windows.Forms.GroupBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.txtBox_ListeFermes = new System.Windows.Forms.TextBox();
            this.txtBox_ListeOuverts = new System.Windows.Forms.TextBox();
            this.lbl_FermesSuivants = new System.Windows.Forms.Label();
            this.lbl_OuvertsSuivants = new System.Windows.Forms.Label();
            this.lbl_FermesActuels = new System.Windows.Forms.Label();
            this.lbl_OuvertsActuels = new System.Windows.Forms.Label();
            this.Image_Graphe = new System.Windows.Forms.PictureBox();
            this.groupeBx_Titre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Graphe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupeBx_Titre
            // 
            this.groupeBx_Titre.Controls.Add(this.Image_Graphe);
            this.groupeBx_Titre.Controls.Add(this.btn_Valider);
            this.groupeBx_Titre.Controls.Add(this.txtBox_ListeFermes);
            this.groupeBx_Titre.Controls.Add(this.txtBox_ListeOuverts);
            this.groupeBx_Titre.Controls.Add(this.lbl_FermesSuivants);
            this.groupeBx_Titre.Controls.Add(this.lbl_OuvertsSuivants);
            this.groupeBx_Titre.Controls.Add(this.lbl_FermesActuels);
            this.groupeBx_Titre.Controls.Add(this.lbl_OuvertsActuels);
            this.groupeBx_Titre.Location = new System.Drawing.Point(12, 12);
            this.groupeBx_Titre.Name = "groupeBx_Titre";
            this.groupeBx_Titre.Size = new System.Drawing.Size(841, 550);
            this.groupeBx_Titre.TabIndex = 0;
            this.groupeBx_Titre.TabStop = false;
            this.groupeBx_Titre.Text = "Dijkstra à la main";
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(389, 484);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 9;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // txtBox_ListeFermes
            // 
            this.txtBox_ListeFermes.Location = new System.Drawing.Point(473, 442);
            this.txtBox_ListeFermes.Name = "txtBox_ListeFermes";
            this.txtBox_ListeFermes.Size = new System.Drawing.Size(198, 20);
            this.txtBox_ListeFermes.TabIndex = 6;
            // 
            // txtBox_ListeOuverts
            // 
            this.txtBox_ListeOuverts.Location = new System.Drawing.Point(184, 442);
            this.txtBox_ListeOuverts.Name = "txtBox_ListeOuverts";
            this.txtBox_ListeOuverts.Size = new System.Drawing.Size(198, 20);
            this.txtBox_ListeOuverts.TabIndex = 5;
            // 
            // lbl_FermesSuivants
            // 
            this.lbl_FermesSuivants.AutoSize = true;
            this.lbl_FermesSuivants.Location = new System.Drawing.Point(470, 425);
            this.lbl_FermesSuivants.Name = "lbl_FermesSuivants";
            this.lbl_FermesSuivants.Size = new System.Drawing.Size(83, 13);
            this.lbl_FermesSuivants.TabIndex = 4;
            this.lbl_FermesSuivants.Text = "Fermés suivants";
            // 
            // lbl_OuvertsSuivants
            // 
            this.lbl_OuvertsSuivants.AutoSize = true;
            this.lbl_OuvertsSuivants.Location = new System.Drawing.Point(181, 425);
            this.lbl_OuvertsSuivants.Name = "lbl_OuvertsSuivants";
            this.lbl_OuvertsSuivants.Size = new System.Drawing.Size(86, 13);
            this.lbl_OuvertsSuivants.TabIndex = 3;
            this.lbl_OuvertsSuivants.Text = "Ouverts suivants";
            // 
            // lbl_FermesActuels
            // 
            this.lbl_FermesActuels.AutoSize = true;
            this.lbl_FermesActuels.Location = new System.Drawing.Point(470, 376);
            this.lbl_FermesActuels.Name = "lbl_FermesActuels";
            this.lbl_FermesActuels.Size = new System.Drawing.Size(78, 26);
            this.lbl_FermesActuels.TabIndex = 2;
            this.lbl_FermesActuels.Text = "Fermés actuels\r\n  {}";
            // 
            // lbl_OuvertsActuels
            // 
            this.lbl_OuvertsActuels.AutoSize = true;
            this.lbl_OuvertsActuels.Location = new System.Drawing.Point(181, 376);
            this.lbl_OuvertsActuels.Name = "lbl_OuvertsActuels";
            this.lbl_OuvertsActuels.Size = new System.Drawing.Size(81, 26);
            this.lbl_OuvertsActuels.TabIndex = 1;
            this.lbl_OuvertsActuels.Text = "Ouverts actuels\r\n   {0}";
            // 
            // Image_Graphe
            // 
            this.Image_Graphe.Image = global::Partie2.Properties.Resources.Graphe1;
            this.Image_Graphe.Location = new System.Drawing.Point(34, 19);
            this.Image_Graphe.Name = "Image_Graphe";
            this.Image_Graphe.Size = new System.Drawing.Size(784, 337);
            this.Image_Graphe.TabIndex = 10;
            this.Image_Graphe.TabStop = false;
            // 
            // Examen_IA_partie2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 575);
            this.Controls.Add(this.groupeBx_Titre);
            this.Name = "Examen_IA_partie2";
            this.Text = "Examen IA";
            this.groupeBx_Titre.ResumeLayout(false);
            this.groupeBx_Titre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Graphe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

