namespace GSB_FSociety
{
    partial class FM3
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
            this.titre = new System.Windows.Forms.Label();
            this.dgvFicheForfait = new System.Windows.Forms.DataGridView();
            this.bsFicheRemboursement = new System.Windows.Forms.BindingSource(this.components);
            this.filtre = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btNew = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFicheForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFicheRemboursement)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(165, 40);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(465, 31);
            this.titre.TabIndex = 0;
            this.titre.Text = "Gestion des remboursements de frais";
            // 
            // dgvFicheForfait
            // 
            this.dgvFicheForfait.AllowUserToAddRows = false;
            this.dgvFicheForfait.AllowUserToDeleteRows = false;
            this.dgvFicheForfait.AutoGenerateColumns = false;
            this.dgvFicheForfait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFicheForfait.DataSource = this.bsFicheRemboursement;
            this.dgvFicheForfait.Location = new System.Drawing.Point(12, 128);
            this.dgvFicheForfait.Name = "dgvFicheForfait";
            this.dgvFicheForfait.ReadOnly = true;
            this.dgvFicheForfait.Size = new System.Drawing.Size(760, 292);
            this.dgvFicheForfait.TabIndex = 1;
            // 
            // filtre
            // 
            this.filtre.AutoSize = true;
            this.filtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtre.Location = new System.Drawing.Point(13, 92);
            this.filtre.Name = "filtre";
            this.filtre.Size = new System.Drawing.Size(77, 17);
            this.filtre.TabIndex = 2;
            this.filtre.Text = "Filtrer par :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(697, 426);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 23);
            this.btNew.TabIndex = 5;
            this.btNew.Text = "New";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(12, 426);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btDelet
            // 
            this.btDelet.Location = new System.Drawing.Point(96, 426);
            this.btDelet.Name = "btDelet";
            this.btDelet.Size = new System.Drawing.Size(75, 23);
            this.btDelet.TabIndex = 7;
            this.btDelet.Text = "Delet";
            this.btDelet.UseVisualStyleBackColor = true;
            // 
            // FM3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btDelet);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.filtre);
            this.Controls.Add(this.dgvFicheForfait);
            this.Controls.Add(this.titre);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FM3";
            this.Text = "FM3";
            this.Load += new System.EventHandler(this.FM3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFicheForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFicheRemboursement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.BindingSource bsFicheRemboursement;
        private System.Windows.Forms.DataGridView dgvFicheForfait;
        private System.Windows.Forms.Label filtre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelet;
    }
}