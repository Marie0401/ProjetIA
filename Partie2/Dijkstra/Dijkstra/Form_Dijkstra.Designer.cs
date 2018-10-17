namespace Dijkstra
{
    partial class Form_Dijkstra
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
            this.btn_InitGrapheDefaut = new System.Windows.Forms.Button();
            this.btn_InitGrapheFichier = new System.Windows.Forms.Button();
            this.btn_RechercheCheminLPCourt = new System.Windows.Forms.Button();
            this.lbl_NoeudInit = new System.Windows.Forms.Label();
            this.lbl_NoeudFinal = new System.Windows.Forms.Label();
            this.txtbx_NoeudInit = new System.Windows.Forms.TextBox();
            this.txtbx_NoeudFinal = new System.Windows.Forms.TextBox();
            this.lstbx_AffichageGrapheFichier = new System.Windows.Forms.ListBox();
            this.listBox_AffichageChemin = new System.Windows.Forms.ListBox();
            this.listBox_AffichageArbre = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_InitGrapheDefaut
            // 
            this.btn_InitGrapheDefaut.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_InitGrapheDefaut.Location = new System.Drawing.Point(35, 39);
            this.btn_InitGrapheDefaut.Name = "btn_InitGrapheDefaut";
            this.btn_InitGrapheDefaut.Size = new System.Drawing.Size(110, 47);
            this.btn_InitGrapheDefaut.TabIndex = 0;
            this.btn_InitGrapheDefaut.Text = "Initialisation par défaut";
            this.btn_InitGrapheDefaut.UseVisualStyleBackColor = true;
            this.btn_InitGrapheDefaut.Click += new System.EventHandler(this.btn_InitGrapheDefaut_Click);
            // 
            // btn_InitGrapheFichier
            // 
            this.btn_InitGrapheFichier.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_InitGrapheFichier.Location = new System.Drawing.Point(161, 39);
            this.btn_InitGrapheFichier.Name = "btn_InitGrapheFichier";
            this.btn_InitGrapheFichier.Size = new System.Drawing.Size(110, 47);
            this.btn_InitGrapheFichier.TabIndex = 1;
            this.btn_InitGrapheFichier.Text = "Initialisation à partir du fichier";
            this.btn_InitGrapheFichier.UseVisualStyleBackColor = true;
            this.btn_InitGrapheFichier.Click += new System.EventHandler(this.btn_InitGrapheFichier_Click);
            // 
            // btn_RechercheCheminLPCourt
            // 
            this.btn_RechercheCheminLPCourt.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_RechercheCheminLPCourt.Location = new System.Drawing.Point(493, 39);
            this.btn_RechercheCheminLPCourt.Name = "btn_RechercheCheminLPCourt";
            this.btn_RechercheCheminLPCourt.Size = new System.Drawing.Size(110, 47);
            this.btn_RechercheCheminLPCourt.TabIndex = 2;
            this.btn_RechercheCheminLPCourt.Text = "A* ";
            this.btn_RechercheCheminLPCourt.UseVisualStyleBackColor = true;
            this.btn_RechercheCheminLPCourt.Click += new System.EventHandler(this.btn_RechercheCheminLPCourt_Click);
            // 
            // lbl_NoeudInit
            // 
            this.lbl_NoeudInit.AutoSize = true;
            this.lbl_NoeudInit.Location = new System.Drawing.Point(32, 113);
            this.lbl_NoeudInit.Name = "lbl_NoeudInit";
            this.lbl_NoeudInit.Size = new System.Drawing.Size(71, 13);
            this.lbl_NoeudInit.TabIndex = 3;
            this.lbl_NoeudInit.Text = "Noeud initial :";
            // 
            // lbl_NoeudFinal
            // 
            this.lbl_NoeudFinal.AutoSize = true;
            this.lbl_NoeudFinal.Location = new System.Drawing.Point(32, 135);
            this.lbl_NoeudFinal.Name = "lbl_NoeudFinal";
            this.lbl_NoeudFinal.Size = new System.Drawing.Size(88, 13);
            this.lbl_NoeudFinal.TabIndex = 4;
            this.lbl_NoeudFinal.Text = "Noeud d\'arrivée :";
            // 
            // txtbx_NoeudInit
            // 
            this.txtbx_NoeudInit.Location = new System.Drawing.Point(146, 110);
            this.txtbx_NoeudInit.Name = "txtbx_NoeudInit";
            this.txtbx_NoeudInit.Size = new System.Drawing.Size(100, 20);
            this.txtbx_NoeudInit.TabIndex = 5;
            // 
            // txtbx_NoeudFinal
            // 
            this.txtbx_NoeudFinal.Location = new System.Drawing.Point(146, 136);
            this.txtbx_NoeudFinal.Name = "txtbx_NoeudFinal";
            this.txtbx_NoeudFinal.Size = new System.Drawing.Size(100, 20);
            this.txtbx_NoeudFinal.TabIndex = 6;
            // 
            // lstbx_AffichageGrapheFichier
            // 
            this.lstbx_AffichageGrapheFichier.FormattingEnabled = true;
            this.lstbx_AffichageGrapheFichier.Location = new System.Drawing.Point(53, 185);
            this.lstbx_AffichageGrapheFichier.Name = "lstbx_AffichageGrapheFichier";
            this.lstbx_AffichageGrapheFichier.Size = new System.Drawing.Size(114, 134);
            this.lstbx_AffichageGrapheFichier.TabIndex = 7;
            // 
            // listBox_AffichageChemin
            // 
            this.listBox_AffichageChemin.FormattingEnabled = true;
            this.listBox_AffichageChemin.Location = new System.Drawing.Point(240, 185);
            this.listBox_AffichageChemin.Name = "listBox_AffichageChemin";
            this.listBox_AffichageChemin.Size = new System.Drawing.Size(143, 134);
            this.listBox_AffichageChemin.TabIndex = 8;
            // 
            // listBox_AffichageArbre
            // 
            this.listBox_AffichageArbre.FormattingEnabled = true;
            this.listBox_AffichageArbre.Location = new System.Drawing.Point(477, 185);
            this.listBox_AffichageArbre.Name = "listBox_AffichageArbre";
            this.listBox_AffichageArbre.Size = new System.Drawing.Size(143, 134);
            this.listBox_AffichageArbre.TabIndex = 9;
            // 
            // Form_Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 418);
            this.Controls.Add(this.listBox_AffichageArbre);
            this.Controls.Add(this.listBox_AffichageChemin);
            this.Controls.Add(this.lstbx_AffichageGrapheFichier);
            this.Controls.Add(this.txtbx_NoeudFinal);
            this.Controls.Add(this.txtbx_NoeudInit);
            this.Controls.Add(this.lbl_NoeudFinal);
            this.Controls.Add(this.lbl_NoeudInit);
            this.Controls.Add(this.btn_RechercheCheminLPCourt);
            this.Controls.Add(this.btn_InitGrapheFichier);
            this.Controls.Add(this.btn_InitGrapheDefaut);
            this.Name = "Form_Dijkstra";
            this.Text = "Formulaire Dijkstra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_InitGrapheDefaut;
        private System.Windows.Forms.Button btn_InitGrapheFichier;
        private System.Windows.Forms.Button btn_RechercheCheminLPCourt;
        private System.Windows.Forms.Label lbl_NoeudInit;
        private System.Windows.Forms.Label lbl_NoeudFinal;
        private System.Windows.Forms.TextBox txtbx_NoeudInit;
        private System.Windows.Forms.TextBox txtbx_NoeudFinal;
        private System.Windows.Forms.ListBox lstbx_AffichageGrapheFichier;
        private System.Windows.Forms.ListBox listBox_AffichageChemin;
        private System.Windows.Forms.ListBox listBox_AffichageArbre;
    }
}

