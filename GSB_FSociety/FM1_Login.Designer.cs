namespace GSB_FSociety
{
    partial class FM1_Login
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
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(89, 39);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.PasswordChar = '*';
            this.textBoxMDP.Size = new System.Drawing.Size(100, 20);
            this.textBoxMDP.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mot de Passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Identifiant";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(69, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 4;
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonValider.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonValider.Location = new System.Drawing.Point(13, 72);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(182, 39);
            this.buttonValider.TabIndex = 8;
            this.buttonValider.Text = "VALIDER";
            this.buttonValider.UseVisualStyleBackColor = false;
            // 
            // FM1_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 123);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Name = "FM1_Login";
            this.Text = "FM1_Login";
            this.Load += new System.EventHandler(this.FM1_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonValider;
    }
}