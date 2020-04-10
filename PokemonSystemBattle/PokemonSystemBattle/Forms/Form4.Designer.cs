namespace PokemonSystemBattle.Forms
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.cmbPokemon = new System.Windows.Forms.ComboBox();
            this.lstSquadra = new System.Windows.Forms.ListBox();
            this.btnEsci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPokemon
            // 
            this.cmbPokemon.FormattingEnabled = true;
            this.cmbPokemon.Location = new System.Drawing.Point(13, 13);
            this.cmbPokemon.Name = "cmbPokemon";
            this.cmbPokemon.Size = new System.Drawing.Size(156, 21);
            this.cmbPokemon.TabIndex = 0;
            this.cmbPokemon.SelectedIndexChanged += new System.EventHandler(this.cmbPokemon_SelectedIndexChanged);
            // 
            // lstSquadra
            // 
            this.lstSquadra.FormattingEnabled = true;
            this.lstSquadra.Location = new System.Drawing.Point(175, 2);
            this.lstSquadra.Name = "lstSquadra";
            this.lstSquadra.Size = new System.Drawing.Size(120, 160);
            this.lstSquadra.TabIndex = 1;
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(13, 138);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 23);
            this.btnEsci.TabIndex = 2;
            this.btnEsci.Text = "Fatto";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 174);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.lstSquadra);
            this.Controls.Add(this.cmbPokemon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scegli la tua squadra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPokemon;
        private System.Windows.Forms.ListBox lstSquadra;
        private System.Windows.Forms.Button btnEsci;
    }
}