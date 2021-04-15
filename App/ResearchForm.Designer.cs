
namespace App
{
    partial class ResearchForm
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
            this.dgvRecherche = new System.Windows.Forms.DataGridView();
            this.labRecherche = new System.Windows.Forms.Label();
            this.txtMotCle = new System.Windows.Forms.TextBox();
            this.labCritere = new System.Windows.Forms.Label();
            this.txtCritere = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecherche)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecherche
            // 
            this.dgvRecherche.AllowUserToAddRows = false;
            this.dgvRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecherche.Location = new System.Drawing.Point(35, 105);
            this.dgvRecherche.Name = "dgvRecherche";
            this.dgvRecherche.ReadOnly = true;
            this.dgvRecherche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecherche.Size = new System.Drawing.Size(343, 150);
            this.dgvRecherche.TabIndex = 0;
            // 
            // labRecherche
            // 
            this.labRecherche.AutoSize = true;
            this.labRecherche.Location = new System.Drawing.Point(32, 27);
            this.labRecherche.Name = "labRecherche";
            this.labRecherche.Size = new System.Drawing.Size(129, 13);
            this.labRecherche.TabIndex = 1;
            this.labRecherche.Text = "Résultat de la recherche :";
            // 
            // txtMotCle
            // 
            this.txtMotCle.Enabled = false;
            this.txtMotCle.Location = new System.Drawing.Point(167, 24);
            this.txtMotCle.Name = "txtMotCle";
            this.txtMotCle.Size = new System.Drawing.Size(100, 20);
            this.txtMotCle.TabIndex = 2;
            // 
            // labCritere
            // 
            this.labCritere.AutoSize = true;
            this.labCritere.Location = new System.Drawing.Point(123, 57);
            this.labCritere.Name = "labCritere";
            this.labCritere.Size = new System.Drawing.Size(38, 13);
            this.labCritere.TabIndex = 3;
            this.labCritere.Text = "Dans :";
            // 
            // txtCritere
            // 
            this.txtCritere.Enabled = false;
            this.txtCritere.Location = new System.Drawing.Point(168, 57);
            this.txtCritere.Name = "txtCritere";
            this.txtCritere.Size = new System.Drawing.Size(100, 20);
            this.txtCritere.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(86, 296);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Valider";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(209, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ResearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 359);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtCritere);
            this.Controls.Add(this.labCritere);
            this.Controls.Add(this.txtMotCle);
            this.Controls.Add(this.labRecherche);
            this.Controls.Add(this.dgvRecherche);
            this.Name = "ResearchForm";
            this.Text = "Résultat de la recherche";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecherche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecherche;
        private System.Windows.Forms.Label labRecherche;
        private System.Windows.Forms.TextBox txtMotCle;
        private System.Windows.Forms.Label labCritere;
        private System.Windows.Forms.TextBox txtCritere;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}