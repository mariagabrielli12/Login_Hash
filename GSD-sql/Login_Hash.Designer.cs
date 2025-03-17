namespace GSD_sql
{
    partial class Login_Hash
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
            label1 = new Label();
            label2 = new Label();
            txtUsuarioLogin = new TextBox();
            txtSenhaLogin = new TextBox();
            btnLogin = new Button();
            tabControl1 = new TabControl();
            login = new TabPage();
            tabPage2 = new TabPage();
            txtEmail = new TextBox();
            txtConfirmarSenha = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnRegistrar = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            login.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 92);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(86, 21);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(100, 23);
            txtUsuarioLogin.TabIndex = 2;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(86, 84);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(100, 23);
            txtSenhaLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(111, 141);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(login);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(786, 454);
            tabControl1.TabIndex = 5;
            // 
            // login
            // 
            login.Controls.Add(txtSenhaLogin);
            login.Controls.Add(txtUsuarioLogin);
            login.Controls.Add(btnLogin);
            login.Controls.Add(label2);
            login.Controls.Add(label1);
            login.Location = new Point(4, 24);
            login.Name = "login";
            login.Padding = new Padding(3);
            login.Size = new Size(778, 426);
            login.TabIndex = 0;
            login.Text = "login";
            login.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtEmail);
            tabPage2.Controls.Add(txtConfirmarSenha);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(btnRegistrar);
            tabPage2.Controls.Add(txtSenha);
            tabPage2.Controls.Add(txtUsuario);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(778, 426);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "registro";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(320, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(320, 167);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(100, 23);
            txtConfirmarSenha.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 164);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 6;
            label6.Text = "Confirmar senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 225);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 5;
            label5.Text = "email";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(241, 304);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registro";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(319, 107);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(320, 45);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 107);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 1;
            label4.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 57);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuário";
            // 
            // Login_Hash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Login_Hash";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            login.ResumeLayout(false);
            login.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuarioLogin;
        private TextBox txtSenhaLogin;
        private Button btnLogin;
        private TabControl tabControl1;
        private TabPage login;
        private TabPage tabPage2;
        private Label label4;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtConfirmarSenha;
        private Label label6;
        private Label label5;
        private Button btnRegistrar;
        private TextBox txtSenha;
        private TextBox txtUsuario;
    }
}
