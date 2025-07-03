namespace BeautyBuzz
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
            this.textCreateAc1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateAcName = new System.Windows.Forms.Label();
            this.FirstNameCreateAc = new System.Windows.Forms.Label();
            this.textBoxCreateAc2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.or = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SignUp = new System.Windows.Forms.Button();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textCreateAc1
            // 
            this.textCreateAc1.Location = new System.Drawing.Point(635, 136);
            this.textCreateAc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCreateAc1.Name = "textCreateAc1";
            this.textCreateAc1.Size = new System.Drawing.Size(213, 22);
            this.textCreateAc1.TabIndex = 0;
            this.textCreateAc1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textCreateAc1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCreateAc1_KeyDown);
            this.textCreateAc1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCreateAc1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Account";
            // 
            // CreateAcName
            // 
            this.CreateAcName.AutoSize = true;
            this.CreateAcName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAcName.Location = new System.Drawing.Point(512, 139);
            this.CreateAcName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CreateAcName.Name = "CreateAcName";
            this.CreateAcName.Size = new System.Drawing.Size(100, 16);
            this.CreateAcName.TabIndex = 3;
            this.CreateAcName.Text = "Your LastName";
            // 
            // FirstNameCreateAc
            // 
            this.FirstNameCreateAc.AutoSize = true;
            this.FirstNameCreateAc.Location = new System.Drawing.Point(512, 196);
            this.FirstNameCreateAc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FirstNameCreateAc.Name = "FirstNameCreateAc";
            this.FirstNameCreateAc.Size = new System.Drawing.Size(100, 16);
            this.FirstNameCreateAc.TabIndex = 5;
            this.FirstNameCreateAc.Text = "Your FirstName";
            // 
            // textBoxCreateAc2
            // 
            this.textBoxCreateAc2.Location = new System.Drawing.Point(635, 193);
            this.textBoxCreateAc2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCreateAc2.Name = "textBoxCreateAc2";
            this.textBoxCreateAc2.Size = new System.Drawing.Size(213, 22);
            this.textBoxCreateAc2.TabIndex = 1;
            this.textBoxCreateAc2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCreateAc2_KeyDown);
            this.textBoxCreateAc2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCreateAc2_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(609, 240);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.checkBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox1_KeyDown);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(631, 240);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(97, 16);
            this.PhoneNumber.TabIndex = 2;
            this.PhoneNumber.Text = "Phone Number";
            this.PhoneNumber.Click += new System.EventHandler(this.label2_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(808, 240);
            this.Email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(779, 240);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            this.checkBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox2_KeyDown);
            // 
            // or
            // 
            this.or.AutoSize = true;
            this.or.Location = new System.Drawing.Point(738, 240);
            this.or.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(19, 16);
            this.or.TabIndex = 10;
            this.or.Text = "or";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(635, 397);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(512, 400);
            this.Password.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 14;
            this.Password.Text = "Password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.Location = new System.Drawing.Point(512, 444);
            this.ConfirmPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(115, 16);
            this.ConfirmPassword.TabIndex = 16;
            this.ConfirmPassword.Text = "Confirm Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(635, 438);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(702, 487);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(75, 34);
            this.SignUp.TabIndex = 8;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Location = new System.Drawing.Point(876, 397);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(125, 20);
            this.showPass.TabIndex = 6;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            this.showPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.showPass_KeyDown);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(633, 308);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(213, 22);
            this.textBoxInput.TabIndex = 4;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textInput_KeyDown);
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.or);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.FirstNameCreateAc);
            this.Controls.Add(this.textBoxCreateAc2);
            this.Controls.Add(this.CreateAcName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCreateAc1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "BeautyBuzz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCreateAc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CreateAcName;
        private System.Windows.Forms.Label FirstNameCreateAc;
        private System.Windows.Forms.TextBox textBoxCreateAc2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label or;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label2;
    }
}

