namespace capaPresentacion
{
    partial class frEdificios
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
            this.txtEdificio = new System.Windows.Forms.TextBox();
            this.lblEdificio = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvTableEdificio = new System.Windows.Forms.DataGridView();
            this.btnGuardarEdificio = new System.Windows.Forms.Button();
            this.btnEliminarEdificio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableEdificio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEdificio
            // 
            this.txtEdificio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdificio.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEdificio.Location = new System.Drawing.Point(246, 39);
            this.txtEdificio.Name = "txtEdificio";
            this.txtEdificio.Size = new System.Drawing.Size(236, 30);
            this.txtEdificio.TabIndex = 21;
            // 
            // lblEdificio
            // 
            this.lblEdificio.AutoSize = true;
            this.lblEdificio.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdificio.ForeColor = System.Drawing.Color.White;
            this.lblEdificio.Location = new System.Drawing.Point(140, 43);
            this.lblEdificio.Name = "lblEdificio";
            this.lblEdificio.Size = new System.Drawing.Size(100, 22);
            this.lblEdificio.TabIndex = 20;
            this.lblEdificio.Text = "Edificio:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(220, 22);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Administrar Edificios";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(58, 39);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(63, 30);
            this.txtId.TabIndex = 23;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(12, 43);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 22);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "Id:";
            // 
            // dgvTableEdificio
            // 
            this.dgvTableEdificio.AllowUserToAddRows = false;
            this.dgvTableEdificio.AllowUserToDeleteRows = false;
            this.dgvTableEdificio.AllowUserToResizeColumns = false;
            this.dgvTableEdificio.AllowUserToResizeRows = false;
            this.dgvTableEdificio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTableEdificio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableEdificio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTableEdificio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTableEdificio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTableEdificio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableEdificio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTableEdificio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.dgvTableEdificio.Location = new System.Drawing.Point(7, 75);
            this.dgvTableEdificio.Name = "dgvTableEdificio";
            this.dgvTableEdificio.ReadOnly = true;
            this.dgvTableEdificio.RowHeadersVisible = false;
            this.dgvTableEdificio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTableEdificio.RowTemplate.Height = 25;
            this.dgvTableEdificio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableEdificio.ShowCellToolTips = false;
            this.dgvTableEdificio.Size = new System.Drawing.Size(479, 283);
            this.dgvTableEdificio.TabIndex = 31;
            this.dgvTableEdificio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableEdificio_CellClick);
            // 
            // btnGuardarEdificio
            // 
            this.btnGuardarEdificio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarEdificio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.btnGuardarEdificio.FlatAppearance.BorderSize = 0;
            this.btnGuardarEdificio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEdificio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarEdificio.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEdificio.Location = new System.Drawing.Point(7, 364);
            this.btnGuardarEdificio.Name = "btnGuardarEdificio";
            this.btnGuardarEdificio.Size = new System.Drawing.Size(236, 28);
            this.btnGuardarEdificio.TabIndex = 32;
            this.btnGuardarEdificio.Text = "Guardar";
            this.btnGuardarEdificio.UseVisualStyleBackColor = false;
            this.btnGuardarEdificio.Click += new System.EventHandler(this.btnGuardarEdificio_Click);
            // 
            // btnEliminarEdificio
            // 
            this.btnEliminarEdificio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarEdificio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.btnEliminarEdificio.FlatAppearance.BorderSize = 0;
            this.btnEliminarEdificio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEdificio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarEdificio.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEdificio.Location = new System.Drawing.Point(250, 364);
            this.btnEliminarEdificio.Name = "btnEliminarEdificio";
            this.btnEliminarEdificio.Size = new System.Drawing.Size(236, 28);
            this.btnEliminarEdificio.TabIndex = 33;
            this.btnEliminarEdificio.Text = "Eliminar";
            this.btnEliminarEdificio.UseVisualStyleBackColor = false;
            this.btnEliminarEdificio.Click += new System.EventHandler(this.btnEliminarEdificio_Click);
            // 
            // frEdificios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(494, 422);
            this.Controls.Add(this.btnEliminarEdificio);
            this.Controls.Add(this.btnGuardarEdificio);
            this.Controls.Add(this.dgvTableEdificio);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtEdificio);
            this.Controls.Add(this.lblEdificio);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(494, 422);
            this.Name = "frEdificios";
            this.Text = "Administrar Edificios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableEdificio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEdificio;
        private Label lblEdificio;
        private Label lblTitulo;
        private TextBox txtId;
        private Label lblId;
        private DataGridView dgvTableEdificio;
        private Button btnGuardarEdificio;
        private Button btnEliminarEdificio;
    }
}