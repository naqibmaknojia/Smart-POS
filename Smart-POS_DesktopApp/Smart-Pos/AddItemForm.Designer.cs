namespace Smart_Pos
{
    partial class AddItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Itemlbl = new System.Windows.Forms.Label();
            this.vendorlbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.Quantitylbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Item";
            // 
            // Itemlbl
            // 
            this.Itemlbl.AutoSize = true;
            this.Itemlbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemlbl.ForeColor = System.Drawing.Color.White;
            this.Itemlbl.Location = new System.Drawing.Point(113, 66);
            this.Itemlbl.Name = "Itemlbl";
            this.Itemlbl.Size = new System.Drawing.Size(55, 28);
            this.Itemlbl.TabIndex = 1;
            this.Itemlbl.Text = "Item :";
            // 
            // vendorlbl
            // 
            this.vendorlbl.AutoSize = true;
            this.vendorlbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorlbl.ForeColor = System.Drawing.Color.White;
            this.vendorlbl.Location = new System.Drawing.Point(75, 192);
            this.vendorlbl.Name = "vendorlbl";
            this.vendorlbl.Size = new System.Drawing.Size(94, 28);
            this.vendorlbl.TabIndex = 2;
            this.vendorlbl.Text = "Category :";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.ForeColor = System.Drawing.Color.White;
            this.pricelbl.Location = new System.Drawing.Point(40, 152);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(133, 28);
            this.pricelbl.TabIndex = 3;
            this.pricelbl.Text = "Price per item : ";
            // 
            // Quantitylbl
            // 
            this.Quantitylbl.AutoSize = true;
            this.Quantitylbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitylbl.ForeColor = System.Drawing.Color.White;
            this.Quantitylbl.Location = new System.Drawing.Point(80, 112);
            this.Quantitylbl.Name = "Quantitylbl";
            this.Quantitylbl.Size = new System.Drawing.Size(88, 28);
            this.Quantitylbl.TabIndex = 4;
            this.Quantitylbl.Text = "Quantity :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(187, 196);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 20);
            this.textBox4.TabIndex = 8;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.SpringGreen;
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(142, 278);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(76, 33);
            this.Addbtn.TabIndex = 9;
            this.Addbtn.Text = "Save";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.Location = new System.Drawing.Point(348, 3);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(27, 34);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closebtn.TabIndex = 10;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(188, 237);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(140, 20);
            this.textBox5.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "ShopId :";
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 327);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Quantitylbl);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.vendorlbl);
            this.Controls.Add(this.Itemlbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItemForm";
            this.Text = "AddItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Itemlbl;
        private System.Windows.Forms.Label vendorlbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label Quantitylbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
    }
}