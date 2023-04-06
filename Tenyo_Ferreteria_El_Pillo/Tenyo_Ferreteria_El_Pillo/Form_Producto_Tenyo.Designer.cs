
namespace Tenyo_Ferreteria_El_Pillo
{
    partial class Form_Producto_Tenyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Producto_Tenyo));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblClaveProd = new System.Windows.Forms.Label();
            this.txtClaveProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoProd = new System.Windows.Forms.Label();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblPasillo = new System.Windows.Forms.Label();
            this.cmbPasillo = new System.Windows.Forms.ComboBox();
            this.lblEstante = new System.Windows.Forms.Label();
            this.cmbEstante = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblNivelCompetencia = new System.Windows.Forms.Label();
            this.spnNivelCompetencia = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.spnCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.spnExistencias = new System.Windows.Forms.NumericUpDown();
            this.lblStockMin = new System.Windows.Forms.Label();
            this.lblStockMax = new System.Windows.Forms.Label();
            this.spnStockMin = new System.Windows.Forms.NumericUpDown();
            this.spnStockMax = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioMayoreo = new System.Windows.Forms.Label();
            this.lblPrecioPublico = new System.Windows.Forms.Label();
            this.spnPrecioMayoreo = new System.Windows.Forms.NumericUpDown();
            this.spnPrecioPublico = new System.Windows.Forms.NumericUpDown();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.cmbDescuento = new System.Windows.Forms.ComboBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.spnNivelCompetencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnExistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnStockMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnStockMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecioMayoreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecioPublico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Algerian", 20.25F);
            this.lblTitulo.Location = new System.Drawing.Point(307, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PRODUCTOS";
            // 
            // lblClaveProd
            // 
            this.lblClaveProd.AutoSize = true;
            this.lblClaveProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveProd.Location = new System.Drawing.Point(393, 61);
            this.lblClaveProd.Name = "lblClaveProd";
            this.lblClaveProd.Size = new System.Drawing.Size(142, 20);
            this.lblClaveProd.TabIndex = 1;
            this.lblClaveProd.Text = "Clave de Producto:";
            // 
            // txtClaveProducto
            // 
            this.txtClaveProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveProducto.Location = new System.Drawing.Point(543, 60);
            this.txtClaveProducto.MaxLength = 30;
            this.txtClaveProducto.Name = "txtClaveProducto";
            this.txtClaveProducto.ShortcutsEnabled = false;
            this.txtClaveProducto.Size = new System.Drawing.Size(175, 20);
            this.txtClaveProducto.TabIndex = 2;
            // 
            // lblCodigoProd
            // 
            this.lblCodigoProd.AutoSize = true;
            this.lblCodigoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProd.Location = new System.Drawing.Point(39, 60);
            this.lblCodigoProd.Name = "lblCodigoProd";
            this.lblCodigoProd.Size = new System.Drawing.Size(153, 20);
            this.lblCodigoProd.TabIndex = 3;
            this.lblCodigoProd.Text = "Codigo de Producto:";
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoProd.Location = new System.Drawing.Point(194, 61);
            this.txtCodigoProd.MaxLength = 10;
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.ShortcutsEnabled = false;
            this.txtCodigoProd.Size = new System.Drawing.Size(175, 20);
            this.txtCodigoProd.TabIndex = 1;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(38, 134);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(116, 20);
            this.lblDepartamento.TabIndex = 5;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(158, 134);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(198, 21);
            this.cmbDepartamento.TabIndex = 5;
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            this.cmbDepartamento.Click += new System.EventHandler(this.cmbDepartamento_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(40, 169);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 20);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "Marca:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(105, 169);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(153, 21);
            this.cmbMarca.TabIndex = 7;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            this.cmbMarca.Click += new System.EventHandler(this.cmbMarca_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(38, 98);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(82, 20);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(121, 99);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(359, 21);
            this.cmbCategoria.TabIndex = 3;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            this.cmbCategoria.Click += new System.EventHandler(this.cmbCategoria_Click);
            // 
            // lblPasillo
            // 
            this.lblPasillo.AutoSize = true;
            this.lblPasillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasillo.Location = new System.Drawing.Point(288, 171);
            this.lblPasillo.Name = "lblPasillo";
            this.lblPasillo.Size = new System.Drawing.Size(58, 20);
            this.lblPasillo.TabIndex = 11;
            this.lblPasillo.Text = "Pasillo:";
            // 
            // cmbPasillo
            // 
            this.cmbPasillo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPasillo.FormattingEnabled = true;
            this.cmbPasillo.Location = new System.Drawing.Point(352, 171);
            this.cmbPasillo.Name = "cmbPasillo";
            this.cmbPasillo.Size = new System.Drawing.Size(128, 21);
            this.cmbPasillo.TabIndex = 8;
            this.cmbPasillo.SelectedIndexChanged += new System.EventHandler(this.cmbPasillo_SelectedIndexChanged);
            this.cmbPasillo.Click += new System.EventHandler(this.cmbPasillo_Click);
            // 
            // lblEstante
            // 
            this.lblEstante.AutoSize = true;
            this.lblEstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstante.Location = new System.Drawing.Point(497, 172);
            this.lblEstante.Name = "lblEstante";
            this.lblEstante.Size = new System.Drawing.Size(69, 20);
            this.lblEstante.TabIndex = 13;
            this.lblEstante.Text = "Estante:";
            // 
            // cmbEstante
            // 
            this.cmbEstante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstante.FormattingEnabled = true;
            this.cmbEstante.Location = new System.Drawing.Point(572, 174);
            this.cmbEstante.Name = "cmbEstante";
            this.cmbEstante.Size = new System.Drawing.Size(146, 21);
            this.cmbEstante.TabIndex = 9;
            this.cmbEstante.SelectedIndexChanged += new System.EventHandler(this.cmbEstante_SelectedIndexChanged);
            this.cmbEstante.Click += new System.EventHandler(this.cmbEstante_Click);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(397, 137);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(69, 20);
            this.lblMaterial.TabIndex = 15;
            this.lblMaterial.Text = "Material:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(472, 136);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(246, 21);
            this.cmbMaterial.TabIndex = 6;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            this.cmbMaterial.Click += new System.EventHandler(this.cmbMaterial_Click);
            // 
            // lblNivelCompetencia
            // 
            this.lblNivelCompetencia.AutoSize = true;
            this.lblNivelCompetencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelCompetencia.Location = new System.Drawing.Point(497, 100);
            this.lblNivelCompetencia.Name = "lblNivelCompetencia";
            this.lblNivelCompetencia.Size = new System.Drawing.Size(144, 20);
            this.lblNivelCompetencia.TabIndex = 17;
            this.lblNivelCompetencia.Text = "Nivel Competencia:";
            // 
            // spnNivelCompetencia
            // 
            this.spnNivelCompetencia.Location = new System.Drawing.Point(644, 100);
            this.spnNivelCompetencia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spnNivelCompetencia.Name = "spnNivelCompetencia";
            this.spnNivelCompetencia.Size = new System.Drawing.Size(74, 20);
            this.spnNivelCompetencia.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(38, 205);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // spnCantidad
            // 
            this.spnCantidad.Location = new System.Drawing.Point(130, 206);
            this.spnCantidad.Maximum = new decimal(new int[] {
            32765,
            0,
            0,
            0});
            this.spnCantidad.Name = "spnCantidad";
            this.spnCantidad.Size = new System.Drawing.Size(128, 20);
            this.spnCantidad.TabIndex = 10;
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencias.Location = new System.Drawing.Point(38, 239);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(93, 20);
            this.lblExistencias.TabIndex = 21;
            this.lblExistencias.Text = "Existencias:";
            // 
            // spnExistencias
            // 
            this.spnExistencias.Location = new System.Drawing.Point(132, 239);
            this.spnExistencias.Maximum = new decimal(new int[] {
            32765,
            0,
            0,
            0});
            this.spnExistencias.Name = "spnExistencias";
            this.spnExistencias.Size = new System.Drawing.Size(126, 20);
            this.spnExistencias.TabIndex = 11;
            // 
            // lblStockMin
            // 
            this.lblStockMin.AutoSize = true;
            this.lblStockMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMin.Location = new System.Drawing.Point(288, 206);
            this.lblStockMin.Name = "lblStockMin";
            this.lblStockMin.Size = new System.Drawing.Size(108, 20);
            this.lblStockMin.TabIndex = 23;
            this.lblStockMin.Text = "Stock Minimo:";
            // 
            // lblStockMax
            // 
            this.lblStockMax.AutoSize = true;
            this.lblStockMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMax.Location = new System.Drawing.Point(288, 239);
            this.lblStockMax.Name = "lblStockMax";
            this.lblStockMax.Size = new System.Drawing.Size(112, 20);
            this.lblStockMax.TabIndex = 24;
            this.lblStockMax.Text = "Stock Maximo:";
            // 
            // spnStockMin
            // 
            this.spnStockMin.Location = new System.Drawing.Point(406, 207);
            this.spnStockMin.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.spnStockMin.Name = "spnStockMin";
            this.spnStockMin.Size = new System.Drawing.Size(74, 20);
            this.spnStockMin.TabIndex = 12;
            // 
            // spnStockMax
            // 
            this.spnStockMax.Location = new System.Drawing.Point(406, 240);
            this.spnStockMax.Maximum = new decimal(new int[] {
            32765,
            0,
            0,
            0});
            this.spnStockMax.Name = "spnStockMax";
            this.spnStockMax.Size = new System.Drawing.Size(74, 20);
            this.spnStockMax.TabIndex = 13;
            // 
            // lblPrecioMayoreo
            // 
            this.lblPrecioMayoreo.AutoSize = true;
            this.lblPrecioMayoreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMayoreo.Location = new System.Drawing.Point(497, 208);
            this.lblPrecioMayoreo.Name = "lblPrecioMayoreo";
            this.lblPrecioMayoreo.Size = new System.Drawing.Size(122, 20);
            this.lblPrecioMayoreo.TabIndex = 27;
            this.lblPrecioMayoreo.Text = "Precio Mayoreo:";
            // 
            // lblPrecioPublico
            // 
            this.lblPrecioPublico.AutoSize = true;
            this.lblPrecioPublico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPublico.Location = new System.Drawing.Point(497, 239);
            this.lblPrecioPublico.Name = "lblPrecioPublico";
            this.lblPrecioPublico.Size = new System.Drawing.Size(112, 20);
            this.lblPrecioPublico.TabIndex = 28;
            this.lblPrecioPublico.Text = "Precio Publico:";
            // 
            // spnPrecioMayoreo
            // 
            this.spnPrecioMayoreo.DecimalPlaces = 2;
            this.spnPrecioMayoreo.Location = new System.Drawing.Point(617, 209);
            this.spnPrecioMayoreo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spnPrecioMayoreo.Name = "spnPrecioMayoreo";
            this.spnPrecioMayoreo.Size = new System.Drawing.Size(101, 20);
            this.spnPrecioMayoreo.TabIndex = 14;
            // 
            // spnPrecioPublico
            // 
            this.spnPrecioPublico.DecimalPlaces = 2;
            this.spnPrecioPublico.Location = new System.Drawing.Point(617, 239);
            this.spnPrecioPublico.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spnPrecioPublico.Name = "spnPrecioPublico";
            this.spnPrecioPublico.Size = new System.Drawing.Size(101, 20);
            this.spnPrecioPublico.TabIndex = 15;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(39, 274);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(91, 20);
            this.lblDescuento.TabIndex = 31;
            this.lblDescuento.Text = "Descuento:";
            // 
            // cmbDescuento
            // 
            this.cmbDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescuento.FormattingEnabled = true;
            this.cmbDescuento.Location = new System.Drawing.Point(130, 274);
            this.cmbDescuento.Name = "cmbDescuento";
            this.cmbDescuento.Size = new System.Drawing.Size(128, 21);
            this.cmbDescuento.TabIndex = 16;
            this.cmbDescuento.SelectedIndexChanged += new System.EventHandler(this.cmbDescuento_SelectedIndexChanged);
            this.cmbDescuento.Click += new System.EventHandler(this.cmbDescuento_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Location = new System.Drawing.Point(42, 407);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(41, 42);
            this.btnAtras.TabIndex = 18;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(582, 274);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 52);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ptbImagen
            // 
            this.ptbImagen.BackColor = System.Drawing.SystemColors.Control;
            this.ptbImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbImagen.BackgroundImage")));
            this.ptbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbImagen.Location = new System.Drawing.Point(292, 274);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(123, 112);
            this.ptbImagen.TabIndex = 35;
            this.ptbImagen.TabStop = false;
            this.ptbImagen.Tag = "";
            this.ptbImagen.Click += new System.EventHandler(this.ptbImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_Producto_Tenyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(765, 459);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cmbDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.spnPrecioPublico);
            this.Controls.Add(this.spnPrecioMayoreo);
            this.Controls.Add(this.lblPrecioPublico);
            this.Controls.Add(this.lblPrecioMayoreo);
            this.Controls.Add(this.spnStockMax);
            this.Controls.Add(this.spnStockMin);
            this.Controls.Add(this.lblStockMax);
            this.Controls.Add(this.lblStockMin);
            this.Controls.Add(this.spnExistencias);
            this.Controls.Add(this.lblExistencias);
            this.Controls.Add(this.spnCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.spnNivelCompetencia);
            this.Controls.Add(this.lblNivelCompetencia);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.cmbEstante);
            this.Controls.Add(this.lblEstante);
            this.Controls.Add(this.cmbPasillo);
            this.Controls.Add(this.lblPasillo);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.txtCodigoProd);
            this.Controls.Add(this.lblCodigoProd);
            this.Controls.Add(this.txtClaveProducto);
            this.Controls.Add(this.lblClaveProd);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Producto_Tenyo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCTO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Producto_Tenyo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.spnNivelCompetencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnExistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnStockMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnStockMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecioMayoreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecioPublico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblClaveProd;
        private System.Windows.Forms.TextBox txtClaveProducto;
        private System.Windows.Forms.Label lblCodigoProd;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblPasillo;
        private System.Windows.Forms.ComboBox cmbPasillo;
        private System.Windows.Forms.Label lblEstante;
        private System.Windows.Forms.ComboBox cmbEstante;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label lblNivelCompetencia;
        private System.Windows.Forms.NumericUpDown spnNivelCompetencia;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown spnCantidad;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.NumericUpDown spnExistencias;
        private System.Windows.Forms.Label lblStockMin;
        private System.Windows.Forms.Label lblStockMax;
        private System.Windows.Forms.NumericUpDown spnStockMin;
        private System.Windows.Forms.NumericUpDown spnStockMax;
        private System.Windows.Forms.Label lblPrecioMayoreo;
        private System.Windows.Forms.Label lblPrecioPublico;
        private System.Windows.Forms.NumericUpDown spnPrecioMayoreo;
        private System.Windows.Forms.NumericUpDown spnPrecioPublico;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.ComboBox cmbDescuento;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}