namespace PakingBingBang
{
    partial class FRMMensaje
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
            this.btnaceptar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pBoxMsj = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMsj)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(187, 72);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 1;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(12, 19);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(14, 16);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "x";
            // 
            // pBoxMsj
            // 
            this.pBoxMsj.BackgroundImage = global::PakingBingBang.Properties.Resources.Warning_6;
            this.pBoxMsj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxMsj.Location = new System.Drawing.Point(15, 44);
            this.pBoxMsj.Name = "pBoxMsj";
            this.pBoxMsj.Size = new System.Drawing.Size(54, 51);
            this.pBoxMsj.TabIndex = 2;
            this.pBoxMsj.TabStop = false;
            // 
            // FRMMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(271, 107);
            this.Controls.Add(this.pBoxMsj);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnaceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMMensaje";
            this.Text = "Aviso";
            this.Load += new System.EventHandler(this.FRMMensaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMsj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptar;
        public System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pBoxMsj;
    }
}