namespace capaPresentacion
{
    partial class frVisitas
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
            this.btnAgregarFoto = new System.Windows.Forms.Button();
            this.pbUserPhoto = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblEdificio = new System.Windows.Forms.Label();
            this.cbEdificio = new System.Windows.Forms.ComboBox();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.cbMotivoVisita = new System.Windows.Forms.ComboBox();
            this.lblAula = new System.Windows.Forms.Label();
            this.cbAula = new System.Windows.Forms.ComboBox();
            this.lblMotivoVisita = new System.Windows.Forms.Label();
            this.btnGuardarVisita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.btnAgregarFoto.FlatAppearance.BorderSize = 0;
            this.btnAgregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFoto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarFoto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarFoto.Location = new System.Drawing.Point(12, 181);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(129, 28);
            this.btnAgregarFoto.TabIndex = 5;
            this.btnAgregarFoto.Text = "Añadir....";
            this.btnAgregarFoto.UseVisualStyleBackColor = false;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            // 
            // pbUserPhoto
            // 
            this.pbUserPhoto.Location = new System.Drawing.Point(12, 53);
            this.pbUserPhoto.Name = "pbUserPhoto";
            this.pbUserPhoto.Size = new System.Drawing.Size(129, 122);
            this.pbUserPhoto.TabIndex = 4;
            this.pbUserPhoto.TabStop = false;
            this.pbUserPhoto.Tag = "No";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 22);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Registrar Visitas";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(161, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 22);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(262, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(225, 30);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(262, 105);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(225, 30);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(161, 109);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 22);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.Location = new System.Drawing.Point(262, 141);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(225, 30);
            this.txtCorreo.TabIndex = 11;
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(161, 145);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(80, 22);
            this.lblCorreo.TabIndex = 10;
            this.lblCorreo.Text = "Correo:";
            // 
            // cbCarrera
            // 
            this.cbCarrera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarrera.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Location = new System.Drawing.Point(262, 177);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(225, 30);
            this.cbCarrera.TabIndex = 13;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCarrera.ForeColor = System.Drawing.Color.White;
            this.lblCarrera.Location = new System.Drawing.Point(161, 181);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(90, 22);
            this.lblCarrera.TabIndex = 14;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblEdificio
            // 
            this.lblEdificio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdificio.AutoSize = true;
            this.lblEdificio.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdificio.ForeColor = System.Drawing.Color.White;
            this.lblEdificio.Location = new System.Drawing.Point(290, 217);
            this.lblEdificio.Name = "lblEdificio";
            this.lblEdificio.Size = new System.Drawing.Size(100, 22);
            this.lblEdificio.TabIndex = 16;
            this.lblEdificio.Text = "Edificio:";
            // 
            // cbEdificio
            // 
            this.cbEdificio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEdificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdificio.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEdificio.FormattingEnabled = true;
            this.cbEdificio.Location = new System.Drawing.Point(396, 213);
            this.cbEdificio.Name = "cbEdificio";
            this.cbEdificio.Size = new System.Drawing.Size(91, 30);
            this.cbEdificio.TabIndex = 15;
            this.cbEdificio.SelectedIndexChanged += new System.EventHandler(this.cbEdificio_SelectedIndexChanged);
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.CalendarFont = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(188, 217);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.ShowUpDown = true;
            this.dtpHoraEntrada.Size = new System.Drawing.Size(96, 23);
            this.dtpHoraEntrada.TabIndex = 17;
            this.dtpHoraEntrada.Value = new System.DateTime(2022, 12, 9, 16, 17, 0, 0);
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraEntrada.ForeColor = System.Drawing.Color.White;
            this.lblHoraEntrada.Location = new System.Drawing.Point(12, 218);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(170, 22);
            this.lblHoraEntrada.TabIndex = 18;
            this.lblHoraEntrada.Text = "Hora de Entrada:";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraSalida.ForeColor = System.Drawing.Color.White;
            this.lblHoraSalida.Location = new System.Drawing.Point(12, 250);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(160, 22);
            this.lblHoraSalida.TabIndex = 20;
            this.lblHoraSalida.Text = "Hora de Salida:";
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.CalendarFont = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalida.Location = new System.Drawing.Point(188, 249);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.ShowUpDown = true;
            this.dtpHoraSalida.Size = new System.Drawing.Size(96, 23);
            this.dtpHoraSalida.TabIndex = 19;
            this.dtpHoraSalida.Value = new System.DateTime(2022, 12, 9, 16, 17, 0, 0);
            // 
            // cbMotivoVisita
            // 
            this.cbMotivoVisita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMotivoVisita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotivoVisita.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMotivoVisita.FormattingEnabled = true;
            this.cbMotivoVisita.Location = new System.Drawing.Point(222, 282);
            this.cbMotivoVisita.Name = "cbMotivoVisita";
            this.cbMotivoVisita.Size = new System.Drawing.Size(265, 30);
            this.cbMotivoVisita.TabIndex = 22;
            // 
            // lblAula
            // 
            this.lblAula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAula.AutoSize = true;
            this.lblAula.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAula.ForeColor = System.Drawing.Color.White;
            this.lblAula.Location = new System.Drawing.Point(290, 251);
            this.lblAula.Name = "lblAula";
            this.lblAula.Size = new System.Drawing.Size(60, 22);
            this.lblAula.TabIndex = 24;
            this.lblAula.Text = "Aula:";
            // 
            // cbAula
            // 
            this.cbAula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAula.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAula.FormattingEnabled = true;
            this.cbAula.Location = new System.Drawing.Point(396, 247);
            this.cbAula.Name = "cbAula";
            this.cbAula.Size = new System.Drawing.Size(91, 30);
            this.cbAula.TabIndex = 25;
            // 
            // lblMotivoVisita
            // 
            this.lblMotivoVisita.AutoSize = true;
            this.lblMotivoVisita.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMotivoVisita.ForeColor = System.Drawing.Color.White;
            this.lblMotivoVisita.Location = new System.Drawing.Point(12, 286);
            this.lblMotivoVisita.Name = "lblMotivoVisita";
            this.lblMotivoVisita.Size = new System.Drawing.Size(210, 22);
            this.lblMotivoVisita.TabIndex = 26;
            this.lblMotivoVisita.Text = "Motivo de la Visita:";
            // 
            // btnGuardarVisita
            // 
            this.btnGuardarVisita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarVisita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.btnGuardarVisita.FlatAppearance.BorderSize = 0;
            this.btnGuardarVisita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarVisita.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarVisita.ForeColor = System.Drawing.Color.White;
            this.btnGuardarVisita.Location = new System.Drawing.Point(12, 318);
            this.btnGuardarVisita.Name = "btnGuardarVisita";
            this.btnGuardarVisita.Size = new System.Drawing.Size(475, 28);
            this.btnGuardarVisita.TabIndex = 27;
            this.btnGuardarVisita.Text = "Guardar Visita";
            this.btnGuardarVisita.UseVisualStyleBackColor = false;
            this.btnGuardarVisita.Click += new System.EventHandler(this.btnGuardarVisita_Click);
            // 
            // frVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(494, 422);
            this.Controls.Add(this.btnGuardarVisita);
            this.Controls.Add(this.lblMotivoVisita);
            this.Controls.Add(this.cbAula);
            this.Controls.Add(this.lblAula);
            this.Controls.Add(this.cbMotivoVisita);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.lblEdificio);
            this.Controls.Add(this.cbEdificio);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.cbCarrera);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregarFoto);
            this.Controls.Add(this.pbUserPhoto);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(494, 422);
            this.Name = "frVisitas";
            this.Text = "Registrar Visitas";
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregarFoto;
        private PictureBox pbUserPhoto;
        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private ComboBox cbCarrera;
        private Label lblCarrera;
        private Label lblEdificio;
        private ComboBox cbEdificio;
        private DateTimePicker dtpHoraEntrada;
        private Label lblHoraEntrada;
        private Label lblHoraSalida;
        private DateTimePicker dtpHoraSalida;
        private ComboBox cbMotivoVisita;
        private Label lblAula;
        private ComboBox cbAula;
        private Label lblMotivoVisita;
        private Button btnGuardarVisita;
    }
}