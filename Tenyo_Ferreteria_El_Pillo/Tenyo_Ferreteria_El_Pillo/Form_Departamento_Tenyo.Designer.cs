
namespace Tenyo_Ferreteria_El_Pillo
{
    partial class Form_Departamento_Tenyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Departamento_Tenyo));
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblNombreDepartamento = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridViewDepartamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(181, 9);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(221, 30);
            this.lblDepartamento.TabIndex = 0;
            this.lblDepartamento.Text = "DEPARTAMENTO";
            // 
            // lblNombreDepartamento
            // 
            this.lblNombreDepartamento.AutoSize = true;
            this.lblNombreDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNombreDepartamento.Location = new System.Drawing.Point(8, 58);
            this.lblNombreDepartamento.Name = "lblNombreDepartamento";
            this.lblNombreDepartamento.Size = new System.Drawing.Size(207, 20);
            this.lblNombreDepartamento.TabIndex = 1;
            this.lblNombreDepartamento.Text = "Nombre de Departamento:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepartamento.Location = new System.Drawing.Point(216, 59);
            this.txtDepartamento.MaxLength = 100;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(258, 20);
            this.txtDepartamento.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(480, 41);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 51);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridViewDepartamento
            // 
            this.dataGridViewDepartamento.AllowUserToAddRows = false;
            this.dataGridViewDepartamento.AllowUserToDeleteRows = false;
            this.dataGridViewDepartamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartamento.Location = new System.Drawing.Point(12, 104);
            this.dataGridViewDepartamento.Name = "dataGridViewDepartamento";
            this.dataGridViewDepartamento.Size = new System.Drawing.Size(563, 138);
            this.dataGridViewDepartamento.TabIndex = 4;
            // 
            // Form_Departamento_Tenyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(621, 269);
            this.Controls.Add(this.dataGridViewDepartamento);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.lblNombreDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Departamento_Tenyo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPARTAMENTO";
            this.Load += new System.EventHandler(this.Form_Departamento_Tenyo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblNombreDepartamento;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridViewDepartamento;
    }
}