namespace InstantOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transaction_id = new System.Windows.Forms.Label();
            this.table_number = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chicken_quantity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spaghetti_quantity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.frenchfries_quantity = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.total_amount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 453);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "PAID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transaction ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // transaction_id
            // 
            this.transaction_id.AutoSize = true;
            this.transaction_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_id.Location = new System.Drawing.Point(127, 37);
            this.transaction_id.Name = "transaction_id";
            this.transaction_id.Size = new System.Drawing.Size(20, 24);
            this.transaction_id.TabIndex = 5;
            this.transaction_id.Text = "1";
            // 
            // table_number
            // 
            this.table_number.AutoSize = true;
            this.table_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_number.Location = new System.Drawing.Point(109, 256);
            this.table_number.Name = "table_number";
            this.table_number.Size = new System.Drawing.Size(0, 24);
            this.table_number.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Food Status:";
            // 
            // chicken_quantity
            // 
            this.chicken_quantity.AutoSize = true;
            this.chicken_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chicken_quantity.Location = new System.Drawing.Point(162, 67);
            this.chicken_quantity.Name = "chicken_quantity";
            this.chicken_quantity.Size = new System.Drawing.Size(20, 24);
            this.chicken_quantity.TabIndex = 9;
            this.chicken_quantity.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Chicken Quantity:";
            // 
            // spaghetti_quantity
            // 
            this.spaghetti_quantity.AutoSize = true;
            this.spaghetti_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaghetti_quantity.Location = new System.Drawing.Point(162, 107);
            this.spaghetti_quantity.Name = "spaghetti_quantity";
            this.spaghetti_quantity.Size = new System.Drawing.Size(20, 24);
            this.spaghetti_quantity.TabIndex = 11;
            this.spaghetti_quantity.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Spaghetti Quantity: ";
            // 
            // frenchfries_quantity
            // 
            this.frenchfries_quantity.AutoSize = true;
            this.frenchfries_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frenchfries_quantity.Location = new System.Drawing.Point(193, 147);
            this.frenchfries_quantity.Name = "frenchfries_quantity";
            this.frenchfries_quantity.Size = new System.Drawing.Size(20, 24);
            this.frenchfries_quantity.TabIndex = 13;
            this.frenchfries_quantity.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-1, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "French Fries Quantity: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(289, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 29);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(698, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 29);
            this.button2.TabIndex = 17;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // total_amount
            // 
            this.total_amount.AutoSize = true;
            this.total_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_amount.Location = new System.Drawing.Point(127, 184);
            this.total_amount.Name = "total_amount";
            this.total_amount.Size = new System.Drawing.Size(40, 24);
            this.total_amount.TabIndex = 19;
            this.total_amount.Text = "200";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(-1, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 24);
            this.label14.TabIndex = 18;
            this.label14.Text = "Total Amount:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(62, 220);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(52, 24);
            this.status.TabIndex = 21;
            this.status.Text = "PAID";
            this.status.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(-1, 220);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 24);
            this.label16.TabIndex = 20;
            this.label16.Text = "Status:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(827, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 29);
            this.button3.TabIndex = 22;
            this.button3.Text = "refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(156, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 41);
            this.button4.TabIndex = 23;
            this.button4.Text = "COOK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 502);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.total_amount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.frenchfries_quantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.spaghetti_quantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chicken_quantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.table_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transaction_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label transaction_id;
        private System.Windows.Forms.Label table_number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label chicken_quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label spaghetti_quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label frenchfries_quantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label total_amount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

