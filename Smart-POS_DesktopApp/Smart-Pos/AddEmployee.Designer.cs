namespace Smart_Pos
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Quantitylbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.vendorlbl = new System.Windows.Forms.Label();
            this.Itemlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.Location = new System.Drawing.Point(348, 2);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(27, 34);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closebtn.TabIndex = 21;
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.SpringGreen;
            this.Addbtn.FlatAppearance.BorderSize = 0;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(142, 277);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(76, 33);
            this.Addbtn.TabIndex = 20;
            this.Addbtn.Text = "Save";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(187, 221);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 20);
            this.textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 16;
            // 
            // Quantitylbl
            // 
            this.Quantitylbl.AutoSize = true;
            this.Quantitylbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantitylbl.ForeColor = System.Drawing.Color.White;
            this.Quantitylbl.Location = new System.Drawing.Point(107, 132);
            this.Quantitylbl.Name = "Quantitylbl";
            this.Quantitylbl.Size = new System.Drawing.Size(58, 28);
            this.Quantitylbl.TabIndex = 15;
            this.Quantitylbl.Text = "Email:";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.ForeColor = System.Drawing.Color.White;
            this.pricelbl.Location = new System.Drawing.Point(17, 172);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(155, 28);
            this.pricelbl.TabIndex = 14;
            this.pricelbl.Text = "Security Number : ";
            // 
            // vendorlbl
            // 
            this.vendorlbl.AutoSize = true;
            this.vendorlbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorlbl.ForeColor = System.Drawing.Color.White;
            this.vendorlbl.Location = new System.Drawing.Point(61, 217);
            this.vendorlbl.Name = "vendorlbl";
            this.vendorlbl.Size = new System.Drawing.Size(106, 28);
            this.vendorlbl.TabIndex = 13;
            this.vendorlbl.Text = "User Name :";
            // 
            // Itemlbl
            // 
            this.Itemlbl.AutoSize = true;
            this.Itemlbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemlbl.ForeColor = System.Drawing.Color.White;
            this.Itemlbl.Location = new System.Drawing.Point(101, 86);
            this.Itemlbl.Name = "Itemlbl";
            this.Itemlbl.Size = new System.Drawing.Size(67, 28);
            this.Itemlbl.TabIndex = 12;
            this.Itemlbl.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Update Employee";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 327);
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
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Quantitylbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label vendorlbl;
        private System.Windows.Forms.Label Itemlbl;
        private System.Windows.Forms.Label label1;
    }
}