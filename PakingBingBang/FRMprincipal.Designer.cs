namespace PakingBingBang
{
    partial class FRMprincipal
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
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.btnXPend = new DevComponents.DotNetBar.ButtonX();
            this.btnXCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnXNuevo = new DevComponents.DotNetBar.ButtonX();
            this.PnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.BackgroundImage = global::PakingBingBang.Properties.Resources.box_principal;
            this.PnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PnlPrincipal.Controls.Add(this.btnXPend);
            this.PnlPrincipal.Controls.Add(this.btnXCancel);
            this.PnlPrincipal.Controls.Add(this.btnXNuevo);
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(948, 586);
            this.PnlPrincipal.TabIndex = 0;
            // 
            // btnXPend
            // 
            this.btnXPend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXPend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXPend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXPend.HoverImage = global::PakingBingBang.Properties.Resources.pausa1;
            this.btnXPend.Image = global::PakingBingBang.Properties.Resources.pausa;
            this.btnXPend.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.btnXPend.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnXPend.ImageTextSpacing = -14;
            this.btnXPend.Location = new System.Drawing.Point(145, 12);
            this.btnXPend.Name = "btnXPend";
            this.btnXPend.Size = new System.Drawing.Size(140, 48);
            this.btnXPend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXPend.TabIndex = 21;
            this.btnXPend.Text = "PENDIENTE";
            this.btnXPend.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnXPend.Click += new System.EventHandler(this.btnXPend_Click);
            // 
            // btnXCancel
            // 
            this.btnXCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXCancel.HoverImage = global::PakingBingBang.Properties.Resources.tiempo2;
            this.btnXCancel.Image = global::PakingBingBang.Properties.Resources.tiempo1;
            this.btnXCancel.ImageFixedSize = new System.Drawing.Size(49, 49);
            this.btnXCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnXCancel.ImageTextSpacing = -11;
            this.btnXCancel.Location = new System.Drawing.Point(301, 12);
            this.btnXCancel.Name = "btnXCancel";
            this.btnXCancel.Size = new System.Drawing.Size(132, 48);
            this.btnXCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXCancel.TabIndex = 20;
            this.btnXCancel.Text = "HISTORICO";
            this.btnXCancel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnXCancel.Click += new System.EventHandler(this.btnXCancel_Click);
            // 
            // btnXNuevo
            // 
            this.btnXNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXNuevo.HoverImage = global::PakingBingBang.Properties.Resources.openBox1;
            this.btnXNuevo.Image = global::PakingBingBang.Properties.Resources.openBox2;
            this.btnXNuevo.ImageFixedSize = new System.Drawing.Size(23, 23);
            this.btnXNuevo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnXNuevo.Location = new System.Drawing.Point(12, 12);
            this.btnXNuevo.Name = "btnXNuevo";
            this.btnXNuevo.Size = new System.Drawing.Size(118, 48);
            this.btnXNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXNuevo.TabIndex = 19;
            this.btnXNuevo.Text = "NUEVO";
            this.btnXNuevo.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnXNuevo.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // FRMprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 586);
            this.Controls.Add(this.PnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FRMprincipal";
            this.Text = "FRMprincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PnlPrincipal;
        private DevComponents.DotNetBar.ButtonX btnXPend;
        private DevComponents.DotNetBar.ButtonX btnXCancel;
        private DevComponents.DotNetBar.ButtonX btnXNuevo;
    }
}