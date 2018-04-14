using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.WindowsAzure.Storage.Queue;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage;

namespace AzureQueApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void queuebutton_Click(object sender, EventArgs e)
        {
            var queueName = QueuetextBox.Text;
            Regex regex = new Regex(@"^[a-z0-9](?!.*--)[a-z0-9-]{1,61}[a-z0-9]$");//Azure Queue Name validation
            Match match = regex.Match(queueName);
            if (queueName == "" || !(match.Success))
            {
                MessageBox.Show("Queue Name only contains lowercase letters,numbers and hyphens,and must begin with a letter or a number. Each hyphen must be preceded and followed by a non-hyphen character.!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    var storageAccount = "hab1hydstorage";
                    var key = "UWTY4xDOszXlKJY4qv8fj467xhjScEMZwgT9ooGGJmr0IcqPLEk6RfpVj6esWATabpQDIAkuXd3WLBha6laJtg==";
                    StorageCredentials storeCred = new StorageCredentials(storageAccount, key);
                    CloudStorageAccount cloudStoreAccount = new CloudStorageAccount(storeCred, useHttps: true);
                    CloudQueueClient queueClient = cloudStoreAccount.CreateCloudQueueClient();
                    CloudQueue azureQueue = queueClient.GetQueueReference(queueName);
                    azureQueue.CreateIfNotExists();
                    MessageBox.Show(queueName + " " + "created successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    QueuetextBox.Text = "";
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void Messagebutton_Click(object sender, EventArgs e)
        {
            var messageName = MessagetextBox.Text;
           
            if (messageName == "")
            {
                MessageBox.Show("Message cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    var storageAccount = "hab1hydstorage";
                    var key = "UWTY4xDOszXlKJY4qv8fj467xhjScEMZwgT9ooGGJmr0IcqPLEk6RfpVj6esWATabpQDIAkuXd3WLBha6laJtg==";
                    StorageCredentials storeCred = new StorageCredentials(storageAccount, key);
                    CloudStorageAccount cloudStoreAccount = new CloudStorageAccount(storeCred, useHttps: true);
                    CloudQueueClient queueClient = cloudStoreAccount.CreateCloudQueueClient();
                    CloudQueue azureQueue = queueClient.GetQueueReference("testqueue");
                    azureQueue.CreateIfNotExists();
                    CloudQueueMessage message = new CloudQueueMessage(messageName);
                    azureQueue.AddMessage(message);
                    MessageBox.Show("Message added successfully!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    MessagetextBox.Text = "";
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void ListMessagebutton_Click(object sender, EventArgs e)
        {
            try
            {
                var storageAccount = "hab1hydstorage";
                var key = "UWTY4xDOszXlKJY4qv8fj467xhjScEMZwgT9ooGGJmr0IcqPLEk6RfpVj6esWATabpQDIAkuXd3WLBha6laJtg==";
                StorageCredentials storeCred = new StorageCredentials(storageAccount, key);
                CloudStorageAccount cloudStoreAccount = new CloudStorageAccount(storeCred, useHttps: true);
                CloudQueueClient queueClient = cloudStoreAccount.CreateCloudQueueClient();
                CloudQueue azureQueue = queueClient.GetQueueReference("testqueue");
                azureQueue.CreateIfNotExists();
                CloudQueueMessage insertmessage = new CloudQueueMessage("Hello test message");
                azureQueue.AddMessage(insertmessage);
                var messages = azureQueue.GetMessages(10);
                foreach (var message in messages)
                {

                    listBox1.Items.Add(message.AsString);
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
