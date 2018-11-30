namespace Partie2
{
    partial class EvaluationArbre
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
            this.FermesActu_groupeBx = new System.Windows.Forms.GroupBox();
            this.questionSuivante_button = new System.Windows.Forms.Button();
            this.Valider_button = new System.Windows.Forms.Button();
            this.GrapheSolution_treeView = new System.Windows.Forms.TreeView();
            this.GrapheReponse_treeView = new System.Windows.Forms.TreeView();
            this.Solution_groupBox = new System.Windows.Forms.GroupBox();
            this.solutionOuvert_textBox = new System.Windows.Forms.TextBox();
            this.solutionOuvert_label = new System.Windows.Forms.Label();
            this.solutionFerme_label = new System.Windows.Forms.Label();
            this.solutionFerme_textBox = new System.Windows.Forms.TextBox();
            this.NoeudFinal_textBox = new System.Windows.Forms.TextBox();
            this.NoeudInit_textBox = new System.Windows.Forms.TextBox();
            this.NoeudFinal_label = new System.Windows.Forms.Label();
            this.NoeudInit_label = new System.Windows.Forms.Label();
            this.Image_Graphe = new System.Windows.Forms.PictureBox();
            this.FermesActu_groupeBx.SuspendLayout();
            this.Solution_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Graphe)).BeginInit();
            this.SuspendLayout();
            // 
            // FermesActu_groupeBx
            // 
            this.FermesActu_groupeBx.Controls.Add(this.questionSuivante_button);
            this.FermesActu_groupeBx.Controls.Add(this.Valider_button);
            this.FermesActu_groupeBx.Controls.Add(this.GrapheSolution_treeView);
            this.FermesActu_groupeBx.Controls.Add(this.GrapheReponse_treeView);
            this.FermesActu_groupeBx.Controls.Add(this.Solution_groupBox);
            this.FermesActu_groupeBx.Controls.Add(this.NoeudFinal_textBox);
            this.FermesActu_groupeBx.Controls.Add(this.NoeudInit_textBox);
            this.FermesActu_groupeBx.Controls.Add(this.NoeudFinal_label);
            this.FermesActu_groupeBx.Controls.Add(this.NoeudInit_label);
            this.FermesActu_groupeBx.Controls.Add(this.Image_Graphe);
            this.FermesActu_groupeBx.Location = new System.Drawing.Point(12, 13);
            this.FermesActu_groupeBx.Name = "FermesActu_groupeBx";
            this.FermesActu_groupeBx.Size = new System.Drawing.Size(759, 550);
            this.FermesActu_groupeBx.TabIndex = 1;
            this.FermesActu_groupeBx.TabStop = false;
            this.FermesActu_groupeBx.Text = "Dijkstra à la main";
            // 
            // questionSuivante_button
            // 
            this.questionSuivante_button.Location = new System.Drawing.Point(594, 467);
            this.questionSuivante_button.Name = "questionSuivante_button";
            this.questionSuivante_button.Size = new System.Drawing.Size(135, 65);
            this.questionSuivante_button.TabIndex = 22;
            this.questionSuivante_button.Text = "Question suivante";
            this.questionSuivante_button.UseVisualStyleBackColor = true;
            this.questionSuivante_button.Visible = false;
            this.questionSuivante_button.Click += new System.EventHandler(this.questionSuivante_button_Click);
            // 
            // Valider_button
            // 
            this.Valider_button.Location = new System.Drawing.Point(381, 433);
            this.Valider_button.Name = "Valider_button";
            this.Valider_button.Size = new System.Drawing.Size(75, 23);
            this.Valider_button.TabIndex = 21;
            this.Valider_button.Text = "Valider";
            this.Valider_button.UseVisualStyleBackColor = true;
            this.Valider_button.Click += new System.EventHandler(this.Valider_button_Click);
            // 
            // GrapheSolution_treeView
            // 
            this.GrapheSolution_treeView.Location = new System.Drawing.Point(541, 239);
            this.GrapheSolution_treeView.Name = "GrapheSolution_treeView";
            this.GrapheSolution_treeView.Size = new System.Drawing.Size(141, 188);
            this.GrapheSolution_treeView.TabIndex = 20;
            this.GrapheSolution_treeView.Visible = false;
            // 
            // GrapheReponse_treeView
            // 
            this.GrapheReponse_treeView.LabelEdit = true;
            this.GrapheReponse_treeView.Location = new System.Drawing.Point(350, 239);
            this.GrapheReponse_treeView.Name = "GrapheReponse_treeView";
            this.GrapheReponse_treeView.Size = new System.Drawing.Size(141, 188);
            this.GrapheReponse_treeView.TabIndex = 19;
            this.GrapheReponse_treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Graphe_treeView_AfterSelect);
            // 
            // Solution_groupBox
            // 
            this.Solution_groupBox.Controls.Add(this.solutionOuvert_textBox);
            this.Solution_groupBox.Controls.Add(this.solutionOuvert_label);
            this.Solution_groupBox.Controls.Add(this.solutionFerme_label);
            this.Solution_groupBox.Controls.Add(this.solutionFerme_textBox);
            this.Solution_groupBox.Location = new System.Drawing.Point(15, 239);
            this.Solution_groupBox.Name = "Solution_groupBox";
            this.Solution_groupBox.Size = new System.Drawing.Size(234, 188);
            this.Solution_groupBox.TabIndex = 18;
            this.Solution_groupBox.TabStop = false;
            this.Solution_groupBox.Text = "Solution";
            // 
            // solutionOuvert_textBox
            // 
            this.solutionOuvert_textBox.Location = new System.Drawing.Point(19, 45);
            this.solutionOuvert_textBox.Multiline = true;
            this.solutionOuvert_textBox.Name = "solutionOuvert_textBox";
            this.solutionOuvert_textBox.Size = new System.Drawing.Size(84, 126);
            this.solutionOuvert_textBox.TabIndex = 5;
            // 
            // solutionOuvert_label
            // 
            this.solutionOuvert_label.AutoSize = true;
            this.solutionOuvert_label.Location = new System.Drawing.Point(16, 28);
            this.solutionOuvert_label.Name = "solutionOuvert_label";
            this.solutionOuvert_label.Size = new System.Drawing.Size(87, 13);
            this.solutionOuvert_label.TabIndex = 3;
            this.solutionOuvert_label.Text = "Liste des ouverts";
            // 
            // solutionFerme_label
            // 
            this.solutionFerme_label.AutoSize = true;
            this.solutionFerme_label.Location = new System.Drawing.Point(128, 29);
            this.solutionFerme_label.Name = "solutionFerme_label";
            this.solutionFerme_label.Size = new System.Drawing.Size(83, 13);
            this.solutionFerme_label.TabIndex = 4;
            this.solutionFerme_label.Text = "Liste des fermés";
            // 
            // solutionFerme_textBox
            // 
            this.solutionFerme_textBox.Location = new System.Drawing.Point(131, 45);
            this.solutionFerme_textBox.Multiline = true;
            this.solutionFerme_textBox.Name = "solutionFerme_textBox";
            this.solutionFerme_textBox.Size = new System.Drawing.Size(84, 126);
            this.solutionFerme_textBox.TabIndex = 6;
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
            this.Image_Graphe.Image = global::Partie2.Properties.Resources.Graphe11;
            this.Image_Graphe.Location = new System.Drawing.Point(240, 19);
            this.Image_Graphe.Name = "Image_Graphe";
            this.Image_Graphe.Size = new System.Drawing.Size(336, 166);
            this.Image_Graphe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Image_Graphe.TabIndex = 10;
            this.Image_Graphe.TabStop = false;
            // 
            // EvaluationArbre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 573);
            this.Controls.Add(this.FermesActu_groupeBx);
            this.Name = "EvaluationArbre";
            this.Text = "EvaluationArbre";
            this.FermesActu_groupeBx.ResumeLayout(false);
            this.FermesActu_groupeBx.PerformLayout();
            this.Solution_groupBox.ResumeLayout(false);
            this.Solution_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Graphe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FermesActu_groupeBx;
        private System.Windows.Forms.GroupBox Solution_groupBox;
        private System.Windows.Forms.TextBox solutionOuvert_textBox;
        private System.Windows.Forms.Label solutionOuvert_label;
        private System.Windows.Forms.Label solutionFerme_label;
        private System.Windows.Forms.TextBox solutionFerme_textBox;
        private System.Windows.Forms.TextBox NoeudFinal_textBox;
        private System.Windows.Forms.TextBox NoeudInit_textBox;
        private System.Windows.Forms.Label NoeudFinal_label;
        private System.Windows.Forms.Label NoeudInit_label;
        private System.Windows.Forms.PictureBox Image_Graphe;
        private System.Windows.Forms.TreeView GrapheReponse_treeView;
        private System.Windows.Forms.TreeView GrapheSolution_treeView;
        private System.Windows.Forms.Button Valider_button;
        private System.Windows.Forms.Button questionSuivante_button;
    }
}