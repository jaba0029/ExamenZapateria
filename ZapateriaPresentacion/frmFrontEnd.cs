using Newtonsoft.Json;
using Splat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using ZapateriaCommon.DTOs;
using ZapateriaPresentacion.Services.Interface;

namespace ZapateriaPresentacion
{
    public partial class frmFrontEnd : Form
    {
        private IStoreService _StoreService = Locator.Current.GetService<IStoreService>();
        private IArticleService _ArticleService = Locator.Current.GetService<IArticleService>();
        public frmFrontEnd()
        {
            InitializeComponent();
        }

        private void frmFrontEnd_Load(object sender, EventArgs e)
        {

        }

        private async void buttonAddStore_Click(object sender, EventArgs e)
        {
            if (textNameStore.Text.Trim().Length<=0)
            {
                MessageBox.Show("Super Zapatos", "Please, to give a store name!");
                return;
            }
            if (textAddressStore.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Super Zapatos", "Please, to give a store address!");
                return;
            }
            Store objStore = new Store()
            {
                Name = textNameStore.Text,
                Address = textAddressStore.Text
            };

            await _StoreService.SaveStore(objStore); 
        }

        private async void buttonListStores_Click(object sender, EventArgs e)
        {            
            IList<Store> lista = await _StoreService.GetStore();
            dataGridListStores.DataSource = lista;
        }

         
        private async void buttonAddArticles_Click(object sender, EventArgs e)
        {
            if (textNameArticle.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Super Zapatos", "Please, to give a article name!");
                return;
            }
            if (textDescriptionArticle.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Super Zapatos", "Please, to give a article description!");
                return;
            }

            Articles objArticulo = new Articles()
            {
                Name = textNameArticle.Text,
                Description = textDescriptionArticle.Text,
                Price = decimal.Parse(textPriceArticle.Text),
                TotalShelf = int.Parse(textArticleTotalInShelf.Text),
                TotalVault = int.Parse(textArticleTotalInVault.Text),
                StoreId_Id = int.Parse(textStored_Id.Text)
            };

            await _ArticleService.SaveArticle(objArticulo);
        }

        private async void buttonListArticles_Click(object sender, EventArgs e)
        {
            IList<Articles> lista = await _ArticleService.GetArticle();
            dataGridListArticles.DataSource = lista;
        }

        private async void buttonListArticlesByStore_Click(object sender, EventArgs e)
        {
            if (textSrored_IdChoose.Text.Length <= 0)
            {
                MessageBox.Show("Super Zapatos","Please, to give a store number!");
            }
            else
            {
                await _ArticleService.GetArticlexId(int.Parse(textSrored_IdChoose.Text));
            }
        }
        
    }   
}
