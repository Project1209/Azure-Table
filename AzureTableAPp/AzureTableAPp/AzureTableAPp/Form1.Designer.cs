namespace AzureTableAPp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TableName = new System.Windows.Forms.TextBox();
            this.productId = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.AddItem = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.ListItem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azure Table App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Azure Table Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Product Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Product Price";
            // 
            // TableName
            // 
            this.TableName.Location = new System.Drawing.Point(176, 103);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(100, 23);
            this.TableName.TabIndex = 6;
            // 
            // productId
            // 
            this.productId.Location = new System.Drawing.Point(176, 155);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(100, 23);
            this.productId.TabIndex = 6;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(176, 205);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(100, 23);
            this.productName.TabIndex = 6;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Location = new System.Drawing.Point(176, 253);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(100, 23);
            this.ProductPrice.TabIndex = 6;
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(86, 308);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(126, 43);
            this.AddItem.TabIndex = 7;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(335, 84);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(290, 42);
            this.Create.TabIndex = 7;
            this.Create.Text = "Click To Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // ListItem
            // 
            this.ListItem.Location = new System.Drawing.Point(335, 132);
            this.ListItem.Name = "ListItem";
            this.ListItem.Size = new System.Drawing.Size(290, 41);
            this.ListItem.TabIndex = 7;
            this.ListItem.Text = "List Item";
            this.ListItem.UseVisualStyleBackColor = true;
            this.ListItem.Click += new System.EventHandler(this.ListItem_ClickAsync);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(336, 179);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 232);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(673, 423);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ListItem);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TableName;
        private System.Windows.Forms.TextBox productId;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button ListItem;
        #endregion

        private System.Windows.Forms.TextBox textBox1;
    }
}

