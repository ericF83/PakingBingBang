namespace PakingBingBang
{
    partial class FRMGridHist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArticulos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.dtpA = new System.Windows.Forms.DateTimePicker();
            this.pnlFecha = new DevComponents.DotNetBar.PanelEx();
            this.lblA = new DevComponents.DotNetBar.LabelX();
            this.lblDesde = new DevComponents.DotNetBar.LabelX();
            this.btnXHist = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnXAdd = new DevComponents.DotNetBar.ButtonX();
            this.txtXID = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.pnlFecha.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Estilo,
            this.Color});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvArticulos.Location = new System.Drawing.Point(2, 169);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.Size = new System.Drawing.Size(656, 343);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentDoubleClick);
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            // 
            // ID
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 100;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // Estilo
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estilo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Estilo.HeaderText = "FECHA CREACION";
            this.Estilo.MaxInputLength = 100;
            this.Estilo.Name = "Estilo";
            this.Estilo.ReadOnly = true;
            this.Estilo.Width = 150;
            // 
            // Color
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.DefaultCellStyle = dataGridViewCellStyle4;
            this.Color.HeaderText = "FECHA CONCLUCION";
            this.Color.MaxInputLength = 100;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 150;
            // 
            // dtpDe
            // 
            this.dtpDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDe.Location = new System.Drawing.Point(10, 24);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(200, 22);
            this.dtpDe.TabIndex = 2;
            this.dtpDe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDe_KeyDown);
            // 
            // dtpA
            // 
            this.dtpA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpA.Location = new System.Drawing.Point(10, 71);
            this.dtpA.Name = "dtpA";
            this.dtpA.Size = new System.Drawing.Size(200, 22);
            this.dtpA.TabIndex = 3;
            this.dtpA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpA_KeyDown);
            // 
            // pnlFecha
            // 
            this.pnlFecha.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlFecha.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlFecha.Controls.Add(this.lblA);
            this.pnlFecha.Controls.Add(this.lblDesde);
            this.pnlFecha.Controls.Add(this.btnXHist);
            this.pnlFecha.Controls.Add(this.dtpDe);
            this.pnlFecha.Controls.Add(this.dtpA);
            this.pnlFecha.Location = new System.Drawing.Point(2, 2);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(223, 161);
            this.pnlFecha.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlFecha.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlFecha.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlFecha.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlFecha.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlFecha.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlFecha.Style.GradientAngle = 90;
            this.pnlFecha.TabIndex = 4;
            // 
            // lblA
            // 
            // 
            // 
            // 
            this.lblA.BackgroundStyle.Class = "";
            this.lblA.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(10, 48);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(99, 23);
            this.lblA.TabIndex = 12;
            this.lblA.Text = "Hasta:";
            // 
            // lblDesde
            // 
            // 
            // 
            // 
            this.lblDesde.BackgroundStyle.Class = "";
            this.lblDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(12, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(97, 23);
            this.lblDesde.TabIndex = 6;
            this.lblDesde.Text = "Desde:";
            // 
            // btnXHist
            // 
            this.btnXHist.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXHist.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnXHist.HoverImage = global::PakingBingBang.Properties.Resources.findW;
            this.btnXHist.Image = global::PakingBingBang.Properties.Resources.findB;
            this.btnXHist.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnXHist.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXHist.Location = new System.Drawing.Point(82, 99);
            this.btnXHist.Name = "btnXHist";
            this.btnXHist.Size = new System.Drawing.Size(56, 43);
            this.btnXHist.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnXHist.TabIndex = 11;
            this.btnXHist.Tooltip = "Buscar y Agregar";
            this.btnXHist.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btnXAdd);
            this.panelEx1.Controls.Add(this.txtXID);
            this.panelEx1.Location = new System.Drawing.Point(232, 2);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(204, 161);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 5;
            // 
            // btnXAdd
            // 
            this.btnXAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnXAdd.HoverImage = global::PakingBingBang.Properties.Resources.findW;
            this.btnXAdd.Image = global::PakingBingBang.Properties.Resources.findB;
            this.btnXAdd.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnXAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXAdd.Location = new System.Drawing.Point(75, 82);
            this.btnXAdd.Name = "btnXAdd";
            this.btnXAdd.Size = new System.Drawing.Size(56, 43);
            this.btnXAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnXAdd.TabIndex = 16;
            this.btnXAdd.Tooltip = "Buscar y Agregar";
            this.btnXAdd.Click += new System.EventHandler(this.btnXAdd_Click);
            // 
            // txtXID
            // 
            this.txtXID.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtXID.Border.Class = "TextBoxBorder";
            this.txtXID.Border.CornerDiameter = 9;
            this.txtXID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXID.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXID.Location = new System.Drawing.Point(47, 24);
            this.txtXID.Name = "txtXID";
            this.txtXID.Size = new System.Drawing.Size(110, 34);
            this.txtXID.TabIndex = 15;
            this.txtXID.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtXID.WatermarkText = "ID Packing";
            this.txtXID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXID_KeyDown);
            // 
            // FRMGridHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 514);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.pnlFecha);
            this.Controls.Add(this.dgvArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMGridHist";
            this.Text = "HISTORICO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.pnlFecha.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Controls.DataGridViewX dgvArticulos;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.DateTimePicker dtpA;
        private DevComponents.DotNetBar.PanelEx pnlFecha;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtXID;
        private DevComponents.DotNetBar.ButtonX btnXHist;
        private DevComponents.DotNetBar.ButtonX btnXAdd;
        public DevComponents.DotNetBar.LabelX lblA;
        public DevComponents.DotNetBar.LabelX lblDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
    }
}