namespace AzureQueApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.quelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QueuetextBox = new System.Windows.Forms.TextBox();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Messagebutton = new System.Windows.Forms.Button();
            this.queuebutton = new System.Windows.Forms.Button();
            this.ListMessagebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azure Table App";
            // 
            // quelabel
            // 
            this.quelabel.AutoSize = true;
            this.quelabel.Location = new System.Drawing.Point(49, 94);
            this.quelabel.Name = "quelabel";
            this.quelabel.Size = new System.Drawing.Size(128, 13);
            this.quelabel.TabIndex = 1;
            this.quelabel.Text = "Enter Azure Queue Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Message";
            // 
            // QueuetextBox
            // 
            this.QueuetextBox.Location = new System.Drawing.Point(183, 91);
            this.QueuetextBox.Name = "QueuetextBox";
            this.QueuetextBox.Size = new System.Drawing.Size(100, 20);
            this.QueuetextBox.TabIndex = 3;
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Location = new System.Drawing.Point(183, 143);
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(100, 20);
            this.MessagetextBox.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(327, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 95);
            this.listBox1.TabIndex = 5;
            // 
            // Messagebutton
            // 
            this.Messagebutton.Location = new System.Drawing.Point(183, 185);
            this.Messagebutton.Name = "Messagebutton";
            this.Messagebutton.Size = new System.Drawing.Size(90, 23);
            this.Messagebutton.TabIndex = 6;
            this.Messagebutton.Text = "Add Message";
            this.Messagebutton.UseVisualStyleBackColor = true;
            this.Messagebutton.Click += new System.EventHandler(this.Messagebutton_Click);
            // 
            // queuebutton
            // 
            this.queuebutton.Location = new System.Drawing.Point(327, 88);
            this.queuebutton.Name = "queuebutton";
            this.queuebutton.Size = new System.Drawing.Size(85, 23);
            this.queuebutton.TabIndex = 7;
            this.queuebutton.Text = "Click to Create";
            this.queuebutton.UseVisualStyleBackColor = true;
            this.queuebutton.Click += new System.EventHandler(this.queuebutton_Click);
            // 
            // ListMessagebutton
            // 
            this.ListMessagebutton.Location = new System.Drawing.Point(434, 88);
            this.ListMessagebutton.Name = "ListMessagebutton";
            this.ListMessagebutton.Size = new System.Drawing.Size(87, 23);
            this.ListMessagebutton.TabIndex = 8;
            this.ListMessagebutton.Text = "List Messages";
            this.ListMessagebutton.UseVisualStyleBackColor = true;
            this.ListMessagebutton.Click += new System.EventHandler(this.ListMessagebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 262);
            this.Controls.Add(this.ListMessagebutton);
            this.Controls.Add(this.queuebutton);
            this.Controls.Add(this.Messagebutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.QueuetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quelabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QueuetextBox;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Messagebutton;
        private System.Windows.Forms.Button queuebutton;
        private System.Windows.Forms.Button ListMessagebutton;
    }
}

