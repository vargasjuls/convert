namespace JULIANA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.display_txt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.frcomboBox1 = new System.Windows.Forms.ComboBox();
            this.tocomboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_con = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER AMOUNT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONVERT FROM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONVERT TO:";
            // 
            // display_txt
            // 
            this.display_txt.AutoSize = true;
            this.display_txt.BackColor = System.Drawing.Color.White;
            this.display_txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_txt.Location = new System.Drawing.Point(231, 536);
            this.display_txt.Name = "display_txt";
            this.display_txt.Size = new System.Drawing.Size(287, 28);
            this.display_txt.TabIndex = 3;
            this.display_txt.Text = "CONVERTED AMOUNT:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(394, 217);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 28);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frcomboBox1
            // 
            this.frcomboBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.frcomboBox1.FormattingEnabled = true;
            this.frcomboBox1.Items.AddRange(new object[] {
            "PESO",
            "DOLLAR",
            "WON",
            "YEN"});
            this.frcomboBox1.Location = new System.Drawing.Point(394, 303);
            this.frcomboBox1.Name = "frcomboBox1";
            this.frcomboBox1.Size = new System.Drawing.Size(270, 24);
            this.frcomboBox1.TabIndex = 5;
            // 
            // tocomboBox2
            // 
            this.tocomboBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tocomboBox2.FormattingEnabled = true;
            this.tocomboBox2.Items.AddRange(new object[] {
            "PESO",
            "DOLLAR",
            "WON",
            "YEN"});
            this.tocomboBox2.Location = new System.Drawing.Point(394, 385);
            this.tocomboBox2.Name = "tocomboBox2";
            this.tocomboBox2.Size = new System.Drawing.Size(270, 24);
            this.tocomboBox2.TabIndex = 6;
            // 
            // btn_con
            // 
            this.btn_con.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_con.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_con.Location = new System.Drawing.Point(158, 453);
            this.btn_con.Name = "btn_con";
            this.btn_con.Size = new System.Drawing.Size(516, 55);
            this.btn_con.TabIndex = 7;
            this.btn_con.Text = "CONVERT";
            this.btn_con.UseVisualStyleBackColor = false;
            this.btn_con.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Rockwell", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "CURRENCY CONVERTER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(776, 695);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_con);
            this.Controls.Add(this.tocomboBox2);
            this.Controls.Add(this.frcomboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.display_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CURRENCY CONVERTER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label display_txt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox frcomboBox1;
        private System.Windows.Forms.ComboBox tocomboBox2;
        private System.Windows.Forms.Button btn_con;
        private System.Windows.Forms.Label label5;
    }
}

