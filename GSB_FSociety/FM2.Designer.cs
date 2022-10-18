namespace GSB_FSociety
{
    partial class FM2
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visiteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RapportTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRapport = new System.Windows.Forms.DataGridView();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjouterRapport = new System.Windows.Forms.Button();
            this.btnModifierRapport = new System.Windows.Forms.Button();
            this.btnSupprimerRapport = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visiteurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visiteurToolStripMenuItem
            // 
            this.visiteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RapportTSMI});
            this.visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            this.visiteurToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.visiteurToolStripMenuItem.Text = "Visiteur";
            // 
            // RapportTSMI
            // 
            this.RapportTSMI.Name = "RapportTSMI";
            this.RapportTSMI.Size = new System.Drawing.Size(180, 22);
            this.RapportTSMI.Text = "Rediger un rapport";
            this.RapportTSMI.Click += new System.EventHandler(this.RapportTSMI_Click);
            // 
            // dgvRapport
            // 
            this.dgvRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapport.Location = new System.Drawing.Point(12, 27);
            this.dgvRapport.Name = "dgvRapport";
            this.dgvRapport.Size = new System.Drawing.Size(776, 339);
            this.dgvRapport.TabIndex = 1;
            // 
            // btnAjouterRapport
            // 
            this.btnAjouterRapport.Location = new System.Drawing.Point(12, 372);
            this.btnAjouterRapport.Name = "btnAjouterRapport";
            this.btnAjouterRapport.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterRapport.TabIndex = 2;
            this.btnAjouterRapport.Text = "Ajouter";
            this.btnAjouterRapport.UseVisualStyleBackColor = true;
            this.btnAjouterRapport.Click += new System.EventHandler(this.btnAjouterRapport_Click);
            // 
            // btnModifierRapport
            // 
            this.btnModifierRapport.Location = new System.Drawing.Point(93, 372);
            this.btnModifierRapport.Name = "btnModifierRapport";
            this.btnModifierRapport.Size = new System.Drawing.Size(75, 23);
            this.btnModifierRapport.TabIndex = 3;
            this.btnModifierRapport.Text = "Modifier";
            this.btnModifierRapport.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerRapport
            // 
            this.btnSupprimerRapport.Location = new System.Drawing.Point(713, 372);
            this.btnSupprimerRapport.Name = "btnSupprimerRapport";
            this.btnSupprimerRapport.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerRapport.TabIndex = 4;
            this.btnSupprimerRapport.Text = "Supprimer";
            this.btnSupprimerRapport.UseVisualStyleBackColor = true;
            // 
            // FM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimerRapport);
            this.Controls.Add(this.btnModifierRapport);
            this.Controls.Add(this.btnAjouterRapport);
            this.Controls.Add(this.dgvRapport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FM2";
            this.Text = "FM2";
            this.Load += new System.EventHandler(this.FM2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RapportTSMI;
        private System.Windows.Forms.DataGridView dgvRapport;
        private System.Windows.Forms.BindingSource bsRapport;
        private System.Windows.Forms.Button btnAjouterRapport;
        private System.Windows.Forms.Button btnModifierRapport;
        private System.Windows.Forms.Button btnSupprimerRapport;
    }
}