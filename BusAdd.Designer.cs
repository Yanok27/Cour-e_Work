namespace BusStation
{
    partial class BusAdd
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
            this.BusNoTB = new System.Windows.Forms.TextBox();
            this.BusModelTB = new System.Windows.Forms.TextBox();
            this.PlaceCountTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BusNoTB
            // 
            this.BusNoTB.Location = new System.Drawing.Point(159, 84);
            this.BusNoTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BusNoTB.Name = "BusNoTB";
            this.BusNoTB.Size = new System.Drawing.Size(170, 27);
            this.BusNoTB.TabIndex = 0;
            // 
            // BusModelTB
            // 
            this.BusModelTB.Location = new System.Drawing.Point(159, 32);
            this.BusModelTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BusModelTB.Name = "BusModelTB";
            this.BusModelTB.Size = new System.Drawing.Size(170, 27);
            this.BusModelTB.TabIndex = 1;
            
            // 
            // PlaceCountTB
            // 
            this.PlaceCountTB.Location = new System.Drawing.Point(159, 140);
            this.PlaceCountTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlaceCountTB.Name = "PlaceCountTB";
            this.PlaceCountTB.Size = new System.Drawing.Size(170, 27);
            this.PlaceCountTB.TabIndex = 2;
            
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(234)))), ((int)(((byte)(138)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(19, 233);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Модель ТЗ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кількість місць";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(234)))), ((int)(((byte)(138)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(211, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 61);
            this.button2.TabIndex = 7;
            this.button2.Text = "Відмінити";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BusAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(396, 337);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlaceCountTB);
            this.Controls.Add(this.BusModelTB);
            this.Controls.Add(this.BusNoTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BusAdd";
            this.Text = "BusAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox BusNoTB;
        private TextBox BusModelTB;
        private TextBox PlaceCountTB;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}