namespace PakingBingBang
{
    partial class FRMOrdenOrPedido
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
            this.pnlOrdenPedido = new DevComponents.DotNetBar.PanelEx();
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
            this.rdbPED = new System.Windows.Forms.RadioButton();
            this.rdbOR = new System.Windows.Forms.RadioButton();
            this.pnlOrdenPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrdenPedido
            // 
            this.pnlOrdenPedido.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlOrdenPedido.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlOrdenPedido.Controls.Add(this.btnAceptar);
            this.pnlOrdenPedido.Controls.Add(this.rdbPED);
            this.pnlOrdenPedido.Controls.Add(this.rdbOR);
            this.pnlOrdenPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrdenPedido.Location = new System.Drawing.Point(0, 0);
            this.pnlOrdenPedido.Name = "pnlOrdenPedido";
            this.pnlOrdenPedido.Size = new System.Drawing.Size(266, 207);
            this.pnlOrdenPedido.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlOrdenPedido.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlOrdenPedido.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlOrdenPedido.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlOrdenPedido.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlOrdenPedido.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlOrdenPedido.Style.GradientAngle = 90;
            this.pnlOrdenPedido.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(63, 139);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(142, 43);
            this.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rdbPED
            // 
            this.rdbPED.AutoSize = true;
            this.rdbPED.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPED.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdbPED.Location = new System.Drawing.Point(45, 86);
            this.rdbPED.Name = "rdbPED";
            this.rdbPED.Size = new System.Drawing.Size(132, 26);
            this.rdbPED.TabIndex = 1;
            this.rdbPED.TabStop = true;
            this.rdbPED.Text = "SOLICITUD";
            this.rdbPED.UseVisualStyleBackColor = true;
            // 
            // rdbOR
            // 
            this.rdbOR.AutoSize = true;
            this.rdbOR.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOR.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rdbOR.Location = new System.Drawing.Point(45, 38);
            this.rdbOR.Name = "rdbOR";
            this.rdbOR.Size = new System.Drawing.Size(187, 26);
            this.rdbOR.TabIndex = 0;
            this.rdbOR.TabStop = true;
            this.rdbOR.Text = "ORDEN SURTIDO";
            this.rdbOR.UseVisualStyleBackColor = true;
            // 
            // FRMOrdenOrPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 207);
            this.Controls.Add(this.pnlOrdenPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMOrdenOrPedido";
            this.pnlOrdenPedido.ResumeLayout(false);
            this.pnlOrdenPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnlOrdenPedido;
        private System.Windows.Forms.RadioButton rdbPED;
        private System.Windows.Forms.RadioButton rdbOR;
        private DevComponents.DotNetBar.ButtonX btnAceptar;
    }
}