namespace PokemonSystemBattle
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.picPrimo = new System.Windows.Forms.PictureBox();
            this.picSecondo = new System.Windows.Forms.PictureBox();
            this.progressSquadra = new System.Windows.Forms.ProgressBar();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAvversario = new System.Windows.Forms.Label();
            this.progressAvversario = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPrimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 344);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(426, 94);
            this.txtLog.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(445, 344);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(167, 46);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Lotta";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(445, 392);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(167, 46);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Pokémon";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(618, 344);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(167, 46);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Borsa";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(618, 392);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(167, 46);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Esci";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // picPrimo
            // 
            this.picPrimo.BackColor = System.Drawing.Color.Transparent;
            this.picPrimo.Location = new System.Drawing.Point(12, 159);
            this.picPrimo.Name = "picPrimo";
            this.picPrimo.Size = new System.Drawing.Size(285, 179);
            this.picPrimo.TabIndex = 5;
            this.picPrimo.TabStop = false;
            // 
            // picSecondo
            // 
            this.picSecondo.BackColor = System.Drawing.Color.Transparent;
            this.picSecondo.Location = new System.Drawing.Point(480, 46);
            this.picSecondo.Name = "picSecondo";
            this.picSecondo.Size = new System.Drawing.Size(285, 179);
            this.picSecondo.TabIndex = 6;
            this.picSecondo.TabStop = false;
            // 
            // progressSquadra
            // 
            this.progressSquadra.Location = new System.Drawing.Point(635, 284);
            this.progressSquadra.Name = "progressSquadra";
            this.progressSquadra.Size = new System.Drawing.Size(130, 23);
            this.progressSquadra.Step = 1;
            this.progressSquadra.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Location = new System.Drawing.Point(512, 284);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 23);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvversario
            // 
            this.lblAvversario.BackColor = System.Drawing.Color.Transparent;
            this.lblAvversario.Location = new System.Drawing.Point(12, 46);
            this.lblAvversario.Name = "lblAvversario";
            this.lblAvversario.Size = new System.Drawing.Size(100, 23);
            this.lblAvversario.TabIndex = 10;
            this.lblAvversario.Text = "Nome";
            this.lblAvversario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressAvversario
            // 
            this.progressAvversario.Location = new System.Drawing.Point(135, 46);
            this.progressAvversario.Name = "progressAvversario";
            this.progressAvversario.Size = new System.Drawing.Size(130, 23);
            this.progressAvversario.Step = 1;
            this.progressAvversario.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAvversario);
            this.Controls.Add(this.progressAvversario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.progressSquadra);
            this.Controls.Add(this.picSecondo);
            this.Controls.Add(this.picPrimo);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtLog);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPrimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.PictureBox picPrimo;
        private System.Windows.Forms.PictureBox picSecondo;
        private System.Windows.Forms.ProgressBar progressSquadra;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAvversario;
        private System.Windows.Forms.ProgressBar progressAvversario;
        private System.Windows.Forms.Timer timer1;
    }
}