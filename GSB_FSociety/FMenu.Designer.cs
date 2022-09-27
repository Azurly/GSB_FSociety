namespace GSB_FSociety
{
    partial class FMenu
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
            this.buttonMission1 = new System.Windows.Forms.Button();
            this.buttonMission2 = new System.Windows.Forms.Button();
            this.buttonMission3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMission1
            // 
            this.buttonMission1.Location = new System.Drawing.Point(62, 28);
            this.buttonMission1.Name = "buttonMission1";
            this.buttonMission1.Size = new System.Drawing.Size(75, 23);
            this.buttonMission1.TabIndex = 5;
            this.buttonMission1.Text = "Mission 1";
            this.buttonMission1.UseVisualStyleBackColor = true;
            this.buttonMission1.Click += new System.EventHandler(this.buttonMission1_Click);
            // 
            // buttonMission2
            // 
            this.buttonMission2.Location = new System.Drawing.Point(62, 67);
            this.buttonMission2.Name = "buttonMission2";
            this.buttonMission2.Size = new System.Drawing.Size(75, 23);
            this.buttonMission2.TabIndex = 6;
            this.buttonMission2.Text = "Mission 2";
            this.buttonMission2.UseVisualStyleBackColor = true;
            this.buttonMission2.Click += new System.EventHandler(this.buttonMission2_Click);
            // 
            // buttonMission3
            // 
            this.buttonMission3.Location = new System.Drawing.Point(62, 106);
            this.buttonMission3.Name = "buttonMission3";
            this.buttonMission3.Size = new System.Drawing.Size(75, 23);
            this.buttonMission3.TabIndex = 7;
            this.buttonMission3.Text = "Mission 3";
            this.buttonMission3.UseVisualStyleBackColor = true;
            this.buttonMission3.Click += new System.EventHandler(this.buttonMission3_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 161);
            this.Controls.Add(this.buttonMission3);
            this.Controls.Add(this.buttonMission2);
            this.Controls.Add(this.buttonMission1);
            this.Name = "FMenu";
            this.Text = "FMenu";
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMission1;
        private System.Windows.Forms.Button buttonMission2;
        private System.Windows.Forms.Button buttonMission3;
    }
}

