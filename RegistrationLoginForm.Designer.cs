namespace Library_PR
{
    partial class RegistrationLoginForm
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
            this.loginRBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.signUpRBtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.passTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.attentionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.login2Label = new System.Windows.Forms.Label();
            this.login2TextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pass2Label = new System.Windows.Forms.Label();
            this.pass2TextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginRBtn
            // 
            this.loginRBtn.AutoSize = true;
            this.loginRBtn.Checked = true;
            this.loginRBtn.Depth = 0;
            this.loginRBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.loginRBtn.Location = new System.Drawing.Point(14, 18);
            this.loginRBtn.Margin = new System.Windows.Forms.Padding(0);
            this.loginRBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.loginRBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginRBtn.Name = "loginRBtn";
            this.loginRBtn.Ripple = true;
            this.loginRBtn.Size = new System.Drawing.Size(65, 30);
            this.loginRBtn.TabIndex = 0;
            this.loginRBtn.TabStop = true;
            this.loginRBtn.Text = "Вхід";
            this.loginRBtn.UseVisualStyleBackColor = true;
            this.loginRBtn.CheckedChanged += new System.EventHandler(this.signUpRBtn_CheckedChanged);
            // 
            // signUpRBtn
            // 
            this.signUpRBtn.AutoSize = true;
            this.signUpRBtn.Depth = 0;
            this.signUpRBtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.signUpRBtn.Location = new System.Drawing.Point(120, 18);
            this.signUpRBtn.Margin = new System.Windows.Forms.Padding(0);
            this.signUpRBtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.signUpRBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.signUpRBtn.Name = "signUpRBtn";
            this.signUpRBtn.Ripple = true;
            this.signUpRBtn.Size = new System.Drawing.Size(120, 30);
            this.signUpRBtn.TabIndex = 1;
            this.signUpRBtn.Text = "Реєстрація";
            this.signUpRBtn.UseVisualStyleBackColor = true;
            this.signUpRBtn.CheckedChanged += new System.EventHandler(this.signUpRBtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginRBtn);
            this.groupBox1.Controls.Add(this.signUpRBtn);
            this.groupBox1.Location = new System.Drawing.Point(276, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Depth = 0;
            this.loginTextBox.Hint = "";
            this.loginTextBox.Location = new System.Drawing.Point(356, 217);
            this.loginTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.SelectionLength = 0;
            this.loginTextBox.SelectionStart = 0;
            this.loginTextBox.Size = new System.Drawing.Size(196, 28);
            this.loginTextBox.TabIndex = 3;
            this.loginTextBox.UseSystemPasswordChar = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Location = new System.Drawing.Point(252, 223);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(59, 22);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Login";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.ForeColor = System.Drawing.Color.Black;
            this.passLabel.Location = new System.Drawing.Point(252, 281);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(95, 22);
            this.passLabel.TabIndex = 6;
            this.passLabel.Text = "Password";
            // 
            // passTextBox
            // 
            this.passTextBox.Depth = 0;
            this.passTextBox.Hint = "";
            this.passTextBox.Location = new System.Drawing.Point(356, 275);
            this.passTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '\0';
            this.passTextBox.SelectedText = "";
            this.passTextBox.SelectionLength = 0;
            this.passTextBox.SelectionStart = 0;
            this.passTextBox.Size = new System.Drawing.Size(196, 28);
            this.passTextBox.TabIndex = 5;
            this.passTextBox.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(369, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "HI,";
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Transparent;
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitBtn.ForeColor = System.Drawing.Color.DimGray;
            this.submitBtn.Location = new System.Drawing.Point(347, 394);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(109, 36);
            this.submitBtn.TabIndex = 32;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // attentionLabel
            // 
            this.attentionLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.attentionLabel.AutoSize = true;
            this.attentionLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attentionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.attentionLabel.Location = new System.Drawing.Point(198, 458);
            this.attentionLabel.Name = "attentionLabel";
            this.attentionLabel.Size = new System.Drawing.Size(104, 22);
            this.attentionLabel.TabIndex = 33;
            this.attentionLabel.Text = "*attention";
            this.attentionLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.attentionLabel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(95, 223);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(66, 22);
            this.nameLabel.TabIndex = 35;
            this.nameLabel.Text = "Name";
            this.nameLabel.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Depth = 0;
            this.nameTextBox.Hint = "";
            this.nameTextBox.Location = new System.Drawing.Point(199, 217);
            this.nameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.Size = new System.Drawing.Size(196, 28);
            this.nameTextBox.TabIndex = 34;
            this.nameTextBox.UseSystemPasswordChar = false;
            this.nameTextBox.Visible = false;
            // 
            // login2Label
            // 
            this.login2Label.AutoSize = true;
            this.login2Label.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login2Label.ForeColor = System.Drawing.Color.Black;
            this.login2Label.Location = new System.Drawing.Point(95, 281);
            this.login2Label.Name = "login2Label";
            this.login2Label.Size = new System.Drawing.Size(59, 22);
            this.login2Label.TabIndex = 37;
            this.login2Label.Text = "Login";
            this.login2Label.Visible = false;
            // 
            // login2TextBox
            // 
            this.login2TextBox.Depth = 0;
            this.login2TextBox.Hint = "";
            this.login2TextBox.Location = new System.Drawing.Point(199, 275);
            this.login2TextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.login2TextBox.Name = "login2TextBox";
            this.login2TextBox.PasswordChar = '\0';
            this.login2TextBox.SelectedText = "";
            this.login2TextBox.SelectionLength = 0;
            this.login2TextBox.SelectionStart = 0;
            this.login2TextBox.Size = new System.Drawing.Size(196, 28);
            this.login2TextBox.TabIndex = 36;
            this.login2TextBox.UseSystemPasswordChar = false;
            this.login2TextBox.Visible = false;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(416, 223);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(56, 22);
            this.emailLabel.TabIndex = 39;
            this.emailLabel.Text = "Email";
            this.emailLabel.Visible = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Depth = 0;
            this.emailTextBox.Hint = "";
            this.emailTextBox.Location = new System.Drawing.Point(520, 217);
            this.emailTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.SelectionLength = 0;
            this.emailTextBox.SelectionStart = 0;
            this.emailTextBox.Size = new System.Drawing.Size(196, 28);
            this.emailTextBox.TabIndex = 38;
            this.emailTextBox.UseSystemPasswordChar = false;
            this.emailTextBox.Visible = false;
            // 
            // pass2Label
            // 
            this.pass2Label.AutoSize = true;
            this.pass2Label.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass2Label.ForeColor = System.Drawing.Color.Black;
            this.pass2Label.Location = new System.Drawing.Point(416, 281);
            this.pass2Label.Name = "pass2Label";
            this.pass2Label.Size = new System.Drawing.Size(95, 22);
            this.pass2Label.TabIndex = 41;
            this.pass2Label.Text = "Password";
            this.pass2Label.Visible = false;
            // 
            // pass2TextBox
            // 
            this.pass2TextBox.Depth = 0;
            this.pass2TextBox.Hint = "";
            this.pass2TextBox.Location = new System.Drawing.Point(520, 275);
            this.pass2TextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.pass2TextBox.Name = "pass2TextBox";
            this.pass2TextBox.PasswordChar = '\0';
            this.pass2TextBox.SelectedText = "";
            this.pass2TextBox.SelectionLength = 0;
            this.pass2TextBox.SelectionStart = 0;
            this.pass2TextBox.Size = new System.Drawing.Size(196, 28);
            this.pass2TextBox.TabIndex = 40;
            this.pass2TextBox.UseSystemPasswordChar = false;
            this.pass2TextBox.Visible = false;
            // 
            // RegistrationLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.pass2Label);
            this.Controls.Add(this.pass2TextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.login2Label);
            this.Controls.Add(this.login2TextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.attentionLabel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrationLoginForm";
            this.Text = "Вхід/Реєстрація";
            this.Load += new System.EventHandler(this.RegistrationLoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton loginRBtn;
        private MaterialSkin.Controls.MaterialRadioButton signUpRBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField passTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label attentionLabel;
        private System.Windows.Forms.Label nameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField nameTextBox;
        private System.Windows.Forms.Label login2Label;
        private MaterialSkin.Controls.MaterialSingleLineTextField login2TextBox;
        private System.Windows.Forms.Label emailLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailTextBox;
        private System.Windows.Forms.Label pass2Label;
        private MaterialSkin.Controls.MaterialSingleLineTextField pass2TextBox;
    }
}