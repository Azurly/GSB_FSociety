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
            this.tbRemplacent = new System.Windows.Forms.TextBox();
            this.checkBoxRemplacent = new System.Windows.Forms.CheckBox();
            this.tcMedicament = new System.Windows.Forms.TabControl();
            this.tpPresenter = new System.Windows.Forms.TabPage();
            this.dgvMedicamentPresenter = new System.Windows.Forms.DataGridView();
            this.tpOffrir = new System.Windows.Forms.TabPage();
            this.dgvMedicamentOffrir = new System.Windows.Forms.DataGridView();
            this.lblConfiance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarConfiance = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tcMedicament.SuspendLayout();
            this.tpPresenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentPresenter)).BeginInit();
            this.tpOffrir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentOffrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarConfiance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbRemplacent);
            this.panel1.Controls.Add(this.checkBoxRemplacent);
            this.panel1.Controls.Add(this.tcMedicament);
            this.panel1.Controls.Add(this.lblConfiance);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.trackBarConfiance);
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
            // tbRemplacent
            // 
            this.tbRemplacent.Location = new System.Drawing.Point(106, 84);
            this.tbRemplacent.Name = "tbRemplacent";
            this.tbRemplacent.Size = new System.Drawing.Size(200, 20);
            this.tbRemplacent.TabIndex = 20;
            // 
            // checkBoxRemplacent
            // 
            this.checkBoxRemplacent.AutoSize = true;
            this.checkBoxRemplacent.Location = new System.Drawing.Point(17, 87);
            this.checkBoxRemplacent.Name = "checkBoxRemplacent";
            this.checkBoxRemplacent.Size = new System.Drawing.Size(89, 17);
            this.checkBoxRemplacent.TabIndex = 0;
            this.checkBoxRemplacent.Text = "Remplacent :";
            this.checkBoxRemplacent.UseVisualStyleBackColor = true;
            this.checkBoxRemplacent.CheckedChanged += new System.EventHandler(this.checkBoxRemplacent_CheckedChanged);
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
            this.tpPresenter.Controls.Add(this.btnModifier);
            this.tpPresenter.Controls.Add(this.BtnSupprimer);
            this.tpPresenter.Controls.Add(this.btnAjouter);
            this.tpPresenter.Controls.Add(this.dgvMedicamentPresenter);
            this.tpPresenter.Location = new System.Drawing.Point(4, 22);
            this.tpPresenter.Name = "tpPresenter";
            this.tpPresenter.Padding = new System.Windows.Forms.Padding(3);
            this.tpPresenter.Size = new System.Drawing.Size(660, 364);
            this.tpPresenter.TabIndex = 0;
            this.tpPresenter.Text = "Présenter";
            this.tpPresenter.UseVisualStyleBackColor = true;
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
            // tpOffrir
            // 
            this.tpOffrir.Controls.Add(this.button1);
            this.tpOffrir.Controls.Add(this.button2);
            this.tpOffrir.Controls.Add(this.button3);
            this.tpOffrir.Controls.Add(this.dgvMedicamentOffrir);
            this.tpOffrir.Location = new System.Drawing.Point(4, 22);
            this.tpOffrir.Name = "tpOffrir";
            this.tpOffrir.Padding = new System.Windows.Forms.Padding(3);
            this.tpOffrir.Size = new System.Drawing.Size(660, 364);
            this.tpOffrir.TabIndex = 1;
            this.tpOffrir.Text = "Offrir";
            this.tpOffrir.UseVisualStyleBackColor = true;
            // 
            // dgvMedicamentOffrir
            // 
            this.dgvMedicamentOffrir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentOffrir.Location = new System.Drawing.Point(6, 6);
            this.dgvMedicamentOffrir.Name = "dgvMedicamentOffrir";
            this.dgvMedicamentOffrir.Size = new System.Drawing.Size(648, 319);
            this.dgvMedicamentOffrir.TabIndex = 22;
            // 
            // lblConfiance
            // 
            this.lblConfiance.AutoSize = true;
            this.lblConfiance.Location = new System.Drawing.Point(231, 162);
            this.lblConfiance.Name = "lblConfiance";
            this.lblConfiance.Size = new System.Drawing.Size(13, 13);
            this.lblConfiance.TabIndex = 18;
            this.lblConfiance.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "niveau de Confiance du medecin :";
            // 
            // trackBarConfiance
            // 
            this.trackBarConfiance.Location = new System.Drawing.Point(59, 178);
            this.trackBarConfiance.Name = "trackBarConfiance";
            this.trackBarConfiance.Size = new System.Drawing.Size(256, 45);
            this.trackBarConfiance.TabIndex = 16;
            this.trackBarConfiance.Value = 5;
            this.trackBarConfiance.ValueChanged += new System.EventHandler(this.trackBarConfiance_ValueChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 61);
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
            this.cbxMedecin.Location = new System.Drawing.Point(106, 57);
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
            this.BtnValider.Location = new System.Drawing.Point(59, 412);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(75, 23);
            this.BtnValider.TabIndex = 5;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(357, 412);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnuler.TabIndex = 6;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            // 
            // RtbBilan
            // 
            this.RtbBilan.Location = new System.Drawing.Point(59, 231);
            this.RtbBilan.Name = "RtbBilan";
            this.RtbBilan.Size = new System.Drawing.Size(373, 158);
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
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(6, 331);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 22;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.ForeColor = System.Drawing.Color.Red;
            this.BtnSupprimer.Location = new System.Drawing.Point(579, 331);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.BtnSupprimer.TabIndex = 23;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(87, 331);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 24;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(579, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Date :";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(276, 412);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
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
            this.tcMedicament.ResumeLayout(false);
            this.tpPresenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentPresenter)).EndInit();
            this.tpOffrir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentOffrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarConfiance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).EndInit();
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
        private System.Windows.Forms.TabControl tcMedicament;
        private System.Windows.Forms.TabPage tpPresenter;
        private System.Windows.Forms.TabPage tpOffrir;
        private System.Windows.Forms.Label lblConfiance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarConfiance;
        private System.Windows.Forms.TextBox tbRemplacent;
        private System.Windows.Forms.CheckBox checkBoxRemplacent;
        private System.Windows.Forms.DataGridView dgvMedicamentOffrir;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
    }
}