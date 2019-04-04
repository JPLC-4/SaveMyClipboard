namespace SaveMyClipboard
{
    partial class Programme
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
            this.label = new System.Windows.Forms.Label();
            this.Checkbox = new System.Windows.Forms.CheckBox();
            this.Boutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(74, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(129, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Mode Automatique Activé";
            // 
            // Checkbox
            // 
            this.Checkbox.AutoSize = true;
            this.Checkbox.Checked = true;
            this.Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Checkbox.Location = new System.Drawing.Point(53, 12);
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Size = new System.Drawing.Size(15, 14);
            this.Checkbox.TabIndex = 2;
            this.Checkbox.UseVisualStyleBackColor = true;
            // 
            // Boutton
            // 
            this.Boutton.Location = new System.Drawing.Point(77, 45);
            this.Boutton.Name = "Boutton";
            this.Boutton.Size = new System.Drawing.Size(75, 23);
            this.Boutton.TabIndex = 4;
            this.Boutton.Text = "Lancer";
            this.Boutton.UseVisualStyleBackColor = true;
            this.Boutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Programme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 80);
            this.Controls.Add(this.Boutton);
            this.Controls.Add(this.Checkbox);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Programme";
            this.Text = "SaveMyClipboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox Checkbox;
        private System.Windows.Forms.Button Boutton;
    }
}

