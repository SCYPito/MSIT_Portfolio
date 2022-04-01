namespace work0101_Module09
{
    partial class LogInForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.uesrLogLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userPasswordTextBox = new System.Windows.Forms.TextBox();
            this.logButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uesrLogLabel
            // 
            this.uesrLogLabel.AutoSize = true;
            this.uesrLogLabel.Location = new System.Drawing.Point(140, 35);
            this.uesrLogLabel.Name = "uesrLogLabel";
            this.uesrLogLabel.Size = new System.Drawing.Size(105, 20);
            this.uesrLogLabel.TabIndex = 0;
            this.uesrLogLabel.Text = "會員登入系統";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(25, 74);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(79, 20);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "(&U)帳號：";
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.Location = new System.Drawing.Point(27, 108);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(77, 20);
            this.userPasswordLabel.TabIndex = 3;
            this.userPasswordLabel.Text = "(&P)密碼：";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(107, 69);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(165, 29);
            this.userNameTextBox.TabIndex = 2;
            // 
            // userPasswordTextBox
            // 
            this.userPasswordTextBox.Location = new System.Drawing.Point(107, 104);
            this.userPasswordTextBox.Name = "userPasswordTextBox";
            this.userPasswordTextBox.Size = new System.Drawing.Size(165, 29);
            this.userPasswordTextBox.TabIndex = 4;
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(107, 148);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(162, 33);
            this.logButton.TabIndex = 5;
            this.logButton.Text = "確定";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 229);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.userPasswordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.uesrLogLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LogInForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uesrLogLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userPasswordLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.Button logButton;
    }
}

