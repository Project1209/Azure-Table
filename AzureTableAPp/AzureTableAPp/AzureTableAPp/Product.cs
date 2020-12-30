using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Auth;

namespace AzureTableAPp
{
    public class Product : TableEntity
    {
        public String ProductId { get; set; }
        public String ProductName { get; set; }
        public String ProductPrice { get; set; }

        public Product(String id, String name, String price)
        {
            ProductId = id;
            ProductName = name;
            ProductPrice = price;
        }
    }
}
