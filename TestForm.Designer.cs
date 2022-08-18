namespace ListTest
{
    partial class TestForm
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
            this.btnTest = new System.Windows.Forms.Button();
            this.TBoxSearch = new System.Windows.Forms.TextBox();
            this.TBoxName = new System.Windows.Forms.TextBox();
            this.BTNInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxAccount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(234, 94);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(140, 52);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "搜尋會員帳號";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // TBoxSearch
            // 
            this.TBoxSearch.Location = new System.Drawing.Point(380, 94);
            this.TBoxSearch.Multiline = true;
            this.TBoxSearch.Name = "TBoxSearch";
            this.TBoxSearch.Size = new System.Drawing.Size(135, 52);
            this.TBoxSearch.TabIndex = 1;
            // 
            // TBoxName
            // 
            this.TBoxName.Location = new System.Drawing.Point(249, 213);
            this.TBoxName.Multiline = true;
            this.TBoxName.Name = "TBoxName";
            this.TBoxName.Size = new System.Drawing.Size(124, 37);
            this.TBoxName.TabIndex = 2;
            // 
            // BTNInsert
            // 
            this.BTNInsert.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTNInsert.Location = new System.Drawing.Point(623, 219);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(90, 37);
            this.BTNInsert.TabIndex = 3;
            this.BTNInsert.Text = "新增";
            this.BTNInsert.UseVisualStyleBackColor = true;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(158, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(379, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "帳號";
            // 
            // TBoxAccount
            // 
            this.TBoxAccount.Location = new System.Drawing.Point(470, 216);
            this.TBoxAccount.Multiline = true;
            this.TBoxAccount.Name = "TBoxAccount";
            this.TBoxAccount.Size = new System.Drawing.Size(124, 37);
            this.TBoxAccount.TabIndex = 5;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNInsert);
            this.Controls.Add(this.TBoxName);
            this.Controls.Add(this.TBoxSearch);
            this.Controls.Add(this.btnTest);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox TBoxSearch;
        private System.Windows.Forms.TextBox TBoxName;
        private System.Windows.Forms.Button BTNInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxAccount;
    }
}