namespace ejemplo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechadeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbChocolate = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rdbSquibs = new System.Windows.Forms.RadioButton();
            this.rdbMuggle = new System.Windows.Forms.RadioButton();
            this.rdbWilzard = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.lblColorFavorito = new System.Windows.Forms.Label();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(154, 550);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(154, 419);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(245, 125);
            this.lwElementos.TabIndex = 2;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(104, 69);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(55, 115);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha Nacimiento";
            // 
            // dtpFechadeNacimiento
            // 
            this.dtpFechadeNacimiento.Location = new System.Drawing.Point(154, 109);
            this.dtpFechadeNacimiento.Name = "dtpFechadeNacimiento";
            this.dtpFechadeNacimiento.Size = new System.Drawing.Size(230, 20);
            this.dtpFechadeNacimiento.TabIndex = 5;
            // 
            // cbChocolate
            // 
            this.cbChocolate.AutoSize = true;
            this.cbChocolate.Location = new System.Drawing.Point(154, 147);
            this.cbChocolate.Name = "cbChocolate";
            this.cbChocolate.Size = new System.Drawing.Size(138, 17);
            this.cbChocolate.TabIndex = 6;
            this.cbChocolate.Text = "Te gusta el chocolate? ";
            this.cbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(104, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 31);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Perfil Persona";
            // 
            // rdbSquibs
            // 
            this.rdbSquibs.AutoSize = true;
            this.rdbSquibs.Location = new System.Drawing.Point(308, 19);
            this.rdbSquibs.Name = "rdbSquibs";
            this.rdbSquibs.Size = new System.Drawing.Size(57, 17);
            this.rdbSquibs.TabIndex = 9;
            this.rdbSquibs.Text = "Squibs";
            this.rdbSquibs.UseVisualStyleBackColor = true;
            // 
            // rdbMuggle
            // 
            this.rdbMuggle.AutoSize = true;
            this.rdbMuggle.Location = new System.Drawing.Point(199, 19);
            this.rdbMuggle.Name = "rdbMuggle";
            this.rdbMuggle.Size = new System.Drawing.Size(60, 17);
            this.rdbMuggle.TabIndex = 10;
            this.rdbMuggle.Text = "Muggle";
            this.rdbMuggle.UseVisualStyleBackColor = true;
            // 
            // rdbWilzard
            // 
            this.rdbWilzard.AutoSize = true;
            this.rdbWilzard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbWilzard.Checked = true;
            this.rdbWilzard.Location = new System.Drawing.Point(81, 19);
            this.rdbWilzard.Name = "rdbWilzard";
            this.rdbWilzard.Size = new System.Drawing.Size(60, 17);
            this.rdbWilzard.TabIndex = 11;
            this.rdbWilzard.TabStop = true;
            this.rdbWilzard.Text = "Wilzard";
            this.rdbWilzard.UseVisualStyleBackColor = false;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.rdbSquibs);
            this.gbxTipo.Controls.Add(this.rdbWilzard);
            this.gbxTipo.Controls.Add(this.rdbMuggle);
            this.gbxTipo.Location = new System.Drawing.Point(58, 182);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(399, 41);
            this.gbxTipo.TabIndex = 12;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(155, 256);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(245, 21);
            this.cmbColor.TabIndex = 13;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // lblColorFavorito
            // 
            this.lblColorFavorito.AutoSize = true;
            this.lblColorFavorito.Location = new System.Drawing.Point(76, 256);
            this.lblColorFavorito.Name = "lblColorFavorito";
            this.lblColorFavorito.Size = new System.Drawing.Size(72, 13);
            this.lblColorFavorito.TabIndex = 14;
            this.lblColorFavorito.Text = "Color Favorito";
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(155, 283);
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(120, 20);
            this.numUpDown.TabIndex = 15;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(63, 290);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(85, 13);
            this.lblNumero.TabIndex = 16;
            this.lblNumero.Text = "Numero Favorito";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(73, 338);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnVerPerfil.TabIndex = 17;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 634);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.lblColorFavorito);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbChocolate);
            this.Controls.Add(this.dtpFechadeNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechadeNacimiento;
        private System.Windows.Forms.CheckBox cbChocolate;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rdbSquibs;
        private System.Windows.Forms.RadioButton rdbMuggle;
        private System.Windows.Forms.RadioButton rdbWilzard;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lblColorFavorito;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

