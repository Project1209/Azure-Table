using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Auth;
using System.Configuration;

namespace AzureTableAPp
{

    public partial class Form1 : Form
    {
        private static String storageName = ConfigurationManager.AppSettings["storageName"];
        private static String accountAccountKey = ConfigurationManager.AppSettings["accountAccountKey"];
        private static StorageCredentials storageCredentials = new StorageCredentials(storageName, accountAccountKey);
        private static CloudStorageAccount cloudStorageAccount = new CloudStorageAccount(storageCredentials,true);
        private static CloudTableClient cloudTableClient = cloudStorageAccount.CreateCloudTableClient();


        public Form1()
        {
            InitializeComponent();
        }

        public static async Task<Product> Insert( Product entity, String tableName)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entity.RowKey = entity.ProductId;
            entity.PartitionKey = entity.ProductId;
            CloudTable cloudTable = cloudTableClient.GetTableReference(tableName);
            TableOperation tableOperation = TableOperation.Insert(entity);
            TableResult tableResult = await cloudTable.ExecuteAsync(tableOperation);
            Product insertPro = tableResult.Result as Product;
            if (tableResult.HttpStatusCode == 204)
                MessageBox.Show("Inserted");
            return insertPro;
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            String id = productId.Text;
            String name = productName.Text;
            String price = ProductPrice.Text;
            Product pro = new Product(id, name, price);
            String tableName = TableName.Text;
            var result = Insert(pro, tableName);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            String tableName = TableName.Text;
            CloudTable cloudTable = cloudTableClient.GetTableReference(tableName);
            cloudTable.CreateIfNotExistsAsync();
            MessageBox.Show("Azure table is created");
        }

        public static async Task Restult(CloudTable cloudTable, TableOperation tableOperation, object sender, EventArgs e)
        {
            TableResult tableResult = await cloudTable.ExecuteAsync(tableOperation);
            if (tableResult.HttpStatusCode==200)
                MessageBox.Show("Please Find the Details");

            String str = ((Product)tableResult.Result).ProductId+ ((Product)tableResult.Result).ProductName + ((Product)tableResult.Result).ProductPrice;
            
        }

        private void ListItem_ClickAsync(object sender, EventArgs e)
        {
            String tableName = TableName.Text;
            CloudTable cloudTable = cloudTableClient.GetTableReference(tableName);
            String RowKey = productId.Text;
            String PartitionKey = productId.Text;
            TableOperation tableOperation = TableOperation.Retrieve<Product>(PartitionKey, RowKey);
            var result=Restult(cloudTable, tableOperation, sender, e);
            textBox1.Text = result.ToString();
        }
    }
}
