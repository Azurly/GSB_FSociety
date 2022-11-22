namespace GSB_FSociety
{
    partial class FMois
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.NumMois = new System.Windows.Forms.NumericUpDown();
            this.NumAnnee = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumMois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAnnee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(31, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(176, 115);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // NumMois
            // 
            this.NumMois.Location = new System.Drawing.Point(131, 23);
            this.NumMois.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumMois.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumMois.Name = "NumMois";
            this.NumMois.Size = new System.Drawing.Size(120, 20);
            this.NumMois.TabIndex = 2;
            this.NumMois.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumAnnee
            // 
            this.NumAnnee.Location = new System.Drawing.Point(131, 69);
            this.NumAnnee.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NumAnnee.Name = "NumAnnee";
            this.NumAnnee.Size = new System.Drawing.Size(120, 20);
            this.NumAnnee.TabIndex = 3;
            this.NumAnnee.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Le mois :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "L\'année :";
            // 
            // FMois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumAnnee);
            this.Controls.Add(this.NumMois);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Name = "FMois";
            this.Text = "FMois";
            ((System.ComponentModel.ISupportInitialize)(this.NumMois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAnnee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown NumMois;
        private System.Windows.Forms.NumericUpDown NumAnnee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}