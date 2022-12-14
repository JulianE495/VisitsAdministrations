namespace capaPresentacion
{
    partial class frMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.pnLeftMenu = new System.Windows.Forms.Panel();
            this.btnConsultarVisitas = new System.Windows.Forms.Button();
            this.btnVisitas = new System.Windows.Forms.Button();
            this.pnTopMenu = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnLeftMenu.SuspendLayout();
            this.pnTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeftMenu
            // 
            this.pnLeftMenu.Controls.Add(this.btnConsultarVisitas);
            this.pnLeftMenu.Controls.Add(this.btnVisitas);
            this.pnLeftMenu.Controls.Add(this.pnTopMenu);
            this.pnLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.pnLeftMenu.Name = "pnLeftMenu";
            this.pnLeftMenu.Size = new System.Drawing.Size(204, 461);
            this.pnLeftMenu.TabIndex = 0;
            // 
            // btnConsultarVisitas
            // 
            this.btnConsultarVisitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.btnConsultarVisitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarVisitas.FlatAppearance.BorderSize = 0;
            this.btnConsultarVisitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarVisitas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarVisitas.ForeColor = System.Drawing.Color.White;
            this.btnConsultarVisitas.Image = global::capaPresentacion.Properties.Resources.icons8_visit_24px;
            this.btnConsultarVisitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarVisitas.Location = new System.Drawing.Point(0, 134);
            this.btnConsultarVisitas.Name = "btnConsultarVisitas";
            this.btnConsultarVisitas.Size = new System.Drawing.Size(204, 43);
            this.btnConsultarVisitas.TabIndex = 2;
            this.btnConsultarVisitas.Text = "Consultar Visitas";
            this.btnConsultarVisitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarVisitas.UseVisualStyleBackColor = false;
            this.btnConsultarVisitas.Click += new System.EventHandler(this.btnConsultarVisitas_Click);
            // 
            // btnVisitas
            // 
            this.btnVisitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.btnVisitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisitas.FlatAppearance.BorderSize = 0;
            this.btnVisitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisitas.ForeColor = System.Drawing.Color.White;
            this.btnVisitas.Image = ((System.Drawing.Image)(resources.GetObject("btnVisitas.Image")));
            this.btnVisitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisitas.Location = new System.Drawing.Point(0, 91);
            this.btnVisitas.Name = "btnVisitas";
            this.btnVisitas.Size = new System.Drawing.Size(204, 43);
            this.btnVisitas.TabIndex = 1;
            this.btnVisitas.Text = "Visitas";
            this.btnVisitas.UseVisualStyleBackColor = false;
            this.btnVisitas.Click += new System.EventHandler(this.btnVisitas_Click);
            // 
            // pnTopMenu
            // 
            this.pnTopMenu.Controls.Add(this.lblRol);
            this.pnTopMenu.Controls.Add(this.lblUser);
            this.pnTopMenu.Controls.Add(this.pbProfile);
            this.pnTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnTopMenu.Name = "pnTopMenu";
            this.pnTopMenu.Size = new System.Drawing.Size(204, 91);
            this.pnTopMenu.TabIndex = 0;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(87, 49);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(32, 18);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(87, 23);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 18);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuario";
            // 
            // pbProfile
            // 
            this.pbProfile.Location = new System.Drawing.Point(12, 12);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(72, 67);
            this.pbProfile.TabIndex = 0;
            this.pbProfile.TabStop = false;
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(204, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(510, 461);
            this.pnMain.TabIndex = 1;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(714, 461);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnLeftMenu);
            this.MinimumSize = new System.Drawing.Size(730, 500);
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visit Administrator | Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnLeftMenu.ResumeLayout(false);
            this.pnTopMenu.ResumeLayout(false);
            this.pnTopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnLeftMenu;
        private Panel pnTopMenu;
        private Label lblRol;
        private Label lblUser;
        private PictureBox pbProfile;
        private Button btnVisitas;
        private Button btnConsultarVisitas;
        private Panel pnMain;
    }
}