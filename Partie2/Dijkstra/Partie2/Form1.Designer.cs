namespace Partie2
{
    partial class Form1
    {
        private System.Windows.Forms.GroupBox groupeBx_Titre;
        private System.Windows.Forms.Label lbl_OuvertsActuels;
        private System.Windows.Forms.Label lbl_FermesActuels;
        private System.Windows.Forms.Label lbl_OuvertsSuivants;
        private System.Windows.Forms.Label lbl_FermesSuivants;
        private System.Windows.Forms.TextBox txtBox_ListeFermes;
        private System.Windows.Forms.TextBox txtBox_ListeOuverts;
        private System.Windows.Forms.PictureBox Image_Graphe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_ListeFermesPrecedents;
        private System.Windows.Forms.TextBox xtBox_ListeOuvertsPrecedents;

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
            this.Image_Graphe = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox_ListeFermesPrecedents = new System.Windows.Forms.TextBox();
            this.xtBox_ListeOuvertsPrecedents = new System.Windows.Forms.TextBox();
            this.txtBox_ListeFermes = new System.Windows.Forms.TextBox();
            this.txtBox_ListeOuverts = new System.Windows.Forms.TextBox();
            this.lbl_FermesSuivants = new System.Windows.Forms.Label();
            this.lbl_OuvertsSuivants = new System.Windows.Forms.Label();
            this.lbl_FermesActuels = new System.Windows.Forms.Label();
            this.lbl_OuvertsActuels = new System.Windows.Forms.Label();
            this.groupeBx_Titre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Graphe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupeBx_Titre
            // 
            this.groupeBx_Titre.Controls.Add(this.Image_Graphe);
            this.groupeBx_Titre.Controls.Add(this.button1);
            this.groupeBx_Titre.Controls.Add(this.txtBox_ListeFermesPrecedents);
            this.groupeBx_Titre.Controls.Add(this.xtBox_ListeOuvertsPrecedents);
            this.groupeBx_Titre.Controls.Add(this.txtBox_ListeFermes);
            this.groupeBx_Titre.Controls.Add(this.txtBox_ListeOuverts);
            this.groupeBx_Titre.Controls.Add(this.lbl_FermesSuivants);
            this.groupeBx_Titre.Controls.Add(this.lbl_OuvertsSuivants);
            this.groupeBx_Titre.Controls.Add(this.lbl_FermesActuels);
            this.groupeBx_Titre.Controls.Add(this.lbl_OuvertsActuels);
            this.groupeBx_Titre.Location = new System.Drawing.Point(12, 12);
            this.groupeBx_Titre.Name = "groupeBx_Titre";
            this.groupeBx_Titre.Size = new System.Drawing.Size(863, 550);
            this.groupeBx_Titre.TabIndex = 0;
            this.groupeBx_Titre.TabStop = false;
            this.groupeBx_Titre.Text = "Dijkstra à la main";
            // 
            // Image_Graphe
            // 
            this.Image_Graphe.Image = global::Partie2.Properties.Resources.Graphe1;
            this.Image_Graphe.Location = new System.Drawing.Point(34, 19);
            this.Image_Graphe.Name = "Image_Graphe";
            this.Image_Graphe.Size = new System.Drawing.Size(805, 339);
            this.Image_Graphe.TabIndex = 10;
            this.Image_Graphe.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBox_ListeFermesPrecedents
            // 
            this.txtBox_ListeFermesPrecedents.Location = new System.Drawing.Point(493, 396);
            this.txtBox_ListeFermesPrecedents.Name = "txtBox_ListeFermesPrecedents";
            this.txtBox_ListeFermesPrecedents.Size = new System.Drawing.Size(198, 20);
            this.txtBox_ListeFermesPrecedents.TabIndex = 8;
            this.txtBox_ListeFermesPrecedents.Text = "{}";
            // 
            // xtBox_ListeOuvertsPrecedents
            // 
            this.xtBox_ListeOuvertsPrecedents.Location = new System.Drawing.Point(204, 396);
            this.xtBox_ListeOuvertsPrecedents.Name = "xtBox_ListeOuvertsPrecedents";
            this.xtBox_ListeOuvertsPrecedents.Size = new System.Drawing.Size(198, 20);
            this.xtBox_ListeOuvertsPrecedents.TabIndex = 7;
            this.xtBox_ListeOuvertsPrecedents.Text = "{0}";
            // 
            // txtBox_ListeFermes
            // 
            this.txtBox_ListeFermes.Location = new System.Drawing.Point(493, 477);
            this.txtBox_ListeFermes.Name = "txtBox_ListeFermes";
            this.txtBox_ListeFermes.Size = new System.Drawing.Size(198, 20);
            this.txtBox_ListeFermes.TabIndex = 6;
            // 
            // txtBox_ListeOuverts
            // 
            this.txtBox_ListeOuverts.Location = new System.Drawing.Point(204, 477);
            this.txtBox_ListeOuverts.Name = "txtBox_ListeOuverts";
            this.txtBox_ListeOuverts.Size = new System.Drawing.Size(198, 20);
            this.txtBox_ListeOuverts.TabIndex = 5;
            // 
            // lbl_FermesSuivants
            // 
            this.lbl_FermesSuivants.AutoSize = true;
            this.lbl_FermesSuivants.Location = new System.Drawing.Point(490, 460);
            this.lbl_FermesSuivants.Name = "lbl_FermesSuivants";
            this.lbl_FermesSuivants.Size = new System.Drawing.Size(83, 13);
            this.lbl_FermesSuivants.TabIndex = 4;
            this.lbl_FermesSuivants.Text = "Fermés suivants";
            // 
            // lbl_OuvertsSuivants
            // 
            this.lbl_OuvertsSuivants.AutoSize = true;
            this.lbl_OuvertsSuivants.Location = new System.Drawing.Point(201, 460);
            this.lbl_OuvertsSuivants.Name = "lbl_OuvertsSuivants";
            this.lbl_OuvertsSuivants.Size = new System.Drawing.Size(86, 13);
            this.lbl_OuvertsSuivants.TabIndex = 3;
            this.lbl_OuvertsSuivants.Text = "Ouverts suivants";
            // 
            // lbl_FermesActuels
            // 
            this.lbl_FermesActuels.AutoSize = true;
            this.lbl_FermesActuels.Location = new System.Drawing.Point(490, 380);
            this.lbl_FermesActuels.Name = "lbl_FermesActuels";
            this.lbl_FermesActuels.Size = new System.Drawing.Size(78, 13);
            this.lbl_FermesActuels.TabIndex = 2;
            this.lbl_FermesActuels.Text = "Fermés actuels";
            // 
            // lbl_OuvertsActuels
            // 
            this.lbl_OuvertsActuels.AutoSize = true;
            this.lbl_OuvertsActuels.Location = new System.Drawing.Point(201, 380);
            this.lbl_OuvertsActuels.Name = "lbl_OuvertsActuels";
            this.lbl_OuvertsActuels.Size = new System.Drawing.Size(81, 13);
            this.lbl_OuvertsActuels.TabIndex = 1;
            this.lbl_OuvertsActuels.Text = "Ouverts actuels";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 575);
            this.Controls.Add(this.groupeBx_Titre);
            this.Name = "Form1";
            this.Text = "Examen IA";
            this.groupeBx_Titre.ResumeLayout(false);
            this.groupeBx_Titre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Graphe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

