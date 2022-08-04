namespace PakingBingBang
{
    partial class FRMBuscaOrd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMBuscaOrd));
            this.gpBuscar = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnGeneraP = new DevComponents.DotNetBar.ButtonX();
            this.dgvXOrdenes = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnXAdd = new DevComponents.DotNetBar.ButtonX();
            this.txtXOrd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBuscar
            // 
            this.gpBuscar.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpBuscar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpBuscar.Controls.Add(this.btnGeneraP);
            this.gpBuscar.Controls.Add(this.dgvXOrdenes);
            this.gpBuscar.Controls.Add(this.btnXAdd);
            this.gpBuscar.Controls.Add(this.txtXOrd);
            this.gpBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpBuscar.Location = new System.Drawing.Point(0, 0);
            this.gpBuscar.Name = "gpBuscar";
            this.gpBuscar.Size = new System.Drawing.Size(972, 410);
            // 
            // 
            // 
            this.gpBuscar.Style.BackColorGradientAngle = 90;
            this.gpBuscar.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpBuscar.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpBuscar.Style.BorderBottomWidth = 1;
            this.gpBuscar.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpBuscar.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpBuscar.Style.BorderLeftWidth = 1;
            this.gpBuscar.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpBuscar.Style.BorderRightWidth = 1;
            this.gpBuscar.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpBuscar.Style.BorderTopWidth = 1;
            this.gpBuscar.Style.Class = "";
            this.gpBuscar.Style.CornerDiameter = 4;
            this.gpBuscar.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpBuscar.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpBuscar.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpBuscar.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpBuscar.StyleMouseDown.Class = "";
            this.gpBuscar.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpBuscar.StyleMouseOver.Class = "";
            this.gpBuscar.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpBuscar.TabIndex = 6;
            this.gpBuscar.Text = "Buscar y Agregar Orden Surtido";
            // 
            // btnGeneraP
            // 
            this.btnGeneraP.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGeneraP.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnGeneraP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneraP.HoverImage = global::PakingBingBang.Properties.Resources.packW;
            this.btnGeneraP.Image = global::PakingBingBang.Properties.Resources.packB;
            this.btnGeneraP.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnGeneraP.Location = new System.Drawing.Point(733, 305);
            this.btnGeneraP.Name = "btnGeneraP";
            this.btnGeneraP.Size = new System.Drawing.Size(213, 66);
            this.btnGeneraP.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnGeneraP.TabIndex = 11;
            this.btnGeneraP.Text = "Generar Packing";
            this.btnGeneraP.Tooltip = "F5";
            this.btnGeneraP.Click += new System.EventHandler(this.btn_Click);
            // 
            // dgvXOrdenes
            // 
            this.dgvXOrdenes.AllowUserToAddRows = false;
            this.dgvXOrdenes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXOrdenes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXOrdenes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvXOrdenes.Location = new System.Drawing.Point(3, 66);
            this.dgvXOrdenes.Name = "dgvXOrdenes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXOrdenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvXOrdenes.Size = new System.Drawing.Size(943, 233);
            this.dgvXOrdenes.TabIndex = 10;
            this.dgvXOrdenes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXOrd_KeyDown);
            // 
            // btnXAdd
            // 
            this.btnXAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnXAdd.HoverImage = global::PakingBingBang.Properties.Resources.findW;
            this.btnXAdd.Image = global::PakingBingBang.Properties.Resources.findB;
            this.btnXAdd.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnXAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXAdd.Location = new System.Drawing.Point(216, 10);
            this.btnXAdd.Name = "btnXAdd";
            this.btnXAdd.Size = new System.Drawing.Size(76, 44);
            this.btnXAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnXAdd.TabIndex = 9;
            this.btnXAdd.Tooltip = "Buscar Orden de Pedido";
            this.btnXAdd.Click += new System.EventHandler(this.btnXAdd_Click);
            // 
            // txtXOrd
            // 
            this.txtXOrd.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtXOrd.Border.Class = "TextBoxBorder";
            this.txtXOrd.Border.CornerDiameter = 9;
            this.txtXOrd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXOrd.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtXOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXOrd.Location = new System.Drawing.Point(14, 20);
            this.txtXOrd.Name = "txtXOrd";
            this.txtXOrd.Size = new System.Drawing.Size(169, 34);
            this.txtXOrd.TabIndex = 3;
            this.txtXOrd.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.txtXOrd.WatermarkText = "Numero de Orden";
            this.txtXOrd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXOrd_KeyDown);
            this.txtXOrd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtXOrd_KeyPress);
            // 
            // FRMBuscaOrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 410);
            this.Controls.Add(this.gpBuscar);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMBuscaOrd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = resources.GetString("$this.Text");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMBuscaOrd_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRMBuscaOrd_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRMBuscaOrd_KeyPress);
            this.gpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gpBuscar;
        public DevComponents.DotNetBar.Controls.DataGridViewX dgvXOrdenes;
        private DevComponents.DotNetBar.ButtonX btnXAdd;
        private DevComponents.DotNetBar.Controls.TextBoxX txtXOrd;
        private DevComponents.DotNetBar.ButtonX btnGeneraP;
    }
}