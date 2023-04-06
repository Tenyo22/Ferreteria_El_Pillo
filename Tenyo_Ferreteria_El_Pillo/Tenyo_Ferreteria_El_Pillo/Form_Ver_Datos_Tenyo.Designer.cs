
namespace Tenyo_Ferreteria_El_Pillo
{
    partial class Form_Ver_Datos_Tenyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ver_Datos_Tenyo));
            this.lblConsultar = new System.Windows.Forms.Label();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.cmbOpcion = new System.Windows.Forms.ComboBox();
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Algerian", 20.25F);
            this.lblConsultar.Location = new System.Drawing.Point(610, 20);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(161, 30);
            this.lblConsultar.TabIndex = 0;
            this.lblConsultar.Text = "Consultar";
            // 
            // txtConsultar
            // 
            this.txtConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtConsultar.Location = new System.Drawing.Point(257, 85);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(491, 23);
            this.txtConsultar.TabIndex = 1;
            this.txtConsultar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConsultar_KeyUp);
            // 
            // cmbOpcion
            // 
            this.cmbOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbOpcion.FormattingEnabled = true;
            this.cmbOpcion.Items.AddRange(new object[] {
            "--Seleccione--",
            "Producto",
            "Medida",
            "Caracteristicas",
            "Proveedor",
            "Empleados"});
            this.cmbOpcion.Location = new System.Drawing.Point(809, 85);
            this.cmbOpcion.Name = "cmbOpcion";
            this.cmbOpcion.Size = new System.Drawing.Size(157, 24);
            this.cmbOpcion.TabIndex = 2;
            // 
            // dataGridViewDatos
            // 
            this.dataGridViewDatos.AllowUserToAddRows = false;
            this.dataGridViewDatos.AllowUserToDeleteRows = false;
            this.dataGridViewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatos.Location = new System.Drawing.Point(80, 129);
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.Size = new System.Drawing.Size(1133, 359);
            this.dataGridViewDatos.TabIndex = 3;
            // 
            // Form_Ver_Datos_Tenyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1276, 517);
            this.Controls.Add(this.dataGridViewDatos);
            this.Controls.Add(this.cmbOpcion);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.lblConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Ver_Datos_Tenyo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Ver_Datos_Tenyo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.ComboBox cmbOpcion;
        private System.Windows.Forms.DataGridView dataGridViewDatos;
    }
}