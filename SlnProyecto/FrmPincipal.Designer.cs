namespace SlnProyecto
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
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
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.btn_Go = new System.Windows.Forms.Button();
            this.lbl_Titulo_Registro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Registrar = new System.Windows.Forms.Label();
            this.btn_Cancelar_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(96, 100);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(220, 20);
            this.txt_Usuario.TabIndex = 0;
            // 
            // txt_Clave
            // 
            this.txt_Clave.Location = new System.Drawing.Point(96, 157);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(220, 20);
            this.txt_Clave.TabIndex = 1;
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(96, 210);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(75, 23);
            this.btn_Go.TabIndex = 2;
            this.btn_Go.Text = "Go";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // lbl_Titulo_Registro
            // 
            this.lbl_Titulo_Registro.AutoSize = true;
            this.lbl_Titulo_Registro.Location = new System.Drawing.Point(93, 261);
            this.lbl_Titulo_Registro.Name = "lbl_Titulo_Registro";
            this.lbl_Titulo_Registro.Size = new System.Drawing.Size(148, 13);
            this.lbl_Titulo_Registro.TabIndex = 3;
            this.lbl_Titulo_Registro.Text = "¿Quieres registrarte? Presiona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // lbl_Registrar
            // 
            this.lbl_Registrar.AutoSize = true;
            this.lbl_Registrar.Location = new System.Drawing.Point(277, 261);
            this.lbl_Registrar.Name = "lbl_Registrar";
            this.lbl_Registrar.Size = new System.Drawing.Size(30, 13);
            this.lbl_Registrar.TabIndex = 6;
            this.lbl_Registrar.Text = "Aquí";
            this.lbl_Registrar.Click += new System.EventHandler(this.lbl_Registrar_Click);
            // 
            // btn_Cancelar_Login
            // 
            this.btn_Cancelar_Login.Location = new System.Drawing.Point(96, 307);
            this.btn_Cancelar_Login.Name = "btn_Cancelar_Login";
            this.btn_Cancelar_Login.Size = new System.Drawing.Size(220, 23);
            this.btn_Cancelar_Login.TabIndex = 7;
            this.btn_Cancelar_Login.Text = "Cancelar Login";
            this.btn_Cancelar_Login.UseVisualStyleBackColor = true;
            this.btn_Cancelar_Login.Click += new System.EventHandler(this.btn_Cancelar_Login_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 374);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cancelar_Login);
            this.Controls.Add(this.lbl_Registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Titulo_Registro);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.txt_Clave);
            this.Controls.Add(this.txt_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.Text = "TaknaJam";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.Label lbl_Titulo_Registro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Registrar;
        private System.Windows.Forms.Button btn_Cancelar_Login;

    }
}

