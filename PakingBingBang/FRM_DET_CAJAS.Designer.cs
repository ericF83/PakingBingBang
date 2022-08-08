namespace PakingBingBang
{
    partial class FRM_DET_CAJAS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetalle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtXtara = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtXPesoB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtXPesoN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtXDim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnXSave = new DevComponents.DotNetBar.ButtonX();
            this.btnXCancel = new DevComponents.DotNetBar.ButtonX();
            this.lblXnDim = new DevComponents.DotNetBar.LabelX();
            this.lblPbruto = new DevComponents.DotNetBar.LabelX();
            this.lblPneto = new DevComponents.DotNetBar.LabelX();
            this.lblTara = new DevComponents.DotNetBar.LabelX();
            this.cmbXModa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dgvXPrec = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Precinto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXPrec)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Orden,
            this.Articulo,
            this.Talla,
            this.Color,
            this.Cantidad,
            this.EnCaja});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDetalle.Location = new System.Drawing.Point(2, 137);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(511, 383);
            this.dgvDetalle.TabIndex = 0;
            // 
            // Orden
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orden.DefaultCellStyle = dataGridViewCellStyle2;
            this.Orden.HeaderText = "Orden";
            this.Orden.MaxInputLength = 50;
            this.Orden.Name = "Orden";
            this.Orden.ReadOnly = true;
            this.Orden.Width = 75;
            // 
            // Articulo
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Articulo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            // 
            // Talla
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Talla.DefaultCellStyle = dataGridViewCellStyle4;
            this.Talla.HeaderText = "Talla";
            this.Talla.MaxInputLength = 5;
            this.Talla.Name = "Talla";
            this.Talla.ReadOnly = true;
            this.Talla.Width = 65;
            // 
            // Color
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.DefaultCellStyle = dataGridViewCellStyle5;
            this.Color.HeaderText = "Color";
            this.Color.MaxInputLength = 5;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 75;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MaxInputLength = 10;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 75;
            // 
            // EnCaja
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnCaja.DefaultCellStyle = dataGridViewCellStyle7;
            this.EnCaja.HeaderText = "En Caja";
            this.EnCaja.MaxInputLength = 10;
            this.EnCaja.Name = "EnCaja";
            this.EnCaja.ReadOnly = true;
            this.EnCaja.Width = 75;
            // 
            // txtXtara
            // 
            this.txtXtara.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtXtara.Border.Class = "TextBoxBorder";
            this.txtXtara.Border.CornerDiameter = 9;
            this.txtXtara.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXtara.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXtara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXtara.Location = new System.Drawing.Point(162, 96);
            this.txtXtara.Name = "txtXtara";
            this.txtXtara.ReadOnly = true;
            this.txtXtara.Size = new System.Drawing.Size(110, 37);
            this.txtXtara.TabIndex = 15;
            this.txtXtara.Text = "0.9";
            this.txtXtara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtXtara.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtXtara.WatermarkText = "Tara";
            this.txtXtara.TextChanged += new System.EventHandler(this.txtXtara_TextChanged);
            // 
            // txtXPesoB
            // 
            this.txtXPesoB.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtXPesoB.Border.Class = "TextBoxBorder";
            this.txtXPesoB.Border.CornerDiameter = 9;
            this.txtXPesoB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXPesoB.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXPesoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXPesoB.Location = new System.Drawing.Point(312, 96);
            this.txtXPesoB.Name = "txtXPesoB";
            this.txtXPesoB.Size = new System.Drawing.Size(110, 37);
            this.txtXPesoB.TabIndex = 16;
            this.txtXPesoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtXPesoB.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtXPesoB.TextChanged += new System.EventHandler(this.txtXPesoB_TextChanged);
            this.txtXPesoB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXPesoB_KeyDown);
            this.txtXPesoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXPesoB_KeyPress);
            // 
            // txtXPesoN
            // 
            this.txtXPesoN.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtXPesoN.Border.Class = "TextBoxBorder";
            this.txtXPesoN.Border.CornerDiameter = 9;
            this.txtXPesoN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXPesoN.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXPesoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXPesoN.Location = new System.Drawing.Point(12, 96);
            this.txtXPesoN.Name = "txtXPesoN";
            this.txtXPesoN.Size = new System.Drawing.Size(110, 37);
            this.txtXPesoN.TabIndex = 17;
            this.txtXPesoN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtXPesoN.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtXPesoN.TextChanged += new System.EventHandler(this.txtXPesoN_TextChanged);
            this.txtXPesoN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXPesoN_KeyDown);
            this.txtXPesoN.Leave += new System.EventHandler(this.txtXPesoN_Leave);
            // 
            // txtXDim
            // 
            this.txtXDim.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtXDim.Border.Class = "TextBoxBorder";
            this.txtXDim.Border.CornerDiameter = 9;
            this.txtXDim.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXDim.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXDim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXDim.Location = new System.Drawing.Point(12, 34);
            this.txtXDim.Name = "txtXDim";
            this.txtXDim.ReadOnly = true;
            this.txtXDim.Size = new System.Drawing.Size(205, 37);
            this.txtXDim.TabIndex = 18;
            this.txtXDim.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtXDim.TextChanged += new System.EventHandler(this.txtXDim_TextChanged);
            // 
            // btnXSave
            // 
            this.btnXSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXSave.Image = global::PakingBingBang.Properties.Resources.save;
            this.btnXSave.ImageFixedSize = new System.Drawing.Size(40, 40);
            this.btnXSave.ImageTextSpacing = -5;
            this.btnXSave.Location = new System.Drawing.Point(561, 12);
            this.btnXSave.Name = "btnXSave";
            this.btnXSave.Size = new System.Drawing.Size(62, 52);
            this.btnXSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXSave.TabIndex = 19;
            this.btnXSave.Tooltip = "Guardar";
            this.btnXSave.Click += new System.EventHandler(this.btnXSave_Click);
            // 
            // btnXCancel
            // 
            this.btnXCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXCancel.Image = global::PakingBingBang.Properties.Resources.cancel;
            this.btnXCancel.ImageFixedSize = new System.Drawing.Size(80, 80);
            this.btnXCancel.Location = new System.Drawing.Point(630, 12);
            this.btnXCancel.Name = "btnXCancel";
            this.btnXCancel.Size = new System.Drawing.Size(62, 52);
            this.btnXCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXCancel.TabIndex = 20;
            this.btnXCancel.Tooltip = "Cancelar";
            this.btnXCancel.Click += new System.EventHandler(this.btnXCancel_Click);
            // 
            // lblXnDim
            // 
            // 
            // 
            // 
            this.lblXnDim.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblXnDim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXnDim.Location = new System.Drawing.Point(12, 12);
            this.lblXnDim.Name = "lblXnDim";
            this.lblXnDim.Size = new System.Drawing.Size(107, 18);
            this.lblXnDim.TabIndex = 21;
            this.lblXnDim.Text = "Dimesiones";
            this.lblXnDim.Visible = false;
            // 
            // lblPbruto
            // 
            // 
            // 
            // 
            this.lblPbruto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPbruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPbruto.Location = new System.Drawing.Point(312, 77);
            this.lblPbruto.Name = "lblPbruto";
            this.lblPbruto.Size = new System.Drawing.Size(107, 18);
            this.lblPbruto.TabIndex = 22;
            this.lblPbruto.Text = "Peso Neto";
            this.lblPbruto.Visible = false;
            // 
            // lblPneto
            // 
            // 
            // 
            // 
            this.lblPneto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPneto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPneto.Location = new System.Drawing.Point(12, 77);
            this.lblPneto.Name = "lblPneto";
            this.lblPneto.Size = new System.Drawing.Size(107, 18);
            this.lblPneto.TabIndex = 23;
            this.lblPneto.Text = "Peso Bruto";
            this.lblPneto.Visible = false;
            // 
            // lblTara
            // 
            // 
            // 
            // 
            this.lblTara.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTara.Location = new System.Drawing.Point(162, 77);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(107, 18);
            this.lblTara.TabIndex = 24;
            this.lblTara.Text = "Tara";
            // 
            // cmbXModa
            // 
            this.cmbXModa.DisplayMember = "Text";
            this.cmbXModa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbXModa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbXModa.FormattingEnabled = true;
            this.cmbXModa.ItemHeight = 20;
            this.cmbXModa.Location = new System.Drawing.Point(449, 96);
            this.cmbXModa.Name = "cmbXModa";
            this.cmbXModa.Size = new System.Drawing.Size(174, 26);
            this.cmbXModa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbXModa.TabIndex = 25;
            this.cmbXModa.Visible = false;
            this.cmbXModa.WatermarkText = "Moda";
            this.cmbXModa.SelectedIndexChanged += new System.EventHandler(this.cmbXModa_SelectedIndexChanged);
            this.cmbXModa.SelectionChangeCommitted += new System.EventHandler(this.cmbXModa_SelectionChangeCommitted);
            // 
            // dgvXPrec
            // 
            this.dgvXPrec.AllowUserToAddRows = false;
            this.dgvXPrec.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXPrec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvXPrec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXPrec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Precinto});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXPrec.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvXPrec.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvXPrec.Location = new System.Drawing.Point(517, 137);
            this.dgvXPrec.Name = "dgvXPrec";
            this.dgvXPrec.ReadOnly = true;
            this.dgvXPrec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvXPrec.Size = new System.Drawing.Size(184, 383);
            this.dgvXPrec.TabIndex = 26;
            // 
            // Precinto
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precinto.DefaultCellStyle = dataGridViewCellStyle10;
            this.Precinto.HeaderText = "Precinto";
            this.Precinto.Name = "Precinto";
            this.Precinto.ReadOnly = true;
            this.Precinto.Width = 130;
            // 
            // FRM_DET_CAJAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 522);
            this.Controls.Add(this.dgvXPrec);
            this.Controls.Add(this.cmbXModa);
            this.Controls.Add(this.lblTara);
            this.Controls.Add(this.lblPneto);
            this.Controls.Add(this.lblPbruto);
            this.Controls.Add(this.lblXnDim);
            this.Controls.Add(this.btnXCancel);
            this.Controls.Add(this.btnXSave);
            this.Controls.Add(this.txtXDim);
            this.Controls.Add(this.txtXPesoN);
            this.Controls.Add(this.txtXPesoB);
            this.Controls.Add(this.txtXtara);
            this.Controls.Add(this.dgvDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_DET_CAJAS";
            this.Text = "CAJA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_DET_CAJAS_FormClosing);
            this.Load += new System.EventHandler(this.FRM_DET_CAJAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXPrec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Controls.DataGridViewX dgvDetalle;
        public DevComponents.DotNetBar.Controls.TextBoxX txtXtara;
        public DevComponents.DotNetBar.Controls.TextBoxX txtXPesoB;
        public DevComponents.DotNetBar.Controls.TextBoxX txtXPesoN;
        public DevComponents.DotNetBar.Controls.TextBoxX txtXDim;
        private DevComponents.DotNetBar.ButtonX btnXSave;
        private DevComponents.DotNetBar.ButtonX btnXCancel;
        public DevComponents.DotNetBar.LabelX lblXnDim;
        public DevComponents.DotNetBar.LabelX lblPbruto;
        public DevComponents.DotNetBar.LabelX lblPneto;
        public DevComponents.DotNetBar.LabelX lblTara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnCaja;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbXModa;
        public DevComponents.DotNetBar.Controls.DataGridViewX dgvXPrec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precinto;
    }
}