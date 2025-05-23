namespace Ordering_Interface
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Nametxt = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.production = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Label();
            this.rbnCashondelivery = new System.Windows.Forms.RadioButton();
            this.rbnATM = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Nametxt
            // 
            this.Nametxt.AutoSize = true;
            this.Nametxt.Font = new System.Drawing.Font("新細明體", 15F);
            this.Nametxt.Location = new System.Drawing.Point(68, 43);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(62, 25);
            this.Nametxt.TabIndex = 0;
            this.Nametxt.Text = "姓名";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("新細明體", 15F);
            this.txbName.Location = new System.Drawing.Point(153, 37);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(319, 37);
            this.txbName.TabIndex = 1;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // production
            // 
            this.production.AutoSize = true;
            this.production.Font = new System.Drawing.Font("新細明體", 15F);
            this.production.Location = new System.Drawing.Point(67, 111);
            this.production.Name = "production";
            this.production.Size = new System.Drawing.Size(62, 25);
            this.production.TabIndex = 2;
            this.production.Text = "產品";
            // 
            // pay
            // 
            this.pay.AutoSize = true;
            this.pay.Font = new System.Drawing.Font("新細明體", 15F);
            this.pay.Location = new System.Drawing.Point(377, 111);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(112, 25);
            this.pay.TabIndex = 3;
            this.pay.Text = "付款型式";
            // 
            // rbnCashondelivery
            // 
            this.rbnCashondelivery.AutoSize = true;
            this.rbnCashondelivery.Font = new System.Drawing.Font("新細明體", 12F);
            this.rbnCashondelivery.Location = new System.Drawing.Point(400, 176);
            this.rbnCashondelivery.Name = "rbnCashondelivery";
            this.rbnCashondelivery.Size = new System.Drawing.Size(110, 24);
            this.rbnCashondelivery.TabIndex = 4;
            this.rbnCashondelivery.TabStop = true;
            this.rbnCashondelivery.Text = "貨到付款";
            this.rbnCashondelivery.UseVisualStyleBackColor = true;
            // 
            // rbnATM
            // 
            this.rbnATM.AutoSize = true;
            this.rbnATM.Font = new System.Drawing.Font("新細明體", 12F);
            this.rbnATM.Location = new System.Drawing.Point(400, 243);
            this.rbnATM.Name = "rbnATM";
            this.rbnATM.Size = new System.Drawing.Size(72, 24);
            this.rbnATM.TabIndex = 5;
            this.rbnATM.TabStop = true;
            this.rbnATM.Text = "ATM";
            this.rbnATM.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Xbox360",
            "PS4",
            "PSP",
            "PS2",
            "Switch"});
            this.checkedListBox1.Location = new System.Drawing.Point(72, 166);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(208, 104);
            this.checkedListBox1.TabIndex = 6;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(67, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "送貨日期";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("新細明體", 15F);
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 340);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(416, 25);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(72, 387);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 33);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "確認";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(72, 439);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(417, 53);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 515);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.rbnATM);
            this.Controls.Add(this.rbnCashondelivery);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.production);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.Nametxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "訂貨程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nametxt;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label production;
        private System.Windows.Forms.Label pay;
        private System.Windows.Forms.RadioButton rbnCashondelivery;
        private System.Windows.Forms.RadioButton rbnATM;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

