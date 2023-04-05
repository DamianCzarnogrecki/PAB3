namespace PAB3
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
            dataGridView1 = new DataGridView();
            textbox_adres = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            textbox_miejscowosc = new TextBox();
            label3 = new Label();
            textbox_wojewodztwo = new TextBox();
            label4 = new Label();
            textbox_powiat = new TextBox();
            label5 = new Label();
            textbox_kod = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(560, 450);
            dataGridView1.TabIndex = 0;
            // 
            // textbox_adres
            // 
            textbox_adres.Location = new Point(566, 86);
            textbox_adres.Name = "textbox_adres";
            textbox_adres.Size = new Size(222, 23);
            textbox_adres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(566, 68);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Adres:";
            // 
            // button1
            // 
            button1.Location = new Point(566, 415);
            button1.Name = "button1";
            button1.Size = new Size(222, 23);
            button1.TabIndex = 3;
            button1.Text = "Wyszukaj (Dapper – kwerenda SQL)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(566, 122);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 5;
            label2.Text = "Miejscowość:";
            // 
            // textbox_miejscowosc
            // 
            textbox_miejscowosc.Location = new Point(566, 140);
            textbox_miejscowosc.Name = "textbox_miejscowosc";
            textbox_miejscowosc.Size = new Size(222, 23);
            textbox_miejscowosc.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(566, 177);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 7;
            label3.Text = "Województwo:";
            // 
            // textbox_wojewodztwo
            // 
            textbox_wojewodztwo.Location = new Point(566, 195);
            textbox_wojewodztwo.Name = "textbox_wojewodztwo";
            textbox_wojewodztwo.Size = new Size(222, 23);
            textbox_wojewodztwo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(566, 231);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 9;
            label4.Text = "Powiat:";
            // 
            // textbox_powiat
            // 
            textbox_powiat.Location = new Point(566, 249);
            textbox_powiat.Name = "textbox_powiat";
            textbox_powiat.Size = new Size(222, 23);
            textbox_powiat.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(566, 15);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 11;
            label5.Text = "Kod pocztowy:";
            // 
            // textbox_kod
            // 
            textbox_kod.Location = new Point(566, 33);
            textbox_kod.Name = "textbox_kod";
            textbox_kod.Size = new Size(222, 23);
            textbox_kod.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(566, 386);
            button2.Name = "button2";
            button2.Size = new Size(222, 23);
            button2.TabIndex = 12;
            button2.Text = "Wyszukaj (Entity Framework – LINQ)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textbox_kod);
            Controls.Add(label4);
            Controls.Add(textbox_powiat);
            Controls.Add(label3);
            Controls.Add(textbox_wojewodztwo);
            Controls.Add(label2);
            Controls.Add(textbox_miejscowosc);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textbox_adres);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textbox_adres;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textbox_miejscowosc;
        private Label label3;
        private TextBox textbox_wojewodztwo;
        private Label label4;
        private TextBox textbox_powiat;
        private Label label5;
        private TextBox textbox_kod;
        private Button button2;
    }
}