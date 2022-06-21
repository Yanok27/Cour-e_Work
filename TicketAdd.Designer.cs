namespace BusStation
{
    partial class TicketAdd
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
            this.PlaceTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.BuyTimeTB = new System.Windows.Forms.DateTimePicker();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.PassIdTB = new System.Windows.Forms.TextBox();
            this.PrivChB = new System.Windows.Forms.CheckBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlaceTB
            // 
            this.PlaceTB.Location = new System.Drawing.Point(130, 25);
            this.PlaceTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlaceTB.Name = "PlaceTB";
            this.PlaceTB.Size = new System.Drawing.Size(121, 27);
            this.PlaceTB.TabIndex = 0;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(130, 94);
            this.PriceTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(121, 27);
            this.PriceTB.TabIndex = 1;
            // 
            // BuyTimeTB
            // 
            this.BuyTimeTB.Location = new System.Drawing.Point(130, 156);
            this.BuyTimeTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuyTimeTB.Name = "BuyTimeTB";
            this.BuyTimeTB.Size = new System.Drawing.Size(228, 27);
            this.BuyTimeTB.TabIndex = 2;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(488, 25);
            this.NameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(197, 27);
            this.NameTB.TabIndex = 3;
            // 
            // PassIdTB
            // 
            this.PassIdTB.Location = new System.Drawing.Point(488, 91);
            this.PassIdTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassIdTB.Name = "PassIdTB";
            this.PassIdTB.Size = new System.Drawing.Size(197, 27);
            this.PassIdTB.TabIndex = 4;
            // 
            // PrivChB
            // 
            this.PrivChB.AutoSize = true;
            this.PrivChB.Location = new System.Drawing.Point(488, 156);
            this.PrivChB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrivChB.Name = "PrivChB";
            this.PrivChB.Size = new System.Drawing.Size(18, 17);
            this.PrivChB.TabIndex = 5;
            this.PrivChB.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(234)))), ((int)(((byte)(138)))));
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.AddBtn.Location = new System.Drawing.Point(394, 231);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(159, 61);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Додати";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Місце";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Вартість";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Час купівлі";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "П.І.Б пасажира";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Номер паспорта";
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Пільги";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(234)))), ((int)(((byte)(138)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(566, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 61);
            this.button1.TabIndex = 13;
            this.button1.Text = "Відмінити";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TicketAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(737, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PrivChB);
            this.Controls.Add(this.PassIdTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.BuyTimeTB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.PlaceTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TicketAdd";
            this.Text = "TicketAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PlaceTB;
        private TextBox PriceTB;
        private DateTimePicker BuyTimeTB;
        private TextBox NameTB;
        private TextBox PassIdTB;
        private CheckBox PrivChB;
        private Button AddBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}