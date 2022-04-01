namespace work0101_Module09
{
    partial class userInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userInfoForm));
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.uesrNameLabel = new System.Windows.Forms.Label();
            this.uesrPhoneLabel = new System.Windows.Forms.Label();
            this.userBirthLabel = new System.Windows.Forms.Label();
            this.userAddressLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userPhoneTextBox = new System.Windows.Forms.TextBox();
            this.userAddressTextBox = new System.Windows.Forms.TextBox();
            this.uesrSexGroupBox = new System.Windows.Forms.GroupBox();
            this.SexMRadioButton = new System.Windows.Forms.RadioButton();
            this.SexFRadioButton = new System.Windows.Forms.RadioButton();
            this.userBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userPicPictureBox = new System.Windows.Forms.PictureBox();
            this.uesrSexGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.AutoSize = true;
            this.userInfoLabel.Location = new System.Drawing.Point(235, 25);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(105, 20);
            this.userInfoLabel.TabIndex = 0;
            this.userInfoLabel.Text = "會員基本資料";
            // 
            // uesrNameLabel
            // 
            this.uesrNameLabel.AutoSize = true;
            this.uesrNameLabel.Location = new System.Drawing.Point(34, 68);
            this.uesrNameLabel.Name = "uesrNameLabel";
            this.uesrNameLabel.Size = new System.Drawing.Size(41, 20);
            this.uesrNameLabel.TabIndex = 1;
            this.uesrNameLabel.Text = "姓名";
            // 
            // uesrPhoneLabel
            // 
            this.uesrPhoneLabel.AutoSize = true;
            this.uesrPhoneLabel.Location = new System.Drawing.Point(34, 272);
            this.uesrPhoneLabel.Name = "uesrPhoneLabel";
            this.uesrPhoneLabel.Size = new System.Drawing.Size(41, 20);
            this.uesrPhoneLabel.TabIndex = 2;
            this.uesrPhoneLabel.Text = "電話";
            // 
            // userBirthLabel
            // 
            this.userBirthLabel.AutoSize = true;
            this.userBirthLabel.Location = new System.Drawing.Point(34, 216);
            this.userBirthLabel.Name = "userBirthLabel";
            this.userBirthLabel.Size = new System.Drawing.Size(41, 20);
            this.userBirthLabel.TabIndex = 3;
            this.userBirthLabel.Text = "生日";
            // 
            // userAddressLabel
            // 
            this.userAddressLabel.AutoSize = true;
            this.userAddressLabel.Location = new System.Drawing.Point(34, 327);
            this.userAddressLabel.Name = "userAddressLabel";
            this.userAddressLabel.Size = new System.Drawing.Size(41, 20);
            this.userAddressLabel.TabIndex = 4;
            this.userAddressLabel.Text = "地址";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(90, 65);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(165, 29);
            this.userNameTextBox.TabIndex = 5;
            // 
            // userPhoneTextBox
            // 
            this.userPhoneTextBox.Location = new System.Drawing.Point(90, 269);
            this.userPhoneTextBox.Name = "userPhoneTextBox";
            this.userPhoneTextBox.Size = new System.Drawing.Size(165, 29);
            this.userPhoneTextBox.TabIndex = 6;
            // 
            // userAddressTextBox
            // 
            this.userAddressTextBox.Location = new System.Drawing.Point(90, 324);
            this.userAddressTextBox.Name = "userAddressTextBox";
            this.userAddressTextBox.Size = new System.Drawing.Size(408, 29);
            this.userAddressTextBox.TabIndex = 7;
            // 
            // uesrSexGroupBox
            // 
            this.uesrSexGroupBox.Controls.Add(this.SexFRadioButton);
            this.uesrSexGroupBox.Controls.Add(this.SexMRadioButton);
            this.uesrSexGroupBox.Location = new System.Drawing.Point(90, 120);
            this.uesrSexGroupBox.Name = "uesrSexGroupBox";
            this.uesrSexGroupBox.Size = new System.Drawing.Size(165, 64);
            this.uesrSexGroupBox.TabIndex = 8;
            this.uesrSexGroupBox.TabStop = false;
            this.uesrSexGroupBox.Text = "性別";
            // 
            // SexMRadioButton
            // 
            this.SexMRadioButton.AutoSize = true;
            this.SexMRadioButton.Location = new System.Drawing.Point(17, 28);
            this.SexMRadioButton.Name = "SexMRadioButton";
            this.SexMRadioButton.Size = new System.Drawing.Size(43, 24);
            this.SexMRadioButton.TabIndex = 0;
            this.SexMRadioButton.TabStop = true;
            this.SexMRadioButton.Text = "男";
            this.SexMRadioButton.UseVisualStyleBackColor = true;
            // 
            // SexFRadioButton
            // 
            this.SexFRadioButton.AutoSize = true;
            this.SexFRadioButton.Location = new System.Drawing.Point(92, 28);
            this.SexFRadioButton.Name = "SexFRadioButton";
            this.SexFRadioButton.Size = new System.Drawing.Size(43, 24);
            this.SexFRadioButton.TabIndex = 1;
            this.SexFRadioButton.TabStop = true;
            this.SexFRadioButton.Text = "女";
            this.SexFRadioButton.UseVisualStyleBackColor = true;
            // 
            // userBirthDateTimePicker
            // 
            this.userBirthDateTimePicker.Location = new System.Drawing.Point(90, 210);
            this.userBirthDateTimePicker.Name = "userBirthDateTimePicker";
            this.userBirthDateTimePicker.Size = new System.Drawing.Size(165, 29);
            this.userBirthDateTimePicker.TabIndex = 9;
            // 
            // userPicPictureBox
            // 
            this.userPicPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPicPictureBox.Image")));
            this.userPicPictureBox.Location = new System.Drawing.Point(298, 65);
            this.userPicPictureBox.Name = "userPicPictureBox";
            this.userPicPictureBox.Size = new System.Drawing.Size(200, 200);
            this.userPicPictureBox.TabIndex = 10;
            this.userPicPictureBox.TabStop = false;
            // 
            // userInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 405);
            this.Controls.Add(this.userPicPictureBox);
            this.Controls.Add(this.userBirthDateTimePicker);
            this.Controls.Add(this.uesrSexGroupBox);
            this.Controls.Add(this.userAddressTextBox);
            this.Controls.Add(this.userPhoneTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userAddressLabel);
            this.Controls.Add(this.userBirthLabel);
            this.Controls.Add(this.uesrPhoneLabel);
            this.Controls.Add(this.uesrNameLabel);
            this.Controls.Add(this.userInfoLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "userInfoForm";
            this.Text = "Form2";
            this.uesrSexGroupBox.ResumeLayout(false);
            this.uesrSexGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.Label uesrNameLabel;
        private System.Windows.Forms.Label uesrPhoneLabel;
        private System.Windows.Forms.Label userBirthLabel;
        private System.Windows.Forms.Label userAddressLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userPhoneTextBox;
        private System.Windows.Forms.TextBox userAddressTextBox;
        private System.Windows.Forms.GroupBox uesrSexGroupBox;
        private System.Windows.Forms.RadioButton SexFRadioButton;
        private System.Windows.Forms.RadioButton SexMRadioButton;
        private System.Windows.Forms.DateTimePicker userBirthDateTimePicker;
        private System.Windows.Forms.PictureBox userPicPictureBox;
    }
}