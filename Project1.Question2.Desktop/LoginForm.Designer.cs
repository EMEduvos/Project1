namespace Project1.Question2.Desktop
{
  partial class LoginForm
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
      pictureBox1 = new PictureBox();
      label1 = new Label();
      label2 = new Label();
      txtUsername = new TextBox();
      txtPassword = new TextBox();
      btnLogin = new Button();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // pictureBox1
      // 
      pictureBox1.Image = Properties.Resources.Filled_Ranged_Colour_4x;
      pictureBox1.Location = new Point(136, 12);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(549, 182);
      pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      pictureBox1.TabIndex = 0;
      pictureBox1.TabStop = false;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(136, 254);
      label1.Name = "label1";
      label1.Size = new Size(75, 20);
      label1.TabIndex = 1;
      label1.Text = "Username";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(136, 309);
      label2.Name = "label2";
      label2.Size = new Size(70, 20);
      label2.TabIndex = 2;
      label2.Text = "Password";
      // 
      // txtUsername
      // 
      txtUsername.Location = new Point(217, 251);
      txtUsername.Name = "txtUsername";
      txtUsername.Size = new Size(377, 27);
      txtUsername.TabIndex = 3;
      txtUsername.Validating += Username_Validating;
      // 
      // txtPassword
      // 
      txtPassword.Location = new Point(217, 306);
      txtPassword.Name = "txtPassword";
      txtPassword.Size = new Size(377, 27);
      txtPassword.TabIndex = 4;
      txtPassword.Validating += TxtPassword_Validating;
      // 
      // btnLogin
      // 
      btnLogin.Enabled = false;
      btnLogin.Image = Properties.Resources.o365;
      btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
      btnLogin.Location = new Point(320, 355);
      btnLogin.Name = "btnLogin";
      btnLogin.Size = new Size(166, 51);
      btnLogin.TabIndex = 5;
      btnLogin.Text = "OpenID Connect";
      btnLogin.TextAlign = ContentAlignment.MiddleRight;
      btnLogin.UseVisualStyleBackColor = true;
      btnLogin.Click += btnLogin_Click;
      // 
      // LoginForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(btnLogin);
      Controls.Add(txtPassword);
      Controls.Add(txtUsername);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(pictureBox1);
      Name = "LoginForm";
      Text = "Login";
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private PictureBox pictureBox1;
    private Label label1;
    private Label label2;
    private TextBox txtUsername;
    private TextBox txtPassword;
    private Button btnLogin;
  }
}