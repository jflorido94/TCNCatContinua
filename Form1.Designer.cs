
using System;

namespace Historial_Catergorias_Articulos
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbFiltradoFam = new System.Windows.Forms.GroupBox();
            this.lbHastaFam = new System.Windows.Forms.Label();
            this.dtpHastaFam = new System.Windows.Forms.DateTimePicker();
            this.lbCodArticuloFam = new System.Windows.Forms.Label();
            this.tbCodArticuloFam = new System.Windows.Forms.TextBox();
            this.lbDesdeFam = new System.Windows.Forms.Label();
            this.dtpDesdeFam = new System.Windows.Forms.DateTimePicker();
            this.lbOldFamiliaFam = new System.Windows.Forms.Label();
            this.lbArticuloCat = new System.Windows.Forms.Label();
            this.btnLimpiarFam = new System.Windows.Forms.Button();
            this.lbNewFamiliaFam = new System.Windows.Forms.Label();
            this.cbNewFamiliaFam = new System.Windows.Forms.ComboBox();
            this.tbArticuloFam = new System.Windows.Forms.TextBox();
            this.cbOldFamiliaFam = new System.Windows.Forms.ComboBox();
            this.gbActualizarFam = new System.Windows.Forms.GroupBox();
            this.btnActualizarFam = new System.Windows.Forms.Button();
            this.dgvFam = new System.Windows.Forms.DataGridView();
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpCate = new System.Windows.Forms.TabPage();
            this.tpGTerap = new System.Windows.Forms.TabPage();
            this.dgvGT = new System.Windows.Forms.DataGridView();
            this.gbActualizarGT = new System.Windows.Forms.GroupBox();
            this.btActualizarGT = new System.Windows.Forms.Button();
            this.gbFiltradoGT = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescripcionGT = new System.Windows.Forms.TextBox();
            this.lbFamiliaGT = new System.Windows.Forms.Label();
            this.cbFamiliaGT = new System.Windows.Forms.ComboBox();
            this.lbHastaGT = new System.Windows.Forms.Label();
            this.dtpHastaGT = new System.Windows.Forms.DateTimePicker();
            this.lbDesdeGT = new System.Windows.Forms.Label();
            this.dtpDesdeGT = new System.Windows.Forms.DateTimePicker();
            this.lbAccionGT = new System.Windows.Forms.Label();
            this.lbGrupoTerapeutico = new System.Windows.Forms.Label();
            this.btLimpiarGT = new System.Windows.Forms.Button();
            this.tbCodigoGT = new System.Windows.Forms.TextBox();
            this.cbAccionGT = new System.Windows.Forms.ComboBox();
            this.ttLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.gbFiltradoFam.SuspendLayout();
            this.gbActualizarFam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFam)).BeginInit();
            this.tcPrincipal.SuspendLayout();
            this.tpCate.SuspendLayout();
            this.tpGTerap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGT)).BeginInit();
            this.gbActualizarGT.SuspendLayout();
            this.gbFiltradoGT.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltradoFam
            // 
            this.gbFiltradoFam.Controls.Add(this.lbHastaFam);
            this.gbFiltradoFam.Controls.Add(this.dtpHastaFam);
            this.gbFiltradoFam.Controls.Add(this.lbCodArticuloFam);
            this.gbFiltradoFam.Controls.Add(this.tbCodArticuloFam);
            this.gbFiltradoFam.Controls.Add(this.lbDesdeFam);
            this.gbFiltradoFam.Controls.Add(this.dtpDesdeFam);
            this.gbFiltradoFam.Controls.Add(this.lbOldFamiliaFam);
            this.gbFiltradoFam.Controls.Add(this.lbArticuloCat);
            this.gbFiltradoFam.Controls.Add(this.btnLimpiarFam);
            this.gbFiltradoFam.Controls.Add(this.lbNewFamiliaFam);
            this.gbFiltradoFam.Controls.Add(this.cbNewFamiliaFam);
            this.gbFiltradoFam.Controls.Add(this.tbArticuloFam);
            this.gbFiltradoFam.Controls.Add(this.cbOldFamiliaFam);
            this.gbFiltradoFam.Location = new System.Drawing.Point(6, 9);
            this.gbFiltradoFam.Name = "gbFiltradoFam";
            this.gbFiltradoFam.Size = new System.Drawing.Size(817, 85);
            this.gbFiltradoFam.TabIndex = 9;
            this.gbFiltradoFam.TabStop = false;
            this.gbFiltradoFam.Text = "Filtrar";
            // 
            // lbHastaFam
            // 
            this.lbHastaFam.AutoSize = true;
            this.lbHastaFam.Location = new System.Drawing.Point(12, 52);
            this.lbHastaFam.Name = "lbHastaFam";
            this.lbHastaFam.Size = new System.Drawing.Size(35, 13);
            this.lbHastaFam.TabIndex = 13;
            this.lbHastaFam.Text = "Hasta";
            // 
            // dtpHastaFam
            // 
            this.dtpHastaFam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaFam.Location = new System.Drawing.Point(53, 49);
            this.dtpHastaFam.Name = "dtpHastaFam";
            this.dtpHastaFam.Size = new System.Drawing.Size(122, 20);
            this.dtpHastaFam.TabIndex = 2;
            this.dtpHastaFam.Value = new System.DateTime(2021, 4, 27, 12, 35, 24, 900);
            this.dtpHastaFam.ValueChanged += new System.EventHandler(this.dtpHastaFam_ValueChanged);
            // 
            // lbCodArticuloFam
            // 
            this.lbCodArticuloFam.AutoSize = true;
            this.lbCodArticuloFam.Location = new System.Drawing.Point(479, 25);
            this.lbCodArticuloFam.Name = "lbCodArticuloFam";
            this.lbCodArticuloFam.Size = new System.Drawing.Size(31, 13);
            this.lbCodArticuloFam.TabIndex = 11;
            this.lbCodArticuloFam.Text = "C. N.";
            // 
            // tbCodArticuloFam
            // 
            this.tbCodArticuloFam.Location = new System.Drawing.Point(524, 22);
            this.tbCodArticuloFam.Name = "tbCodArticuloFam";
            this.tbCodArticuloFam.Size = new System.Drawing.Size(193, 20);
            this.tbCodArticuloFam.TabIndex = 5;
            this.tbCodArticuloFam.TextChanged += new System.EventHandler(this.tbCodArticuloFam_TextChanged);
            // 
            // lbDesdeFam
            // 
            this.lbDesdeFam.AutoSize = true;
            this.lbDesdeFam.Location = new System.Drawing.Point(9, 25);
            this.lbDesdeFam.Name = "lbDesdeFam";
            this.lbDesdeFam.Size = new System.Drawing.Size(38, 13);
            this.lbDesdeFam.TabIndex = 9;
            this.lbDesdeFam.Text = "Desde";
            // 
            // dtpDesdeFam
            // 
            this.dtpDesdeFam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeFam.Location = new System.Drawing.Point(53, 23);
            this.dtpDesdeFam.Name = "dtpDesdeFam";
            this.dtpDesdeFam.Size = new System.Drawing.Size(122, 20);
            this.dtpDesdeFam.TabIndex = 1;
            this.dtpDesdeFam.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpDesdeFam.ValueChanged += new System.EventHandler(this.dtpDesdeFam_ValueChanged);
            // 
            // lbOldFamiliaFam
            // 
            this.lbOldFamiliaFam.AutoSize = true;
            this.lbOldFamiliaFam.Location = new System.Drawing.Point(181, 25);
            this.lbOldFamiliaFam.Name = "lbOldFamiliaFam";
            this.lbOldFamiliaFam.Size = new System.Drawing.Size(78, 13);
            this.lbOldFamiliaFam.TabIndex = 7;
            this.lbOldFamiliaFam.Text = "Familia Anterior";
            // 
            // lbArticuloCat
            // 
            this.lbArticuloCat.AutoSize = true;
            this.lbArticuloCat.Location = new System.Drawing.Point(479, 52);
            this.lbArticuloCat.Name = "lbArticuloCat";
            this.lbArticuloCat.Size = new System.Drawing.Size(44, 13);
            this.lbArticuloCat.TabIndex = 5;
            this.lbArticuloCat.Text = "Artículo";
            // 
            // btnLimpiarFam
            // 
            this.btnLimpiarFam.Location = new System.Drawing.Point(736, 36);
            this.btnLimpiarFam.Name = "btnLimpiarFam";
            this.btnLimpiarFam.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFam.TabIndex = 7;
            this.btnLimpiarFam.Text = "Limpiar";
            this.ttLimpiar.SetToolTip(this.btnLimpiarFam, "Quitar filtros");
            this.btnLimpiarFam.UseVisualStyleBackColor = true;
            this.btnLimpiarFam.Click += new System.EventHandler(this.btnLimpiarFam_Click);
            // 
            // lbNewFamiliaFam
            // 
            this.lbNewFamiliaFam.AutoSize = true;
            this.lbNewFamiliaFam.Location = new System.Drawing.Point(181, 52);
            this.lbNewFamiliaFam.Name = "lbNewFamiliaFam";
            this.lbNewFamiliaFam.Size = new System.Drawing.Size(72, 13);
            this.lbNewFamiliaFam.TabIndex = 4;
            this.lbNewFamiliaFam.Text = "Familia Actual";
            // 
            // cbNewFamiliaFam
            // 
            this.cbNewFamiliaFam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNewFamiliaFam.FormattingEnabled = true;
            this.cbNewFamiliaFam.Location = new System.Drawing.Point(265, 49);
            this.cbNewFamiliaFam.Name = "cbNewFamiliaFam";
            this.cbNewFamiliaFam.Size = new System.Drawing.Size(208, 21);
            this.cbNewFamiliaFam.TabIndex = 4;
            this.cbNewFamiliaFam.SelectedIndexChanged += new System.EventHandler(this.cbNewFamiliaFam_SelectedIndexChanged);
            // 
            // tbArticuloFam
            // 
            this.tbArticuloFam.Location = new System.Drawing.Point(524, 49);
            this.tbArticuloFam.Name = "tbArticuloFam";
            this.tbArticuloFam.Size = new System.Drawing.Size(193, 20);
            this.tbArticuloFam.TabIndex = 6;
            this.tbArticuloFam.TextChanged += new System.EventHandler(this.tbArticuloFam_TextChanged);
            // 
            // cbOldFamiliaFam
            // 
            this.cbOldFamiliaFam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOldFamiliaFam.FormattingEnabled = true;
            this.cbOldFamiliaFam.Location = new System.Drawing.Point(265, 22);
            this.cbOldFamiliaFam.Name = "cbOldFamiliaFam";
            this.cbOldFamiliaFam.Size = new System.Drawing.Size(208, 21);
            this.cbOldFamiliaFam.TabIndex = 3;
            this.cbOldFamiliaFam.SelectedIndexChanged += new System.EventHandler(this.cbOldFamiliaFam_SelectedIndexChanged);
            // 
            // gbActualizarFam
            // 
            this.gbActualizarFam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbActualizarFam.Controls.Add(this.btnActualizarFam);
            this.gbActualizarFam.Location = new System.Drawing.Point(837, 9);
            this.gbActualizarFam.Name = "gbActualizarFam";
            this.gbActualizarFam.Size = new System.Drawing.Size(136, 85);
            this.gbActualizarFam.TabIndex = 10;
            this.gbActualizarFam.TabStop = false;
            this.gbActualizarFam.Text = "Actualizar";
            // 
            // btnActualizarFam
            // 
            this.btnActualizarFam.Location = new System.Drawing.Point(35, 36);
            this.btnActualizarFam.Name = "btnActualizarFam";
            this.btnActualizarFam.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarFam.TabIndex = 8;
            this.btnActualizarFam.Text = "Actualizar";
            this.ttLimpiar.SetToolTip(this.btnActualizarFam, "Actualizar información desde la base de datos");
            this.btnActualizarFam.UseVisualStyleBackColor = true;
            this.btnActualizarFam.Click += new System.EventHandler(this.btnActualizarFam_Click);
            // 
            // dgvFam
            // 
            this.dgvFam.AllowUserToAddRows = false;
            this.dgvFam.AllowUserToDeleteRows = false;
            this.dgvFam.AllowUserToOrderColumns = true;
            this.dgvFam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFam.Location = new System.Drawing.Point(6, 100);
            this.dgvFam.Name = "dgvFam";
            this.dgvFam.ReadOnly = true;
            this.dgvFam.Size = new System.Drawing.Size(967, 408);
            this.dgvFam.TabIndex = 20;
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpCate);
            this.tcPrincipal.Controls.Add(this.tpGTerap);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcPrincipal.MinimumSize = new System.Drawing.Size(990, 540);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(1013, 564);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tpCate
            // 
            this.tpCate.Controls.Add(this.dgvFam);
            this.tpCate.Controls.Add(this.gbActualizarFam);
            this.tpCate.Controls.Add(this.gbFiltradoFam);
            this.tpCate.Location = new System.Drawing.Point(4, 22);
            this.tpCate.Name = "tpCate";
            this.tpCate.Padding = new System.Windows.Forms.Padding(3);
            this.tpCate.Size = new System.Drawing.Size(1005, 538);
            this.tpCate.TabIndex = 0;
            this.tpCate.Text = "Familias";
            this.tpCate.UseVisualStyleBackColor = true;
            // 
            // tpGTerap
            // 
            this.tpGTerap.Controls.Add(this.dgvGT);
            this.tpGTerap.Controls.Add(this.gbActualizarGT);
            this.tpGTerap.Controls.Add(this.gbFiltradoGT);
            this.tpGTerap.Location = new System.Drawing.Point(4, 22);
            this.tpGTerap.Name = "tpGTerap";
            this.tpGTerap.Padding = new System.Windows.Forms.Padding(3);
            this.tpGTerap.Size = new System.Drawing.Size(1005, 538);
            this.tpGTerap.TabIndex = 1;
            this.tpGTerap.Text = "GT - Familias";
            this.tpGTerap.UseVisualStyleBackColor = true;
            // 
            // dgvGT
            // 
            this.dgvGT.AllowUserToAddRows = false;
            this.dgvGT.AllowUserToDeleteRows = false;
            this.dgvGT.AllowUserToOrderColumns = true;
            this.dgvGT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGT.Location = new System.Drawing.Point(6, 100);
            this.dgvGT.Name = "dgvGT";
            this.dgvGT.ReadOnly = true;
            this.dgvGT.Size = new System.Drawing.Size(967, 408);
            this.dgvGT.TabIndex = 20;
            // 
            // gbActualizarGT
            // 
            this.gbActualizarGT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbActualizarGT.Controls.Add(this.btActualizarGT);
            this.gbActualizarGT.Location = new System.Drawing.Point(837, 9);
            this.gbActualizarGT.Name = "gbActualizarGT";
            this.gbActualizarGT.Size = new System.Drawing.Size(136, 85);
            this.gbActualizarGT.TabIndex = 13;
            this.gbActualizarGT.TabStop = false;
            this.gbActualizarGT.Text = "Actualizar";
            // 
            // btActualizarGT
            // 
            this.btActualizarGT.Location = new System.Drawing.Point(35, 36);
            this.btActualizarGT.Name = "btActualizarGT";
            this.btActualizarGT.Size = new System.Drawing.Size(75, 23);
            this.btActualizarGT.TabIndex = 8;
            this.btActualizarGT.Text = "Actualizar";
            this.ttLimpiar.SetToolTip(this.btActualizarGT, "Actualizar información desde la base de datos");
            this.btActualizarGT.UseVisualStyleBackColor = true;
            this.btActualizarGT.Click += new System.EventHandler(this.btActualizarGT_Click);
            // 
            // gbFiltradoGT
            // 
            this.gbFiltradoGT.Controls.Add(this.label1);
            this.gbFiltradoGT.Controls.Add(this.tbDescripcionGT);
            this.gbFiltradoGT.Controls.Add(this.lbFamiliaGT);
            this.gbFiltradoGT.Controls.Add(this.cbFamiliaGT);
            this.gbFiltradoGT.Controls.Add(this.lbHastaGT);
            this.gbFiltradoGT.Controls.Add(this.dtpHastaGT);
            this.gbFiltradoGT.Controls.Add(this.lbDesdeGT);
            this.gbFiltradoGT.Controls.Add(this.dtpDesdeGT);
            this.gbFiltradoGT.Controls.Add(this.lbAccionGT);
            this.gbFiltradoGT.Controls.Add(this.lbGrupoTerapeutico);
            this.gbFiltradoGT.Controls.Add(this.btLimpiarGT);
            this.gbFiltradoGT.Controls.Add(this.tbCodigoGT);
            this.gbFiltradoGT.Controls.Add(this.cbAccionGT);
            this.gbFiltradoGT.Location = new System.Drawing.Point(6, 9);
            this.gbFiltradoGT.Name = "gbFiltradoGT";
            this.gbFiltradoGT.Size = new System.Drawing.Size(817, 85);
            this.gbFiltradoGT.TabIndex = 12;
            this.gbFiltradoGT.TabStop = false;
            this.gbFiltradoGT.Text = "Filtrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descrip. Grupo";
            // 
            // tbDescripcionGT
            // 
            this.tbDescripcionGT.Location = new System.Drawing.Point(524, 48);
            this.tbDescripcionGT.Name = "tbDescripcionGT";
            this.tbDescripcionGT.Size = new System.Drawing.Size(193, 20);
            this.tbDescripcionGT.TabIndex = 6;
            this.tbDescripcionGT.TextChanged += new System.EventHandler(this.tbDescripcionGT_TextChanged);
            // 
            // lbFamiliaGT
            // 
            this.lbFamiliaGT.AutoSize = true;
            this.lbFamiliaGT.Location = new System.Drawing.Point(192, 51);
            this.lbFamiliaGT.Name = "lbFamiliaGT";
            this.lbFamiliaGT.Size = new System.Drawing.Size(39, 13);
            this.lbFamiliaGT.TabIndex = 13;
            this.lbFamiliaGT.Text = "Familia";
            // 
            // cbFamiliaGT
            // 
            this.cbFamiliaGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFamiliaGT.FormattingEnabled = true;
            this.cbFamiliaGT.Location = new System.Drawing.Point(238, 48);
            this.cbFamiliaGT.Name = "cbFamiliaGT";
            this.cbFamiliaGT.Size = new System.Drawing.Size(191, 21);
            this.cbFamiliaGT.TabIndex = 4;
            this.cbFamiliaGT.SelectedIndexChanged += new System.EventHandler(this.cbFamiliaGT_SelectedIndexChanged);
            // 
            // lbHastaGT
            // 
            this.lbHastaGT.AutoSize = true;
            this.lbHastaGT.Location = new System.Drawing.Point(9, 51);
            this.lbHastaGT.Name = "lbHastaGT";
            this.lbHastaGT.Size = new System.Drawing.Size(35, 13);
            this.lbHastaGT.TabIndex = 11;
            this.lbHastaGT.Text = "Hasta";
            // 
            // dtpHastaGT
            // 
            this.dtpHastaGT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaGT.Location = new System.Drawing.Point(53, 49);
            this.dtpHastaGT.Name = "dtpHastaGT";
            this.dtpHastaGT.Size = new System.Drawing.Size(122, 20);
            this.dtpHastaGT.TabIndex = 2;
            this.dtpHastaGT.Value = new System.DateTime(2021, 4, 27, 12, 35, 25, 401);
            this.dtpHastaGT.ValueChanged += new System.EventHandler(this.dtpHastaGT_ValueChanged);
            // 
            // lbDesdeGT
            // 
            this.lbDesdeGT.AutoSize = true;
            this.lbDesdeGT.Location = new System.Drawing.Point(9, 25);
            this.lbDesdeGT.Name = "lbDesdeGT";
            this.lbDesdeGT.Size = new System.Drawing.Size(38, 13);
            this.lbDesdeGT.TabIndex = 9;
            this.lbDesdeGT.Text = "Desde";
            // 
            // dtpDesdeGT
            // 
            this.dtpDesdeGT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeGT.Location = new System.Drawing.Point(53, 23);
            this.dtpDesdeGT.Name = "dtpDesdeGT";
            this.dtpDesdeGT.Size = new System.Drawing.Size(122, 20);
            this.dtpDesdeGT.TabIndex = 1;
            this.dtpDesdeGT.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpDesdeGT.ValueChanged += new System.EventHandler(this.dtpDesdeGT_ValueChanged);
            // 
            // lbAccionGT
            // 
            this.lbAccionGT.AutoSize = true;
            this.lbAccionGT.Location = new System.Drawing.Point(192, 25);
            this.lbAccionGT.Name = "lbAccionGT";
            this.lbAccionGT.Size = new System.Drawing.Size(40, 13);
            this.lbAccionGT.TabIndex = 7;
            this.lbAccionGT.Text = "Acción";
            // 
            // lbGrupoTerapeutico
            // 
            this.lbGrupoTerapeutico.AutoSize = true;
            this.lbGrupoTerapeutico.Location = new System.Drawing.Point(440, 25);
            this.lbGrupoTerapeutico.Name = "lbGrupoTerapeutico";
            this.lbGrupoTerapeutico.Size = new System.Drawing.Size(72, 13);
            this.lbGrupoTerapeutico.TabIndex = 5;
            this.lbGrupoTerapeutico.Text = "Código Grupo";
            // 
            // btLimpiarGT
            // 
            this.btLimpiarGT.Location = new System.Drawing.Point(736, 36);
            this.btLimpiarGT.Name = "btLimpiarGT";
            this.btLimpiarGT.Size = new System.Drawing.Size(75, 23);
            this.btLimpiarGT.TabIndex = 7;
            this.btLimpiarGT.Text = "Limpiar";
            this.ttLimpiar.SetToolTip(this.btLimpiarGT, "Quitar filtros");
            this.btLimpiarGT.UseVisualStyleBackColor = true;
            this.btLimpiarGT.Click += new System.EventHandler(this.btLimpiarGT_Click);
            // 
            // tbCodigoGT
            // 
            this.tbCodigoGT.Location = new System.Drawing.Point(524, 22);
            this.tbCodigoGT.Name = "tbCodigoGT";
            this.tbCodigoGT.Size = new System.Drawing.Size(193, 20);
            this.tbCodigoGT.TabIndex = 5;
            this.tbCodigoGT.TextChanged += new System.EventHandler(this.tbCodigoGT_TextChanged);
            // 
            // cbAccionGT
            // 
            this.cbAccionGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccionGT.FormattingEnabled = true;
            this.cbAccionGT.Location = new System.Drawing.Point(238, 22);
            this.cbAccionGT.Name = "cbAccionGT";
            this.cbAccionGT.Size = new System.Drawing.Size(191, 21);
            this.cbAccionGT.TabIndex = 3;
            this.cbAccionGT.SelectedIndexChanged += new System.EventHandler(this.cbAccionGT_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1013, 564);
            this.Controls.Add(this.tcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Historial Articulos y GT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFiltradoFam.ResumeLayout(false);
            this.gbFiltradoFam.PerformLayout();
            this.gbActualizarFam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFam)).EndInit();
            this.tcPrincipal.ResumeLayout(false);
            this.tpCate.ResumeLayout(false);
            this.tpGTerap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGT)).EndInit();
            this.gbActualizarGT.ResumeLayout(false);
            this.gbFiltradoGT.ResumeLayout(false);
            this.gbFiltradoGT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltradoFam;
        private System.Windows.Forms.Label lbDesdeFam;
        private System.Windows.Forms.DateTimePicker dtpDesdeFam;
        private System.Windows.Forms.Label lbOldFamiliaFam;
        private System.Windows.Forms.ComboBox cbOldFamiliaFam;
        private System.Windows.Forms.Label lbArticuloCat;
        private System.Windows.Forms.Button btnLimpiarFam;
        private System.Windows.Forms.Label lbNewFamiliaFam;
        private System.Windows.Forms.ComboBox cbNewFamiliaFam;
        private System.Windows.Forms.TextBox tbArticuloFam;
        private System.Windows.Forms.GroupBox gbActualizarFam;
        private System.Windows.Forms.Button btnActualizarFam;
        private System.Windows.Forms.DataGridView dgvFam;
        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpGTerap;
        private System.Windows.Forms.TabPage tpCate;
        private System.Windows.Forms.DataGridView dgvGT;
        private System.Windows.Forms.GroupBox gbActualizarGT;
        private System.Windows.Forms.Button btActualizarGT;
        private System.Windows.Forms.GroupBox gbFiltradoGT;
        private System.Windows.Forms.Label lbDesdeGT;
        private System.Windows.Forms.DateTimePicker dtpDesdeGT;
        private System.Windows.Forms.Label lbAccionGT;
        private System.Windows.Forms.Label lbGrupoTerapeutico;
        private System.Windows.Forms.Button btLimpiarGT;
        private System.Windows.Forms.TextBox tbCodigoGT;
        private System.Windows.Forms.ComboBox cbAccionGT;
        private System.Windows.Forms.Label lbHastaFam;
        private System.Windows.Forms.DateTimePicker dtpHastaFam;
        private System.Windows.Forms.Label lbCodArticuloFam;
        private System.Windows.Forms.TextBox tbCodArticuloFam;
        private System.Windows.Forms.Label lbHastaGT;
        private System.Windows.Forms.DateTimePicker dtpHastaGT;
        private System.Windows.Forms.Label lbFamiliaGT;
        private System.Windows.Forms.ComboBox cbFamiliaGT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescripcionGT;
        private System.Windows.Forms.ToolTip ttLimpiar;
    }
}

