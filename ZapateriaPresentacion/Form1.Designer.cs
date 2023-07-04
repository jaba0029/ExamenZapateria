namespace ZapateriaPresentacion
{
    partial class frmZapateria
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
            this.groupBoxTiendas = new System.Windows.Forms.GroupBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonListar = new System.Windows.Forms.Button();
            this.groupArticulos = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelTotalEstante = new System.Windows.Forms.Label();
            this.labelTotalBodega = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.textNombreArt = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTotalestante = new System.Windows.Forms.TextBox();
            this.txtTotalBodega = new System.Windows.Forms.TextBox();
            this.txtNumeroTienda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblNumTienda = new System.Windows.Forms.Label();
            this.txtNumTienda = new System.Windows.Forms.TextBox();
            this.groupBoxTiendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTiendas
            // 
            this.groupBoxTiendas.Controls.Add(this.buttonListar);
            this.groupBoxTiendas.Controls.Add(this.dataGridView2);
            this.groupBoxTiendas.Controls.Add(this.buttonAgregar);
            this.groupBoxTiendas.Controls.Add(this.textDireccion);
            this.groupBoxTiendas.Controls.Add(this.textNombre);
            this.groupBoxTiendas.Controls.Add(this.labelDireccion);
            this.groupBoxTiendas.Controls.Add(this.labelNombre);
            this.groupBoxTiendas.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTiendas.Name = "groupBoxTiendas";
            this.groupBoxTiendas.Size = new System.Drawing.Size(617, 124);
            this.groupBoxTiendas.TabIndex = 0;
            this.groupBoxTiendas.TabStop = false;
            this.groupBoxTiendas.Text = "Tiendas";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(7, 20);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(6, 47);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 1;
            this.labelDireccion.Text = "Dirección:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(100, 20);
            this.textNombre.MaxLength = 100;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(181, 20);
            this.textNombre.TabIndex = 2;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(100, 47);
            this.textDireccion.MaxLength = 100;
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(181, 20);
            this.textDireccion.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(512, 95);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(99, 23);
            this.buttonAgregar.TabIndex = 4;
            this.buttonAgregar.Text = "Agregar Tienda";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(305, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(306, 72);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(392, 95);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(102, 23);
            this.buttonListar.TabIndex = 6;
            this.buttonListar.Text = "Listar Tiendas";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // groupArticulos
            // 
            this.groupArticulos.Controls.Add(this.txtNumTienda);
            this.groupArticulos.Controls.Add(this.lblNumTienda);
            this.groupArticulos.Controls.Add(this.button3);
            this.groupArticulos.Controls.Add(this.button2);
            this.groupArticulos.Controls.Add(this.button1);
            this.groupArticulos.Controls.Add(this.txtNumeroTienda);
            this.groupArticulos.Controls.Add(this.txtTotalBodega);
            this.groupArticulos.Controls.Add(this.txtTotalestante);
            this.groupArticulos.Controls.Add(this.txtPrecio);
            this.groupArticulos.Controls.Add(this.txtDescripcion);
            this.groupArticulos.Controls.Add(this.textNombreArt);
            this.groupArticulos.Controls.Add(this.dataGridView3);
            this.groupArticulos.Controls.Add(this.label1);
            this.groupArticulos.Controls.Add(this.labelTotalBodega);
            this.groupArticulos.Controls.Add(this.labelTotalEstante);
            this.groupArticulos.Controls.Add(this.labelPrecio);
            this.groupArticulos.Controls.Add(this.labelDescription);
            this.groupArticulos.Controls.Add(this.labelName);
            this.groupArticulos.Location = new System.Drawing.Point(12, 143);
            this.groupArticulos.Name = "groupArticulos";
            this.groupArticulos.Size = new System.Drawing.Size(617, 268);
            this.groupArticulos.TabIndex = 1;
            this.groupArticulos.TabStop = false;
            this.groupArticulos.Text = "Articulos";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(98, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nombre del articulo";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(20, 49);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Descripción";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(20, 78);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio";
            // 
            // labelTotalEstante
            // 
            this.labelTotalEstante.AutoSize = true;
            this.labelTotalEstante.Location = new System.Drawing.Point(17, 113);
            this.labelTotalEstante.Name = "labelTotalEstante";
            this.labelTotalEstante.Size = new System.Drawing.Size(84, 13);
            this.labelTotalEstante.TabIndex = 3;
            this.labelTotalEstante.Text = "Total en estante";
            // 
            // labelTotalBodega
            // 
            this.labelTotalBodega.AutoSize = true;
            this.labelTotalBodega.Location = new System.Drawing.Point(17, 146);
            this.labelTotalBodega.Name = "labelTotalBodega";
            this.labelTotalBodega.Size = new System.Drawing.Size(85, 13);
            this.labelTotalBodega.TabIndex = 4;
            this.labelTotalBodega.Text = "Total en bodega";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "No Tienda";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(296, 16);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(315, 150);
            this.dataGridView3.TabIndex = 6;
            // 
            // textNombreArt
            // 
            this.textNombreArt.Location = new System.Drawing.Point(125, 20);
            this.textNombreArt.Name = "textNombreArt";
            this.textNombreArt.Size = new System.Drawing.Size(165, 20);
            this.textNombreArt.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(125, 49);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(165, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(125, 78);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(68, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtTotalestante
            // 
            this.txtTotalestante.Location = new System.Drawing.Point(125, 113);
            this.txtTotalestante.Name = "txtTotalestante";
            this.txtTotalestante.Size = new System.Drawing.Size(68, 20);
            this.txtTotalestante.TabIndex = 10;
            // 
            // txtTotalBodega
            // 
            this.txtTotalBodega.Location = new System.Drawing.Point(125, 146);
            this.txtTotalBodega.Name = "txtTotalBodega";
            this.txtTotalBodega.Size = new System.Drawing.Size(68, 20);
            this.txtTotalBodega.TabIndex = 11;
            // 
            // txtNumeroTienda
            // 
            this.txtNumeroTienda.Location = new System.Drawing.Point(125, 177);
            this.txtNumeroTienda.Name = "txtNumeroTienda";
            this.txtNumeroTienda.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroTienda.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Listar Articulo  por Num. Tienda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Listar Articulos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(527, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 36);
            this.button3.TabIndex = 15;
            this.button3.Text = "Agregar Articulo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblNumTienda
            // 
            this.lblNumTienda.AutoSize = true;
            this.lblNumTienda.Location = new System.Drawing.Point(302, 219);
            this.lblNumTienda.Name = "lblNumTienda";
            this.lblNumTienda.Size = new System.Drawing.Size(95, 13);
            this.lblNumTienda.TabIndex = 16;
            this.lblNumTienda.Text = "Numero de Tienda";
            // 
            // txtNumTienda
            // 
            this.txtNumTienda.Location = new System.Drawing.Point(315, 235);
            this.txtNumTienda.Name = "txtNumTienda";
            this.txtNumTienda.Size = new System.Drawing.Size(66, 20);
            this.txtNumTienda.TabIndex = 17;
            // 
            // frmZapateria
            // 
            this.ClientSize = new System.Drawing.Size(641, 423);
            this.Controls.Add(this.groupArticulos);
            this.Controls.Add(this.groupBoxTiendas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmZapateria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Zapatos";
            this.Load += new System.EventHandler(this.frmZapateria_Load);
            this.groupBoxTiendas.ResumeLayout(false);
            this.groupBoxTiendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupArticulos.ResumeLayout(false);
            this.groupArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTiendas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListarTiendas;
        private System.Windows.Forms.Button btnAgregarTienda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxTiendas;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.GroupBox groupArticulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalBodega;
        private System.Windows.Forms.Label labelTotalEstante;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumeroTienda;
        private System.Windows.Forms.TextBox txtTotalBodega;
        private System.Windows.Forms.TextBox txtTotalestante;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox textNombreArt;
        private System.Windows.Forms.TextBox txtNumTienda;
        private System.Windows.Forms.Label lblNumTienda;
    }
}

