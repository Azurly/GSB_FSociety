namespace GSB_FSociety
{
    partial class FM2Rapport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbxMotif = new System.Windows.Forms.ComboBox();
            this.BtnValider = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.RtbBilan = new System.Windows.Forms.RichTextBox();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.BSRapport = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMedicament = new System.Windows.Forms.DataGridView();
            this.dgvMedecin = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CbxMotif);
            this.panel1.Controls.Add(this.BtnValider);
            this.panel1.Controls.Add(this.BtnAnnuler);
            this.panel1.Controls.Add(this.RtbBilan);
            this.panel1.Controls.Add(this.DtpDate);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 426);
            this.panel1.TabIndex = 4;
            // 
            // CbxMotif
            // 
            this.CbxMotif.FormattingEnabled = true;
            this.CbxMotif.Location = new System.Drawing.Point(59, 54);
            this.CbxMotif.Name = "CbxMotif";
            this.CbxMotif.Size = new System.Drawing.Size(200, 21);
            this.CbxMotif.TabIndex = 10;
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(59, 400);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(75, 23);
            this.BtnValider.TabIndex = 5;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(140, 400);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnuler.TabIndex = 6;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            // 
            // RtbBilan
            // 
            this.RtbBilan.Location = new System.Drawing.Point(59, 104);
            this.RtbBilan.Name = "RtbBilan";
            this.RtbBilan.Size = new System.Drawing.Size(429, 138);
            this.RtbBilan.TabIndex = 9;
            this.RtbBilan.Text = "";
            // 
            // DtpDate
            // 
            this.DtpDate.Location = new System.Drawing.Point(59, 15);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(200, 20);
            this.DtpDate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Motif :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bilan :";
            // 
            // dgvMedicament
            // 
            this.dgvMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicament.Location = new System.Drawing.Point(637, 27);
            this.dgvMedicament.Name = "dgvMedicament";
            this.dgvMedicament.Size = new System.Drawing.Size(385, 149);
            this.dgvMedicament.TabIndex = 11;
            // 
            // dgvMedecin
            // 
            this.dgvMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedecin.Location = new System.Drawing.Point(637, 204);
            this.dgvMedecin.Name = "dgvMedecin";
            this.dgvMedecin.Size = new System.Drawing.Size(385, 150);
            this.dgvMedecin.TabIndex = 12;
            // 
            // FM2Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 564);
            this.Controls.Add(this.dgvMedecin);
            this.Controls.Add(this.dgvMedicament);
            this.Controls.Add(this.panel1);
            this.Name = "FM2Rapport";
            this.Text = "FM2Rapport";
            this.Load += new System.EventHandler(this.FM2Rapport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox RtbBilan;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.ComboBox CbxMotif;
        private System.Windows.Forms.BindingSource BSRapport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMedicament;
        private System.Windows.Forms.DataGridView dgvMedecin;
    }
}