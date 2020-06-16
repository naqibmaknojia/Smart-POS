namespace Smart_Pos
{
    partial class CartPagecs
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
            this.Inventorylbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inventorylbl
            // 
            this.Inventorylbl.AutoSize = true;
            this.Inventorylbl.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventorylbl.Location = new System.Drawing.Point(336, 18);
            this.Inventorylbl.Name = "Inventorylbl";
            this.Inventorylbl.Size = new System.Drawing.Size(58, 36);
            this.Inventorylbl.TabIndex = 2;
            this.Inventorylbl.Text = "Cart";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(752, 431);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Ammount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 4;
            // 
            // CheckOut
            // 
            this.CheckOut.BackColor = System.Drawing.SystemColors.Highlight;
            this.CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOut.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOut.ForeColor = System.Drawing.Color.White;
            this.CheckOut.Location = new System.Drawing.Point(600, 499);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(148, 42);
            this.CheckOut.TabIndex = 5;
            this.CheckOut.Text = "CheckOut";
            this.CheckOut.UseVisualStyleBackColor = false;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // CartPagecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 540);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Inventorylbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartPagecs";
            this.Text = "CartPagecs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Inventorylbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CheckOut;
    }
}