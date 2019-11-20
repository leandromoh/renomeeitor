namespace Renomeeitor.Classes_Auxiliares
{
    partial class frmAviso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAviso));
            this.panelProcessando = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProcessando = new System.Windows.Forms.Label();
            this.panelConcluido = new System.Windows.Forms.Panel();
            this.picConcluido = new System.Windows.Forms.PictureBox();
            this.lblConcluido = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelProcessando.SuspendLayout();
            this.panelConcluido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConcluido)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProcessando
            // 
            this.panelProcessando.Controls.Add(this.progressBar1);
            this.panelProcessando.Controls.Add(this.lblProcessando);
            this.panelProcessando.Location = new System.Drawing.Point(0, -3);
            this.panelProcessando.Name = "panelProcessando";
            this.panelProcessando.Size = new System.Drawing.Size(172, 112);
            this.panelProcessando.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 63);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(151, 30);
            this.progressBar1.TabIndex = 3;
            // 
            // lblProcessando
            // 
            this.lblProcessando.AutoSize = true;
            this.lblProcessando.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessando.Location = new System.Drawing.Point(27, 19);
            this.lblProcessando.Name = "lblProcessando";
            this.lblProcessando.Size = new System.Drawing.Size(136, 24);
            this.lblProcessando.TabIndex = 1;
            this.lblProcessando.Text = "Processando...";
            // 
            // panelConcluido
            // 
            this.panelConcluido.Controls.Add(this.picConcluido);
            this.panelConcluido.Controls.Add(this.lblConcluido);
            this.panelConcluido.Location = new System.Drawing.Point(33, -3);
            this.panelConcluido.Name = "panelConcluido";
            this.panelConcluido.Size = new System.Drawing.Size(113, 112);
            this.panelConcluido.TabIndex = 2;
            // 
            // picConcluido
            // 
            this.picConcluido.Image = global::Renomeeitor.Properties.Resources.ok_256;
            this.picConcluido.Location = new System.Drawing.Point(17, 35);
            this.picConcluido.Name = "picConcluido";
            this.picConcluido.Size = new System.Drawing.Size(78, 75);
            this.picConcluido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConcluido.TabIndex = 1;
            this.picConcluido.TabStop = false;
            // 
            // lblConcluido
            // 
            this.lblConcluido.AutoSize = true;
            this.lblConcluido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblConcluido.Location = new System.Drawing.Point(8, 8);
            this.lblConcluido.Name = "lblConcluido";
            this.lblConcluido.Size = new System.Drawing.Size(101, 24);
            this.lblConcluido.TabIndex = 0;
            this.lblConcluido.Text = "Concluído!";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnOk.Location = new System.Drawing.Point(47, 111);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 27);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(173, 145);
            this.Controls.Add(this.panelConcluido);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panelProcessando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAviso";
            this.Text = "Form1";
            this.panelProcessando.ResumeLayout(false);
            this.panelProcessando.PerformLayout();
            this.panelConcluido.ResumeLayout(false);
            this.panelConcluido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConcluido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProcessando;
        private System.Windows.Forms.PictureBox picConcluido;
        private System.Windows.Forms.Label lblConcluido;
        public System.Windows.Forms.Panel panelConcluido;
        public System.Windows.Forms.Panel panelProcessando;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Button btnOk;
    }
}