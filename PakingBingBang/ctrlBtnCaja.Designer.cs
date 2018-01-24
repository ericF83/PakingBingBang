namespace PakingBingBang
{
    partial class ctrlBtnCaja
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlXBtn = new DevComponents.DotNetBar.PanelEx();
            this.btnXbtn = new DevComponents.DotNetBar.ButtonX();
            this.pnlXBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlXBtn
            // 
            this.pnlXBtn.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlXBtn.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlXBtn.Controls.Add(this.btnXbtn);
            this.pnlXBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlXBtn.Location = new System.Drawing.Point(0, 0);
            this.pnlXBtn.Name = "pnlXBtn";
            this.pnlXBtn.Size = new System.Drawing.Size(145, 124);
            this.pnlXBtn.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlXBtn.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlXBtn.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlXBtn.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlXBtn.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlXBtn.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlXBtn.Style.GradientAngle = 90;
            this.pnlXBtn.TabIndex = 0;
            // 
            // btnXbtn
            // 
            this.btnXbtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXbtn.BackgroundImage = global::PakingBingBang.Properties.Resources.box;
            this.btnXbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXbtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXbtn.Image = global::PakingBingBang.Properties.Resources.box;
            this.btnXbtn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnXbtn.ImageTextSpacing = -10;
            this.btnXbtn.Location = new System.Drawing.Point(2, 2);
            this.btnXbtn.Name = "btnXbtn";
            this.btnXbtn.Size = new System.Drawing.Size(140, 119);
            this.btnXbtn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXbtn.TabIndex = 0;
            this.btnXbtn.Text = "Caja";
            this.btnXbtn.Click += new System.EventHandler(this.btnXbtn_Click);
            // 
            // ctrlBtnCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlXBtn);
            this.Name = "ctrlBtnCaja";
            this.Size = new System.Drawing.Size(145, 124);
            this.pnlXBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnlXBtn;
        public DevComponents.DotNetBar.ButtonX btnXbtn;
    }
}
