namespace BusStation
{
    partial class DriverAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.BirthDateTB = new System.Windows.Forms.DateTimePicker();
            this.PassIdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(234)))), ((int)(((byte)(138)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(34, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(186, 39);
            this.NameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(228, 27);
            this.NameTB.TabIndex = 1;
            // 
            // BirthDateTB
            // 
            this.BirthDateTB.Location = new System.Drawing.Point(186, 87);
            this.BirthDateTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BirthDateTB.Name = "BirthDateTB";
            this.BirthDateTB.Size = new System.Drawing.Size(228, 27);
            this.BirthDateTB.TabIndex = 2;
            // 
            // PassIdTB
            // 
            this.PassIdTB.Location = new System.Drawing.Point(186, 142);
            this.PassIdTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PassIdTB.Name = "PassIdTB";
            this.PassIdTB.Size = new System.Drawing.Size(228, 27);
            this.PassIdTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "П.І.Б";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата народження";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер паспорту";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(234)))), ((int)(((byte)(138)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(227, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 61);
            this.button2.TabIndex = 7;
            this.button2.Text = "Відмінити";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DriverAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(231)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(448, 306);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassIdTB);
            this.Controls.Add(this.BirthDateTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DriverAdd";
            this.Text = "DriverAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox NameTB;
        private DateTimePicker BirthDateTB;
        private TextBox PassIdTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}