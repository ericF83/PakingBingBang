namespace PakingBingBang
{
    partial class FRM_agregarArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_agregarArticulos));
            this.dgvArticulos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBCUENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitar = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.pnlBox = new DevComponents.DotNetBar.PanelEx();
            this.lblXnCaja = new DevComponents.DotNetBar.LabelX();
            this.lblXnCajas = new DevComponents.DotNetBar.LabelX();
            this.lblNUmero = new DevComponents.DotNetBar.LabelX();
            this.lblCant = new DevComponents.DotNetBar.LabelX();
            this.swbtnAbrir = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.txtXCodigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtXNum = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pnlXModa = new DevComponents.DotNetBar.PanelEx();
            this.lblXModa = new DevComponents.DotNetBar.LabelX();
            this.cmbXModa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblXorden = new DevComponents.DotNetBar.LabelX();
            this.btnXPend = new DevComponents.DotNetBar.ButtonX();
            this.btnXCinto = new DevComponents.DotNetBar.ButtonX();
            this.txtBtnXCinto = new DevComponents.DotNetBar.TextBoxItem();
            this.btnXCancel = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnXAdd = new DevComponents.DotNetBar.ButtonX();
            this.btnXVerCaja = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.pnlBox.SuspendLayout();
            this.pnlXModa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SUBCUENTA,
            this.Articulo,
            this.Estilo,
            this.Color,
            this.Cantidad,
            this.Talla,
            this.EnCaja,
            this.Codigo,
            this.MovID,
            this.Quitar});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle36;
            this.dgvArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvArticulos.Location = new System.Drawing.Point(2, 88);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.Size = new System.Drawing.Size(536, 404);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellClick);
            this.dgvArticulos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvArticulos_RowsAdded);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SUBCUENTA
            // 
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBCUENTA.DefaultCellStyle = dataGridViewCellStyle26;
            this.SUBCUENTA.HeaderText = "SUBCUENTA";
            this.SUBCUENTA.Name = "SUBCUENTA";
            this.SUBCUENTA.ReadOnly = true;
            this.SUBCUENTA.Visible = false;
            // 
            // Articulo
            // 
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Articulo.DefaultCellStyle = dataGridViewCellStyle27;
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.MaxInputLength = 100;
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 80;
            // 
            // Estilo
            // 
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estilo.DefaultCellStyle = dataGridViewCellStyle28;
            this.Estilo.HeaderText = "Estilo";
            this.Estilo.MaxInputLength = 100;
            this.Estilo.Name = "Estilo";
            this.Estilo.ReadOnly = true;
            this.Estilo.Width = 50;
            // 
            // Color
            // 
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.DefaultCellStyle = dataGridViewCellStyle29;
            this.Color.HeaderText = "Color";
            this.Color.MaxInputLength = 100;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 150;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle30;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MaxInputLength = 10;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 75;
            // 
            // Talla
            // 
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Talla.DefaultCellStyle = dataGridViewCellStyle31;
            this.Talla.HeaderText = "Talla";
            this.Talla.MaxInputLength = 10;
            this.Talla.Name = "Talla";
            this.Talla.ReadOnly = true;
            this.Talla.Width = 50;
            // 
            // EnCaja
            // 
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnCaja.DefaultCellStyle = dataGridViewCellStyle32;
            this.EnCaja.HeaderText = "En Caja";
            this.EnCaja.Name = "EnCaja";
            this.EnCaja.ReadOnly = true;
            this.EnCaja.Width = 70;
            // 
            // Codigo
            // 
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle33;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // MovID
            // 
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovID.DefaultCellStyle = dataGridViewCellStyle34;
            this.MovID.HeaderText = "MovID";
            this.MovID.Name = "MovID";
            this.MovID.ReadOnly = true;
            this.MovID.Visible = false;
            // 
            // Quitar
            // 
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Red;
            this.Quitar.DefaultCellStyle = dataGridViewCellStyle35;
            this.Quitar.HeaderText = "Quitar de caja";
            this.Quitar.Name = "Quitar";
            this.Quitar.ReadOnly = true;
            this.Quitar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Quitar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Quitar.Text = "-1";
            this.Quitar.ToolTipText = "Quitar Un Aticulo de caja";
            this.Quitar.UseColumnTextForButtonValue = true;
            this.Quitar.Visible = false;
            this.Quitar.Width = 50;
            // 
            // pnlBox
            // 
            this.pnlBox.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlBox.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlBox.Controls.Add(this.btnXVerCaja);
            this.pnlBox.Controls.Add(this.lblXnCaja);
            this.pnlBox.Controls.Add(this.lblXnCajas);
            this.pnlBox.Controls.Add(this.lblNUmero);
            this.pnlBox.Controls.Add(this.lblCant);
            this.pnlBox.Controls.Add(this.swbtnAbrir);
            this.pnlBox.Enabled = false;
            this.pnlBox.Location = new System.Drawing.Point(544, 237);
            this.pnlBox.Name = "pnlBox";
            this.pnlBox.Size = new System.Drawing.Size(216, 255);
            this.pnlBox.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlBox.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlBox.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlBox.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlBox.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlBox.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlBox.Style.GradientAngle = 90;
            this.pnlBox.TabIndex = 2;
            this.pnlBox.Tag = "                          ";
            this.pnlBox.Click += new System.EventHandler(this.pnlBox_Click);
            // 
            // lblXnCaja
            // 
            // 
            // 
            // 
            this.lblXnCaja.BackgroundStyle.Class = "";
            this.lblXnCaja.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblXnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXnCaja.Location = new System.Drawing.Point(145, 3);
            this.lblXnCaja.Name = "lblXnCaja";
            this.lblXnCaja.Size = new System.Drawing.Size(43, 23);
            this.lblXnCaja.TabIndex = 6;
            this.lblXnCaja.Text = "0";
            this.lblXnCaja.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblXnCaja.TextChanged += new System.EventHandler(this.lblXnCaja_TextChanged);
            // 
            // lblXnCajas
            // 
            // 
            // 
            // 
            this.lblXnCajas.BackgroundStyle.Class = "";
            this.lblXnCajas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblXnCajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXnCajas.Location = new System.Drawing.Point(15, 3);
            this.lblXnCajas.Name = "lblXnCajas";
            this.lblXnCajas.Size = new System.Drawing.Size(124, 23);
            this.lblXnCajas.TabIndex = 5;
            this.lblXnCajas.Text = "Caja Numero";
            this.lblXnCajas.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblNUmero
            // 
            // 
            // 
            // 
            this.lblNUmero.BackgroundStyle.Class = "";
            this.lblNUmero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNUmero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUmero.Location = new System.Drawing.Point(61, 224);
            this.lblNUmero.Name = "lblNUmero";
            this.lblNUmero.Size = new System.Drawing.Size(107, 23);
            this.lblNUmero.TabIndex = 4;
            this.lblNUmero.Text = "0";
            this.lblNUmero.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblCant
            // 
            // 
            // 
            // 
            this.lblCant.BackgroundStyle.Class = "";
            this.lblCant.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(43, 189);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(138, 36);
            this.lblCant.TabIndex = 3;
            this.lblCant.Text = "No. Articulos";
            this.lblCant.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // swbtnAbrir
            // 
            // 
            // 
            // 
            this.swbtnAbrir.BackgroundStyle.Class = "";
            this.swbtnAbrir.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swbtnAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swbtnAbrir.Location = new System.Drawing.Point(51, 164);
            this.swbtnAbrir.Name = "swbtnAbrir";
            this.swbtnAbrir.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.swbtnAbrir.OffText = "CERRADA";
            this.swbtnAbrir.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.swbtnAbrir.OnText = "ABIERTA";
            this.swbtnAbrir.Size = new System.Drawing.Size(120, 22);
            this.swbtnAbrir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swbtnAbrir.TabIndex = 2;
            this.swbtnAbrir.ValueChanged += new System.EventHandler(this.swbtnAbrir_ValueChanged);
            this.swbtnAbrir.Click += new System.EventHandler(this.swbtnAbrir_Click);
            // 
            // txtXCodigo
            // 
            this.txtXCodigo.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtXCodigo.Border.Class = "TextBoxBorder";
            this.txtXCodigo.Border.CornerDiameter = 9;
            this.txtXCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXCodigo.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXCodigo.Enabled = false;
            this.txtXCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXCodigo.Location = new System.Drawing.Point(530, 37);
            this.txtXCodigo.Name = "txtXCodigo";
            this.txtXCodigo.Size = new System.Drawing.Size(110, 34);
            this.txtXCodigo.TabIndex = 14;
            this.txtXCodigo.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtXCodigo.WatermarkText = "Codigo Art.";
            this.txtXCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXCodigo_KeyDown);
            // 
            // txtXNum
            // 
            this.txtXNum.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtXNum.Border.Class = "TextBoxBorder";
            this.txtXNum.Border.CornerDiameter = 9;
            this.txtXNum.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXNum.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXNum.Enabled = false;
            this.txtXNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXNum.Location = new System.Drawing.Point(455, 37);
            this.txtXNum.Name = "txtXNum";
            this.txtXNum.Size = new System.Drawing.Size(70, 34);
            this.txtXNum.TabIndex = 15;
            this.txtXNum.Visible = false;
            this.txtXNum.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtXNum.WatermarkText = "# Art.";
            this.txtXNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXNum_KeyDown);
            this.txtXNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXNum_KeyPress);
            // 
            // pnlXModa
            // 
            this.pnlXModa.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlXModa.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlXModa.Controls.Add(this.btnXCinto);
            this.pnlXModa.Controls.Add(this.lblXModa);
            this.pnlXModa.Controls.Add(this.cmbXModa);
            this.pnlXModa.Enabled = false;
            this.pnlXModa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlXModa.Location = new System.Drawing.Point(544, 89);
            this.pnlXModa.Name = "pnlXModa";
            this.pnlXModa.Size = new System.Drawing.Size(216, 142);
            this.pnlXModa.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlXModa.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlXModa.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlXModa.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlXModa.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlXModa.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlXModa.Style.GradientAngle = 90;
            this.pnlXModa.TabIndex = 16;
            // 
            // lblXModa
            // 
            // 
            // 
            // 
            this.lblXModa.BackgroundStyle.Class = "";
            this.lblXModa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblXModa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXModa.Location = new System.Drawing.Point(51, 4);
            this.lblXModa.Name = "lblXModa";
            this.lblXModa.Size = new System.Drawing.Size(107, 23);
            this.lblXModa.TabIndex = 11;
            this.lblXModa.Text = "Moda Caja";
            this.lblXModa.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cmbXModa
            // 
            this.cmbXModa.DisplayMember = "Text";
            this.cmbXModa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbXModa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXModa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbXModa.FormattingEnabled = true;
            this.cmbXModa.ItemHeight = 20;
            this.cmbXModa.Location = new System.Drawing.Point(16, 32);
            this.cmbXModa.Name = "cmbXModa";
            this.cmbXModa.Size = new System.Drawing.Size(187, 26);
            this.cmbXModa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbXModa.TabIndex = 10;
            this.cmbXModa.SelectedIndexChanged += new System.EventHandler(this.cmbXModa_SelectedIndexChanged);
            this.cmbXModa.SelectionChangeCommitted += new System.EventHandler(this.cmbXModa_SelectionChangeCommitted);
            // 
            // lblXorden
            // 
            // 
            // 
            // 
            this.lblXorden.BackgroundStyle.Class = "";
            this.lblXorden.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblXorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXorden.Location = new System.Drawing.Point(2, 3);
            this.lblXorden.Name = "lblXorden";
            this.lblXorden.Size = new System.Drawing.Size(194, 25);
            this.lblXorden.TabIndex = 17;
            this.lblXorden.Text = ".";
            // 
            // btnXPend
            // 
            this.btnXPend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXPend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXPend.Enabled = false;
            this.btnXPend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXPend.HoverImage = global::PakingBingBang.Properties.Resources.pausa1;
            this.btnXPend.Image = global::PakingBingBang.Properties.Resources.pausa;
            this.btnXPend.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.btnXPend.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnXPend.ImageTextSpacing = -10;
            this.btnXPend.Location = new System.Drawing.Point(264, 34);
            this.btnXPend.Name = "btnXPend";
            this.btnXPend.Size = new System.Drawing.Size(140, 48);
            this.btnXPend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXPend.TabIndex = 18;
            this.btnXPend.Text = "Caja Pendiente";
            this.btnXPend.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnXPend.Click += new System.EventHandler(this.btnXPend_Click);
            // 
            // btnXCinto
            // 
            this.btnXCinto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXCinto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXCinto.HoverImage = global::PakingBingBang.Properties.Resources.cinto2;
            this.btnXCinto.Image = global::PakingBingBang.Properties.Resources.cinto1;
            this.btnXCinto.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.btnXCinto.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnXCinto.ImageTextSpacing = -15;
            this.btnXCinto.Location = new System.Drawing.Point(16, 73);
            this.btnXCinto.Name = "btnXCinto";
            this.btnXCinto.Size = new System.Drawing.Size(187, 44);
            this.btnXCinto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXCinto.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.txtBtnXCinto});
            this.btnXCinto.TabIndex = 14;
            this.btnXCinto.Text = "Agregar Pre-Cinto";
            this.btnXCinto.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnXCinto.Tooltip = "enter para grabar";
            // 
            // txtBtnXCinto
            // 
            this.txtBtnXCinto.GlobalItem = false;
            this.txtBtnXCinto.MaxLength = 30;
            this.txtBtnXCinto.Name = "txtBtnXCinto";
            this.txtBtnXCinto.TextBoxWidth = 100;
            this.txtBtnXCinto.Tooltip = "Enter Para Grabar";
            this.txtBtnXCinto.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtBtnXCinto.WatermarkText = "Folio pre cinto";
            this.txtBtnXCinto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBtnXCinto_KeyDown);
            this.txtBtnXCinto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBtnXCinto_KeyPress);
            this.txtBtnXCinto.TextChanged += new System.EventHandler(this.txtBtnXCinto_TextChanged);
            // 
            // btnXCancel
            // 
            this.btnXCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXCancel.Enabled = false;
            this.btnXCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXCancel.HoverImage = ((System.Drawing.Image)(resources.GetObject("btnXCancel.HoverImage")));
            this.btnXCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnXCancel.Image")));
            this.btnXCancel.ImageFixedSize = new System.Drawing.Size(49, 49);
            this.btnXCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnXCancel.ImageTextSpacing = -15;
            this.btnXCancel.Location = new System.Drawing.Point(126, 34);
            this.btnXCancel.Name = "btnXCancel";
            this.btnXCancel.Size = new System.Drawing.Size(132, 48);
            this.btnXCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXCancel.TabIndex = 12;
            this.btnXCancel.Text = "Cancelar Caja";
            this.btnXCancel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnXCancel.Click += new System.EventHandler(this.btnXCancel_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.HoverImage = global::PakingBingBang.Properties.Resources.openBox1;
            this.buttonX1.Image = global::PakingBingBang.Properties.Resources.openBox2;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(23, 23);
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.buttonX1.Location = new System.Drawing.Point(2, 34);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(118, 48);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 11;
            this.buttonX1.Text = "Abrir  Caja";
            this.buttonX1.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click_1);
            // 
            // btnXAdd
            // 
            this.btnXAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnXAdd.Enabled = false;
            this.btnXAdd.HoverImage = global::PakingBingBang.Properties.Resources.add2;
            this.btnXAdd.Image = global::PakingBingBang.Properties.Resources.add;
            this.btnXAdd.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnXAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXAdd.Location = new System.Drawing.Point(656, 37);
            this.btnXAdd.Name = "btnXAdd";
            this.btnXAdd.Size = new System.Drawing.Size(56, 43);
            this.btnXAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnXAdd.TabIndex = 10;
            this.btnXAdd.Tooltip = "Buscar y Agregar";
            this.btnXAdd.Click += new System.EventHandler(this.btnXAdd_Click);
            // 
            // btnXVerCaja
            // 
            this.btnXVerCaja.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXVerCaja.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXVerCaja.Image = global::PakingBingBang.Properties.Resources.box;
            this.btnXVerCaja.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.btnXVerCaja.ImageTextSpacing = -20;
            this.btnXVerCaja.Location = new System.Drawing.Point(36, 35);
            this.btnXVerCaja.Name = "btnXVerCaja";
            this.btnXVerCaja.Size = new System.Drawing.Size(152, 123);
            this.btnXVerCaja.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXVerCaja.TabIndex = 7;
            this.btnXVerCaja.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // FRM_agregarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 494);
            this.Controls.Add(this.btnXPend);
            this.Controls.Add(this.lblXorden);
            this.Controls.Add(this.pnlXModa);
            this.Controls.Add(this.txtXNum);
            this.Controls.Add(this.txtXCodigo);
            this.Controls.Add(this.btnXCancel);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.btnXAdd);
            this.Controls.Add(this.pnlBox);
            this.Controls.Add(this.dgvArticulos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRM_agregarArticulos";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_agregarArticulos_FormClosing);
            this.Load += new System.EventHandler(this.FRM_agregarArticulos_Load);
            this.Click += new System.EventHandler(this.FRM_agregarArticulos_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.pnlBox.ResumeLayout(false);
            this.pnlXModa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Controls.DataGridViewX dgvArticulos;
        private DevComponents.DotNetBar.PanelEx pnlBox;
        private DevComponents.DotNetBar.LabelX lblCant;
        private DevComponents.DotNetBar.Controls.SwitchButton swbtnAbrir;
        public DevComponents.DotNetBar.LabelX lblNUmero;
        private DevComponents.DotNetBar.LabelX lblXnCaja;
        private DevComponents.DotNetBar.LabelX lblXnCajas;
        private DevComponents.DotNetBar.ButtonX btnXAdd;
        private DevComponents.DotNetBar.ButtonX btnXVerCaja;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnXCancel;
        private DevComponents.DotNetBar.Controls.TextBoxX txtXCodigo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtXNum;
        private DevComponents.DotNetBar.PanelEx pnlXModa;
        private DevComponents.DotNetBar.LabelX lblXModa;
        public DevComponents.DotNetBar.Controls.ComboBoxEx cmbXModa;
        private DevComponents.DotNetBar.ButtonX btnXCinto;
        private DevComponents.DotNetBar.TextBoxItem txtBtnXCinto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBCUENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talla;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovID;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn Quitar;
        public DevComponents.DotNetBar.LabelX lblXorden;
        private DevComponents.DotNetBar.ButtonX btnXPend;
    }
}