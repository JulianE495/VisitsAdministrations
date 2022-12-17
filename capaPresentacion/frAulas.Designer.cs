namespace capaPresentacion
{
    partial class frAulas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminarAula = new System.Windows.Forms.Button();
            this.btnGuardarAula = new System.Windows.Forms.Button();
            this.dgvTableAula = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.lblEdificio = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEdificios = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarAula
            // 
            this.btnEliminarAula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.btnEliminarAula.FlatAppearance.BorderSize = 0;
            this.btnEliminarAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAula.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarAula.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAula.Location = new System.Drawing.Point(250, 364);
            this.btnEliminarAula.Name = "btnEliminarAula";
            this.btnEliminarAula.Size = new System.Drawing.Size(236, 28);
            this.btnEliminarAula.TabIndex = 41;
            this.btnEliminarAula.Text = "Eliminar";
            this.btnEliminarAula.UseVisualStyleBackColor = false;
            this.btnEliminarAula.Click += new System.EventHandler(this.btnEliminarAula_Click);
            // 
            // btnGuardarAula
            // 
            this.btnGuardarAula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.btnGuardarAula.FlatAppearance.BorderSize = 0;
            this.btnGuardarAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAula.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarAula.ForeColor = System.Drawing.Color.White;
            this.btnGuardarAula.Location = new System.Drawing.Point(7, 364);
            this.btnGuardarAula.Name = "btnGuardarAula";
            this.btnGuardarAula.Size = new System.Drawing.Size(236, 28);
            this.btnGuardarAula.TabIndex = 40;
            this.btnGuardarAula.Text = "Guardar";
            this.btnGuardarAula.UseVisualStyleBackColor = false;
            this.btnGuardarAula.Click += new System.EventHandler(this.btnGuardarAula_Click);
            // 
            // dgvTableAula
            // 
            this.dgvTableAula.AllowUserToAddRows = false;
            this.dgvTableAula.AllowUserToDeleteRows = false;
            this.dgvTableAula.AllowUserToResizeColumns = false;
            this.dgvTableAula.AllowUserToResizeRows = false;
            this.dgvTableAula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTableAula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableAula.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTableAula.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableAula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTableAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableAula.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTableAula.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.dgvTableAula.Location = new System.Drawing.Point(7, 75);
            this.dgvTableAula.Name = "dgvTableAula";
            this.dgvTableAula.ReadOnly = true;
            this.dgvTableAula.RowHeadersVisible = false;
            this.dgvTableAula.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTableAula.RowTemplate.Height = 25;
            this.dgvTableAula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableAula.ShowCellToolTips = false;
            this.dgvTableAula.Size = new System.Drawing.Size(479, 283);
            this.dgvTableAula.TabIndex = 39;
            this.dgvTableAula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableAula_CellClick);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(58, 42);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(40, 30);
            this.txtId.TabIndex = 38;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(12, 46);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 22);
            this.lblId.TabIndex = 37;
            this.lblId.Text = "Id:";
            // 
            // txtAula
            // 
            this.txtAula.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAula.Location = new System.Drawing.Point(168, 42);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(123, 30);
            this.txtAula.TabIndex = 36;
            // 
            // lblEdificio
            // 
            this.lblEdificio.AutoSize = true;
            this.lblEdificio.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdificio.ForeColor = System.Drawing.Color.White;
            this.lblEdificio.Location = new System.Drawing.Point(102, 46);
            this.lblEdificio.Name = "lblEdificio";
            this.lblEdificio.Size = new System.Drawing.Size(60, 22);
            this.lblEdificio.TabIndex = 35;
            this.lblEdificio.Text = "Aula:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 22);
            this.lblTitulo.TabIndex = 34;
            this.lblTitulo.Text = "Administrar Aulas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Edificio:";
            // 
            // cbEdificios
            // 
            this.cbEdificios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEdificios.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEdificios.FormattingEnabled = true;
            this.cbEdificios.Location = new System.Drawing.Point(401, 42);
            this.cbEdificios.Name = "cbEdificios";
            this.cbEdificios.Size = new System.Drawing.Size(189, 30);
            this.cbEdificios.TabIndex = 43;
            // 
            // frAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(494, 422);
            this.Controls.Add(this.cbEdificios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarAula);
            this.Controls.Add(this.btnGuardarAula);
            this.Controls.Add(this.dgvTableAula);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.lblEdificio);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(494, 422);
            this.Name = "frAulas";
            this.Text = "Administrar Aulas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableAula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEliminarAula;
        private Button btnGuardarAula;
        private DataGridView dgvTableAula;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtAula;
        private Label lblEdificio;
        private Label lblTitulo;
        private Label label1;
        private ComboBox cbEdificios;
    }
}