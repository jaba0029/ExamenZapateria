namespace ZapateriaPresentacion
{
    partial class frmFrontEnd
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
            this.groupBoxStores = new System.Windows.Forms.GroupBox();
            this.buttonListStores = new System.Windows.Forms.Button();
            this.dataGridListStores = new System.Windows.Forms.DataGridView();
            this.buttonAddStore = new System.Windows.Forms.Button();
            this.textAddressStore = new System.Windows.Forms.TextBox();
            this.textNameStore = new System.Windows.Forms.TextBox();
            this.labelAddressStore = new System.Windows.Forms.Label();
            this.labelNameStore = new System.Windows.Forms.Label();
            this.groupBoxArticles = new System.Windows.Forms.GroupBox();
            this.textSrored_IdChoose = new System.Windows.Forms.TextBox();
            this.labelStored_Id = new System.Windows.Forms.Label();
            this.buttonAddArticles = new System.Windows.Forms.Button();
            this.buttonListArticles = new System.Windows.Forms.Button();
            this.buttonListArticlesByStore = new System.Windows.Forms.Button();
            this.textStored_Id = new System.Windows.Forms.TextBox();
            this.textArticleTotalInVault = new System.Windows.Forms.TextBox();
            this.textArticleTotalInShelf = new System.Windows.Forms.TextBox();
            this.textPriceArticle = new System.Windows.Forms.TextBox();
            this.textDescriptionArticle = new System.Windows.Forms.TextBox();
            this.textNameArticle = new System.Windows.Forms.TextBox();
            this.dataGridListArticles = new System.Windows.Forms.DataGridView();
            this.labelStored_idChoose = new System.Windows.Forms.Label();
            this.labelArticleTotalInVault = new System.Windows.Forms.Label();
            this.labelArticleTotalInShelf = new System.Windows.Forms.Label();
            this.labelPriceArticle = new System.Windows.Forms.Label();
            this.labelDescripctionArticle = new System.Windows.Forms.Label();
            this.labelNameArticle = new System.Windows.Forms.Label();
            this.groupBoxStores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListStores)).BeginInit();
            this.groupBoxArticles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStores
            // 
            this.groupBoxStores.Controls.Add(this.buttonListStores);
            this.groupBoxStores.Controls.Add(this.dataGridListStores);
            this.groupBoxStores.Controls.Add(this.buttonAddStore);
            this.groupBoxStores.Controls.Add(this.textAddressStore);
            this.groupBoxStores.Controls.Add(this.textNameStore);
            this.groupBoxStores.Controls.Add(this.labelAddressStore);
            this.groupBoxStores.Controls.Add(this.labelNameStore);
            this.groupBoxStores.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStores.Name = "groupBoxStores";
            this.groupBoxStores.Size = new System.Drawing.Size(755, 124);
            this.groupBoxStores.TabIndex = 0;
            this.groupBoxStores.TabStop = false;
            this.groupBoxStores.Text = "Tiendas";
            // 
            // buttonListStores
            // 
            this.buttonListStores.Location = new System.Drawing.Point(516, 95);
            this.buttonListStores.Name = "buttonListStores";
            this.buttonListStores.Size = new System.Drawing.Size(102, 23);
            this.buttonListStores.TabIndex = 6;
            this.buttonListStores.Text = "Listar Tiendas";
            this.buttonListStores.UseVisualStyleBackColor = true;
            this.buttonListStores.Click += new System.EventHandler(this.buttonListStores_Click);
            // 
            // dataGridListStores
            // 
            this.dataGridListStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListStores.Location = new System.Drawing.Point(317, 16);
            this.dataGridListStores.Name = "dataGridListStores";
            this.dataGridListStores.Size = new System.Drawing.Size(429, 72);
            this.dataGridListStores.TabIndex = 5;
            // 
            // buttonAddStore
            // 
            this.buttonAddStore.Location = new System.Drawing.Point(646, 95);
            this.buttonAddStore.Name = "buttonAddStore";
            this.buttonAddStore.Size = new System.Drawing.Size(99, 23);
            this.buttonAddStore.TabIndex = 4;
            this.buttonAddStore.Text = "Agregar Tienda";
            this.buttonAddStore.UseVisualStyleBackColor = true;
            this.buttonAddStore.Click += new System.EventHandler(this.buttonAddStore_Click);
            // 
            // textAddressStore
            // 
            this.textAddressStore.Location = new System.Drawing.Point(100, 47);
            this.textAddressStore.MaxLength = 100;
            this.textAddressStore.Name = "textAddressStore";
            this.textAddressStore.Size = new System.Drawing.Size(181, 20);
            this.textAddressStore.TabIndex = 3;
            // 
            // textNameStore
            // 
            this.textNameStore.Location = new System.Drawing.Point(100, 20);
            this.textNameStore.MaxLength = 100;
            this.textNameStore.Name = "textNameStore";
            this.textNameStore.Size = new System.Drawing.Size(181, 20);
            this.textNameStore.TabIndex = 2;
            // 
            // labelAddressStore
            // 
            this.labelAddressStore.AutoSize = true;
            this.labelAddressStore.Location = new System.Drawing.Point(6, 47);
            this.labelAddressStore.Name = "labelAddressStore";
            this.labelAddressStore.Size = new System.Drawing.Size(91, 13);
            this.labelAddressStore.TabIndex = 1;
            this.labelAddressStore.Text = "Dirección Tienda:";
            // 
            // labelNameStore
            // 
            this.labelNameStore.AutoSize = true;
            this.labelNameStore.Location = new System.Drawing.Point(7, 20);
            this.labelNameStore.Name = "labelNameStore";
            this.labelNameStore.Size = new System.Drawing.Size(83, 13);
            this.labelNameStore.TabIndex = 0;
            this.labelNameStore.Text = "Nombre Tienda:";
            // 
            // groupBoxArticles
            // 
            this.groupBoxArticles.Controls.Add(this.textSrored_IdChoose);
            this.groupBoxArticles.Controls.Add(this.labelStored_Id);
            this.groupBoxArticles.Controls.Add(this.buttonAddArticles);
            this.groupBoxArticles.Controls.Add(this.buttonListArticles);
            this.groupBoxArticles.Controls.Add(this.buttonListArticlesByStore);
            this.groupBoxArticles.Controls.Add(this.textStored_Id);
            this.groupBoxArticles.Controls.Add(this.textArticleTotalInVault);
            this.groupBoxArticles.Controls.Add(this.textArticleTotalInShelf);
            this.groupBoxArticles.Controls.Add(this.textPriceArticle);
            this.groupBoxArticles.Controls.Add(this.textDescriptionArticle);
            this.groupBoxArticles.Controls.Add(this.textNameArticle);
            this.groupBoxArticles.Controls.Add(this.dataGridListArticles);
            this.groupBoxArticles.Controls.Add(this.labelStored_idChoose);
            this.groupBoxArticles.Controls.Add(this.labelArticleTotalInVault);
            this.groupBoxArticles.Controls.Add(this.labelArticleTotalInShelf);
            this.groupBoxArticles.Controls.Add(this.labelPriceArticle);
            this.groupBoxArticles.Controls.Add(this.labelDescripctionArticle);
            this.groupBoxArticles.Controls.Add(this.labelNameArticle);
            this.groupBoxArticles.Location = new System.Drawing.Point(12, 143);
            this.groupBoxArticles.Name = "groupBoxArticles";
            this.groupBoxArticles.Size = new System.Drawing.Size(755, 268);
            this.groupBoxArticles.TabIndex = 1;
            this.groupBoxArticles.TabStop = false;
            this.groupBoxArticles.Text = "Articulos";
            // 
            // textSrored_IdChoose
            // 
            this.textSrored_IdChoose.Location = new System.Drawing.Point(420, 235);
            this.textSrored_IdChoose.MaxLength = 10;
            this.textSrored_IdChoose.Name = "textSrored_IdChoose";
            this.textSrored_IdChoose.Size = new System.Drawing.Size(66, 20);
            this.textSrored_IdChoose.TabIndex = 17;
            // 
            // labelStored_Id
            // 
            this.labelStored_Id.AutoSize = true;
            this.labelStored_Id.Location = new System.Drawing.Point(17, 180);
            this.labelStored_Id.Name = "labelStored_Id";
            this.labelStored_Id.Size = new System.Drawing.Size(95, 13);
            this.labelStored_Id.TabIndex = 16;
            this.labelStored_Id.Text = "Numero de Tienda";
            // 
            // buttonAddArticles
            // 
            this.buttonAddArticles.Location = new System.Drawing.Point(662, 172);
            this.buttonAddArticles.Name = "buttonAddArticles";
            this.buttonAddArticles.Size = new System.Drawing.Size(84, 36);
            this.buttonAddArticles.TabIndex = 15;
            this.buttonAddArticles.Text = "Agregar Articulo";
            this.buttonAddArticles.UseVisualStyleBackColor = true;
            this.buttonAddArticles.Click += new System.EventHandler(this.buttonAddArticles_Click);
            // 
            // buttonListArticles
            // 
            this.buttonListArticles.Location = new System.Drawing.Point(559, 172);
            this.buttonListArticles.Name = "buttonListArticles";
            this.buttonListArticles.Size = new System.Drawing.Size(75, 36);
            this.buttonListArticles.TabIndex = 14;
            this.buttonListArticles.Text = "Listar Articulos";
            this.buttonListArticles.UseVisualStyleBackColor = true;
            this.buttonListArticles.Click += new System.EventHandler(this.buttonListArticles_Click);
            // 
            // buttonListArticlesByStore
            // 
            this.buttonListArticlesByStore.Location = new System.Drawing.Point(420, 172);
            this.buttonListArticlesByStore.Name = "buttonListArticlesByStore";
            this.buttonListArticlesByStore.Size = new System.Drawing.Size(108, 36);
            this.buttonListArticlesByStore.TabIndex = 13;
            this.buttonListArticlesByStore.Text = "Listar Articulo  por numero de tienda";
            this.buttonListArticlesByStore.UseVisualStyleBackColor = true;
            this.buttonListArticlesByStore.Click += new System.EventHandler(this.buttonListArticlesByStore_Click);
            // 
            // textStored_Id
            // 
            this.textStored_Id.Location = new System.Drawing.Point(143, 177);
            this.textStored_Id.MaxLength = 10;
            this.textStored_Id.Name = "textStored_Id";
            this.textStored_Id.Size = new System.Drawing.Size(68, 20);
            this.textStored_Id.TabIndex = 12;
            // 
            // textArticleTotalInVault
            // 
            this.textArticleTotalInVault.Location = new System.Drawing.Point(143, 146);
            this.textArticleTotalInVault.MaxLength = 10;
            this.textArticleTotalInVault.Name = "textArticleTotalInVault";
            this.textArticleTotalInVault.Size = new System.Drawing.Size(68, 20);
            this.textArticleTotalInVault.TabIndex = 11;
            // 
            // textArticleTotalInShelf
            // 
            this.textArticleTotalInShelf.Location = new System.Drawing.Point(143, 113);
            this.textArticleTotalInShelf.MaxLength = 10;
            this.textArticleTotalInShelf.Name = "textArticleTotalInShelf";
            this.textArticleTotalInShelf.Size = new System.Drawing.Size(68, 20);
            this.textArticleTotalInShelf.TabIndex = 10;
            // 
            // textPriceArticle
            // 
            this.textPriceArticle.Location = new System.Drawing.Point(143, 78);
            this.textPriceArticle.MaxLength = 10;
            this.textPriceArticle.Name = "textPriceArticle";
            this.textPriceArticle.Size = new System.Drawing.Size(68, 20);
            this.textPriceArticle.TabIndex = 9;
            // 
            // textDescriptionArticle
            // 
            this.textDescriptionArticle.Location = new System.Drawing.Point(143, 49);
            this.textDescriptionArticle.MaxLength = 100;
            this.textDescriptionArticle.Name = "textDescriptionArticle";
            this.textDescriptionArticle.Size = new System.Drawing.Size(168, 20);
            this.textDescriptionArticle.TabIndex = 8;
            // 
            // textNameArticle
            // 
            this.textNameArticle.Location = new System.Drawing.Point(143, 20);
            this.textNameArticle.MaxLength = 100;
            this.textNameArticle.Name = "textNameArticle";
            this.textNameArticle.Size = new System.Drawing.Size(168, 20);
            this.textNameArticle.TabIndex = 7;
            // 
            // dataGridListArticles
            // 
            this.dataGridListArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListArticles.Location = new System.Drawing.Point(317, 16);
            this.dataGridListArticles.Name = "dataGridListArticles";
            this.dataGridListArticles.Size = new System.Drawing.Size(429, 150);
            this.dataGridListArticles.TabIndex = 6;
            // 
            // labelStored_idChoose
            // 
            this.labelStored_idChoose.AutoSize = true;
            this.labelStored_idChoose.Location = new System.Drawing.Point(417, 219);
            this.labelStored_idChoose.Name = "labelStored_idChoose";
            this.labelStored_idChoose.Size = new System.Drawing.Size(160, 13);
            this.labelStored_idChoose.TabIndex = 5;
            this.labelStored_idChoose.Text = "Seleccione un número de tienda";
            // 
            // labelArticleTotalInVault
            // 
            this.labelArticleTotalInVault.AutoSize = true;
            this.labelArticleTotalInVault.Location = new System.Drawing.Point(17, 146);
            this.labelArticleTotalInVault.Name = "labelArticleTotalInVault";
            this.labelArticleTotalInVault.Size = new System.Drawing.Size(85, 13);
            this.labelArticleTotalInVault.TabIndex = 4;
            this.labelArticleTotalInVault.Text = "Total en bodega";
            // 
            // labelArticleTotalInShelf
            // 
            this.labelArticleTotalInShelf.AutoSize = true;
            this.labelArticleTotalInShelf.Location = new System.Drawing.Point(17, 113);
            this.labelArticleTotalInShelf.Name = "labelArticleTotalInShelf";
            this.labelArticleTotalInShelf.Size = new System.Drawing.Size(84, 13);
            this.labelArticleTotalInShelf.TabIndex = 3;
            this.labelArticleTotalInShelf.Text = "Total en estante";
            // 
            // labelPriceArticle
            // 
            this.labelPriceArticle.AutoSize = true;
            this.labelPriceArticle.Location = new System.Drawing.Point(20, 78);
            this.labelPriceArticle.Name = "labelPriceArticle";
            this.labelPriceArticle.Size = new System.Drawing.Size(37, 13);
            this.labelPriceArticle.TabIndex = 2;
            this.labelPriceArticle.Text = "Precio";
            // 
            // labelDescripctionArticle
            // 
            this.labelDescripctionArticle.AutoSize = true;
            this.labelDescripctionArticle.Location = new System.Drawing.Point(20, 49);
            this.labelDescripctionArticle.Name = "labelDescripctionArticle";
            this.labelDescripctionArticle.Size = new System.Drawing.Size(117, 13);
            this.labelDescripctionArticle.TabIndex = 1;
            this.labelDescripctionArticle.Text = "Descripción del articulo";
            // 
            // labelNameArticle
            // 
            this.labelNameArticle.AutoSize = true;
            this.labelNameArticle.Location = new System.Drawing.Point(20, 16);
            this.labelNameArticle.Name = "labelNameArticle";
            this.labelNameArticle.Size = new System.Drawing.Size(98, 13);
            this.labelNameArticle.TabIndex = 0;
            this.labelNameArticle.Text = "Nombre del articulo";
            // 
            // frmFrontEnd
            // 
            this.ClientSize = new System.Drawing.Size(769, 423);
            this.Controls.Add(this.groupBoxArticles);
            this.Controls.Add(this.groupBoxStores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFrontEnd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Zapatos";
            this.Load += new System.EventHandler(this.frmFrontEnd_Load);
            this.groupBoxStores.ResumeLayout(false);
            this.groupBoxStores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListStores)).EndInit();
            this.groupBoxArticles.ResumeLayout(false);
            this.groupBoxArticles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStores;
        private System.Windows.Forms.TextBox textAddressStore;
        private System.Windows.Forms.TextBox textNameStore;
        private System.Windows.Forms.Label labelAddressStore;
        private System.Windows.Forms.Label labelNameStore;
        private System.Windows.Forms.Button buttonAddStore;
        private System.Windows.Forms.DataGridView dataGridListStores;
        private System.Windows.Forms.Button buttonListStores;
        private System.Windows.Forms.GroupBox groupBoxArticles;
        private System.Windows.Forms.Label labelStored_idChoose;
        private System.Windows.Forms.Label labelArticleTotalInVault;
        private System.Windows.Forms.Label labelArticleTotalInShelf;
        private System.Windows.Forms.Label labelPriceArticle;
        private System.Windows.Forms.Label labelDescripctionArticle;
        private System.Windows.Forms.Label labelNameArticle;
        private System.Windows.Forms.DataGridView dataGridListArticles;
        private System.Windows.Forms.Button buttonAddArticles;
        private System.Windows.Forms.Button buttonListArticles;
        private System.Windows.Forms.Button buttonListArticlesByStore;
        private System.Windows.Forms.TextBox textStored_Id;
        private System.Windows.Forms.TextBox textArticleTotalInVault;
        private System.Windows.Forms.TextBox textArticleTotalInShelf;
        private System.Windows.Forms.TextBox textPriceArticle;
        private System.Windows.Forms.TextBox textDescriptionArticle;
        private System.Windows.Forms.TextBox textNameArticle;
        private System.Windows.Forms.TextBox textSrored_IdChoose;
        private System.Windows.Forms.Label labelStored_Id;
    }
}

