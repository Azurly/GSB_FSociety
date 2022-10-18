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
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMedicamentPresenter = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMedecin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.BtnValider = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.RtbBilan = new System.Windows.Forms.RichTextBox();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.bsMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.bsMotif = new System.Windows.Forms.BindingSource(this.components);
            this.lbltest = new System.Windows.Forms.Label();
            this.trackBarConfiance = new System.Windows.Forms.TrackBar();
            this.lblConfiance = new System.Windows.Forms.Label();
            this.lblConfianceValue = new System.Windows.Forms.Label();
            this.tcMedicament = new System.Windows.Forms.TabControl();
            this.tpPresenter = new System.Windows.Forms.TabPage();
            this.tpOffrir = new System.Windows.Forms.TabPage();
            this.checkBoxRemplacent = new System.Windows.Forms.CheckBox();
            this.tbRemplacent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMedicamentOffrir = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentPresenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarConfiance)).BeginInit();
            this.tcMedicament.SuspendLayout();
            this.tpPresenter.SuspendLayout();
            this.tpOffrir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentOffrir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbRemplacent);
            this.panel1.Controls.Add(this.checkBoxRemplacent);
            this.panel1.Controls.Add(this.tcMedicament);
            this.panel1.Controls.Add(this.lblConfianceValue);
            this.panel1.Controls.Add(this.lblConfiance);
            this.panel1.Controls.Add(this.trackBarConfiance);
            this.panel1.Controls.Add(this.lbltest);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxMedecin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxMotif);
            this.panel1.Controls.Add(this.BtnValider);
            this.panel1.Controls.Add(this.BtnAnnuler);
            this.panel1.Controls.Add(this.RtbBilan);
            this.panel1.Controls.Add(this.DtpDate);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 540);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Medicament :";
            // 
            // dgvMedicamentPresenter
            // 
            this.dgvMedicamentPresenter.AllowUserToOrderColumns = true;
            this.dgvMedicamentPresenter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentPresenter.Location = new System.Drawing.Point(6, 3);
            this.dgvMedicamentPresenter.Name = "dgvMedicamentPresenter";
            this.dgvMedicamentPresenter.Size = new System.Drawing.Size(648, 322);
            this.dgvMedicamentPresenter.TabIndex = 11;
            this.dgvMedicamentPresenter.CurrentCellChanged += new System.EventHandler(this.dgvMedicament_CurrentCellChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Medecin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bilan :";
            // 
            // cbxMedecin
            // 
            this.cbxMedecin.FormattingEnabled = true;
            this.cbxMedecin.Location = new System.Drawing.Point(74, 54);
            this.cbxMedecin.Name = "cbxMedecin";
            this.cbxMedecin.Size = new System.Drawing.Size(200, 21);
            this.cbxMedecin.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Motif :";
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(74, 119);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(200, 21);
            this.cbxMotif.TabIndex = 10;
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
            this.RtbBilan.Location = new System.Drawing.Point(59, 222);
            this.RtbBilan.Name = "RtbBilan";
            this.RtbBilan.Size = new System.Drawing.Size(373, 138);
            this.RtbBilan.TabIndex = 9;
            this.RtbBilan.Text = "";
            // 
            // DtpDate
            // 
            this.DtpDate.Location = new System.Drawing.Point(74, 13);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(200, 20);
            this.DtpDate.TabIndex = 7;
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(361, 477);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(35, 13);
            this.lbltest.TabIndex = 15;
            this.lbltest.Text = "label5";
            // 
            // trackBarConfiance
            // 
            this.trackBarConfiance.Location = new System.Drawing.Point(59, 178);
            this.trackBarConfiance.Name = "trackBarConfiance";
            this.trackBarConfiance.Size = new System.Drawing.Size(256, 45);
            this.trackBarConfiance.TabIndex = 16;
            // 
            // lblConfiance
            // 
            this.lblConfiance.AutoSize = true;
            this.lblConfiance.Location = new System.Drawing.Point(56, 162);
            this.lblConfiance.Name = "lblConfiance";
            this.lblConfiance.Size = new System.Drawing.Size(169, 13);
            this.lblConfiance.TabIndex = 17;
            this.lblConfiance.Text = "niveau de Confiance du medecin :";
            // 
            // lblConfianceValue
            // 
            this.lblConfianceValue.AutoSize = true;
            this.lblConfianceValue.Location = new System.Drawing.Point(231, 162);
            this.lblConfianceValue.Name = "lblConfianceValue";
            this.lblConfianceValue.Size = new System.Drawing.Size(13, 13);
            this.lblConfianceValue.TabIndex = 18;
            this.lblConfianceValue.Text = "0";
            // 
            // tcMedicament
            // 
            this.tcMedicament.Controls.Add(this.tpPresenter);
            this.tcMedicament.Controls.Add(this.tpOffrir);
            this.tcMedicament.Location = new System.Drawing.Point(443, 3);
            this.tcMedicament.Name = "tcMedicament";
            this.tcMedicament.SelectedIndex = 0;
            this.tcMedicament.Size = new System.Drawing.Size(668, 390);
            this.tcMedicament.TabIndex = 19;
            // 
            // tpPresenter
            // 
            this.tpPresenter.Controls.Add(this.dgvMedicamentPresenter);
            this.tpPresenter.Location = new System.Drawing.Point(4, 22);
            this.tpPresenter.Name = "tpPresenter";
            this.tpPresenter.Padding = new System.Windows.Forms.Padding(3);
            this.tpPresenter.Size = new System.Drawing.Size(660, 364);
            this.tpPresenter.TabIndex = 0;
            this.tpPresenter.Text = "Présenter";
            this.tpPresenter.UseVisualStyleBackColor = true;
            // 
            // tpOffrir
            // 
            this.tpOffrir.Controls.Add(this.dgvMedicamentOffrir);
            this.tpOffrir.Location = new System.Drawing.Point(4, 22);
            this.tpOffrir.Name = "tpOffrir";
            this.tpOffrir.Padding = new System.Windows.Forms.Padding(3);
            this.tpOffrir.Size = new System.Drawing.Size(660, 364);
            this.tpOffrir.TabIndex = 1;
            this.tpOffrir.Text = "Offrir";
            this.tpOffrir.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemplacent
            // 
            this.checkBoxRemplacent.AutoSize = true;
            this.checkBoxRemplacent.Location = new System.Drawing.Point(280, 58);
            this.checkBoxRemplacent.Name = "checkBoxRemplacent";
            this.checkBoxRemplacent.Size = new System.Drawing.Size(83, 17);
            this.checkBoxRemplacent.TabIndex = 0;
            this.checkBoxRemplacent.Text = "Remplacent";
            this.checkBoxRemplacent.UseVisualStyleBackColor = true;
            this.checkBoxRemplacent.CheckedChanged += new System.EventHandler(this.checkBoxRemplacent_CheckedChanged);
            // 
            // tbRemplacent
            // 
            this.tbRemplacent.Location = new System.Drawing.Point(74, 81);
            this.tbRemplacent.Name = "tbRemplacent";
            this.tbRemplacent.Size = new System.Drawing.Size(200, 20);
            this.tbRemplacent.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Remplacent :";
            // 
            // dgvMedicamentOffrir
            // 
            this.dgvMedicamentOffrir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentOffrir.Location = new System.Drawing.Point(6, 6);
            this.dgvMedicamentOffrir.Name = "dgvMedicamentOffrir";
            this.dgvMedicamentOffrir.Size = new System.Drawing.Size(648, 319);
            this.dgvMedicamentOffrir.TabIndex = 22;
            // 
            // FM2Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 564);
            this.Controls.Add(this.panel1);
            this.Name = "FM2Rapport";
            this.Text = "FM2Rapport";
            this.Load += new System.EventHandler(this.FM2Rapport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentPresenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarConfiance)).EndInit();
            this.tcMedicament.ResumeLayout(false);
            this.tpPresenter.ResumeLayout(false);
            this.tpOffrir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentOffrir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox RtbBilan;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.BindingSource bsMedecin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMedicamentPresenter;
        private System.Windows.Forms.ComboBox cbxMedecin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bsMotif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.TabControl tcMedicament;
        private System.Windows.Forms.TabPage tpPresenter;
        private System.Windows.Forms.TabPage tpOffrir;
        private System.Windows.Forms.Label lblConfianceValue;
        private System.Windows.Forms.Label lblConfiance;
        private System.Windows.Forms.TrackBar trackBarConfiance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRemplacent;
        private System.Windows.Forms.CheckBox checkBoxRemplacent;
        private System.Windows.Forms.DataGridView dgvMedicamentOffrir;
    }
}