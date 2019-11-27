namespace miramar_cheers_1.formularios
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btninicio = new System.Windows.Forms.PictureBox();
            this.Panel_Login = new System.Windows.Forms.Panel();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Senha = new System.Windows.Forms.Button();
            this.Btn_Entrar = new System.Windows.Forms.Button();
            this.panel_Senha = new System.Windows.Forms.Panel();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).BeginInit();
            this.Panel_Login.SuspendLayout();
            this.panel_Senha.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(716, 39);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(647, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(678, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.btninicio);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 39);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 247);
            this.MenuVertical.TabIndex = 1;
            // 
            // btninicio
            // 
            this.btninicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninicio.Image = global::miramar_cheers_1.Properties.Resources.logo_tipo;
            this.btninicio.Location = new System.Drawing.Point(0, 0);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(220, 102);
            this.btninicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btninicio.TabIndex = 0;
            this.btninicio.TabStop = false;
            // 
            // Panel_Login
            // 
            this.Panel_Login.Controls.Add(this.txt_login);
            this.Panel_Login.Location = new System.Drawing.Point(363, 107);
            this.Panel_Login.Name = "Panel_Login";
            this.Panel_Login.Size = new System.Drawing.Size(205, 27);
            this.Panel_Login.TabIndex = 15;
            this.Panel_Login.Visible = false;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(3, 3);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(202, 20);
            this.txt_login.TabIndex = 18;
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Login.FlatAppearance.BorderSize = 0;
            this.Btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Login.Location = new System.Drawing.Point(379, 72);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(170, 28);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Senha
            // 
            this.Btn_Senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Senha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Senha.FlatAppearance.BorderSize = 0;
            this.Btn_Senha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Senha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Senha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Senha.ForeColor = System.Drawing.Color.White;
            this.Btn_Senha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Senha.Location = new System.Drawing.Point(379, 140);
            this.Btn_Senha.Name = "Btn_Senha";
            this.Btn_Senha.Size = new System.Drawing.Size(170, 28);
            this.Btn_Senha.TabIndex = 1;
            this.Btn_Senha.Text = "Senha";
            this.Btn_Senha.UseVisualStyleBackColor = false;
            this.Btn_Senha.Click += new System.EventHandler(this.Btn_Senha_Click);
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Entrar.FlatAppearance.BorderSize = 0;
            this.Btn_Entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Entrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Entrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Entrar.Location = new System.Drawing.Point(379, 217);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(170, 28);
            this.Btn_Entrar.TabIndex = 7;
            this.Btn_Entrar.Text = "Entrar";
            this.Btn_Entrar.UseVisualStyleBackColor = false;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // panel_Senha
            // 
            this.panel_Senha.Controls.Add(this.txt_senha);
            this.panel_Senha.Location = new System.Drawing.Point(363, 174);
            this.panel_Senha.Name = "panel_Senha";
            this.panel_Senha.Size = new System.Drawing.Size(205, 27);
            this.panel_Senha.TabIndex = 18;
            this.panel_Senha.Visible = false;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(3, 3);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(202, 20);
            this.txt_senha.TabIndex = 19;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(716, 286);
            this.Controls.Add(this.panel_Senha);
            this.Controls.Add(this.Panel_Login);
            this.Controls.Add(this.Btn_Entrar);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Btn_Senha);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).EndInit();
            this.Panel_Login.ResumeLayout(false);
            this.Panel_Login.PerformLayout();
            this.panel_Senha.ResumeLayout(false);
            this.panel_Senha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Button Btn_Senha;
        private System.Windows.Forms.PictureBox btninicio;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Panel Panel_Login;
        private System.Windows.Forms.Button Btn_Entrar;
        private System.Windows.Forms.Panel panel_Senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_senha;
    }
}

