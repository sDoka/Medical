namespace Ирке
{
    partial class FIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FIO));
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.otchestvo = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.name = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.familia = new System.Windows.Forms.TextBox();
            this.next_page_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(9, 144);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(54, 13);
            this.linkLabel3.TabIndex = 11;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Отчество";
            // 
            // otchestvo
            // 
            this.otchestvo.Location = new System.Drawing.Point(12, 170);
            this.otchestvo.Name = "otchestvo";
            this.otchestvo.Size = new System.Drawing.Size(121, 20);
            this.otchestvo.TabIndex = 10;
            this.otchestvo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyRus);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(9, 81);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(29, 13);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Имя";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 107);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 8;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyRus);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Фамилия";
            // 
            // familia
            // 
            this.familia.Location = new System.Drawing.Point(12, 45);
            this.familia.Name = "familia";
            this.familia.Size = new System.Drawing.Size(121, 20);
            this.familia.TabIndex = 6;
            this.familia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyRus);
            // 
            // next_page_btn
            // 
            this.next_page_btn.Location = new System.Drawing.Point(29, 207);
            this.next_page_btn.Name = "next_page_btn";
            this.next_page_btn.Size = new System.Drawing.Size(86, 23);
            this.next_page_btn.TabIndex = 12;
            this.next_page_btn.Text = "Продолжить";
            this.next_page_btn.UseVisualStyleBackColor = true;
            this.next_page_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 242);
            this.Controls.Add(this.next_page_btn);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.otchestvo);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.familia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Опросник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FIO_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox otchestvo;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox familia;
        private System.Windows.Forms.Button next_page_btn;
    }
}