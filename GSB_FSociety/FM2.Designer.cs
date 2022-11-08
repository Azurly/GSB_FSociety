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
            this.dgvRapport = new System.Windows.Forms.DataGridView();
            this.btnAjouterRapport = new System.Windows.Forms.Button();
            this.btnModifierRapport = new System.Windows.Forms.Button();
            this.btnSupprimerRapport = new System.Windows.Forms.Button();
            this.btnVisualiser = new System.Windows.Forms.Button();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRapport
            // 
            this.dgvRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapport.Location = new System.Drawing.Point(12, 60);
            this.dgvRapport.Name = "dgvRapport";
            this.dgvRapport.Size = new System.Drawing.Size(776, 339);
            this.dgvRapport.TabIndex = 1;
            // 
            // btnAjouterRapport
            // 
            this.btnAjouterRapport.Location = new System.Drawing.Point(12, 405);
            this.btnAjouterRapport.Name = "btnAjouterRapport";
            this.btnAjouterRapport.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterRapport.TabIndex = 2;
            this.btnAjouterRapport.Text = "Ajouter";
            this.btnAjouterRapport.UseVisualStyleBackColor = true;
            this.btnAjouterRapport.Click += new System.EventHandler(this.btnAjouterRapport_Click);
            // 
            // btnModifierRapport
            // 
            this.btnModifierRapport.Location = new System.Drawing.Point(93, 405);
            this.btnModifierRapport.Name = "btnModifierRapport";
            this.btnModifierRapport.Size = new System.Drawing.Size(75, 23);
            this.btnModifierRapport.TabIndex = 3;
            this.btnModifierRapport.Text = "Modifier";
            this.btnModifierRapport.UseVisualStyleBackColor = true;
            this.btnModifierRapport.Click += new System.EventHandler(this.btnModifierRapport_Click);
            // 
            // btnSupprimerRapport
            // 
            this.btnSupprimerRapport.ForeColor = System.Drawing.Color.Red;
            this.btnSupprimerRapport.Location = new System.Drawing.Point(713, 405);
            this.btnSupprimerRapport.Name = "btnSupprimerRapport";
            this.btnSupprimerRapport.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerRapport.TabIndex = 4;
            this.btnSupprimerRapport.Text = "Supprimer";
            this.btnSupprimerRapport.UseVisualStyleBackColor = true;
            this.btnSupprimerRapport.Click += new System.EventHandler(this.btnSupprimerRapport_Click);
            // 
            // btnVisualiser
            // 
            this.btnVisualiser.Location = new System.Drawing.Point(174, 405);
            this.btnVisualiser.Name = "btnVisualiser";
            this.btnVisualiser.Size = new System.Drawing.Size(75, 23);
            this.btnVisualiser.TabIndex = 5;
            this.btnVisualiser.Text = "Visualiser";
            this.btnVisualiser.UseVisualStyleBackColor = true;
            this.btnVisualiser.Click += new System.EventHandler(this.btnVisualiser_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // FM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnVisualiser);
            this.Controls.Add(this.btnSupprimerRapport);
            this.Controls.Add(this.btnModifierRapport);
            this.Controls.Add(this.btnAjouterRapport);
            this.Controls.Add(this.dgvRapport);
            this.Name = "FM2";
            this.Text = "FM2";
            this.Load += new System.EventHandler(this.FM2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRapport;
        private System.Windows.Forms.BindingSource bsRapport;
        private System.Windows.Forms.Button btnAjouterRapport;
        private System.Windows.Forms.Button btnModifierRapport;
        private System.Windows.Forms.Button btnSupprimerRapport;
        private System.Windows.Forms.Button btnVisualiser;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}