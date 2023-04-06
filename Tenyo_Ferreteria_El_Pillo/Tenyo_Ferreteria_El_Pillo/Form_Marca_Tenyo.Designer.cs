
namespace Tenyo_Ferreteria_El_Pillo
{
    partial class Form_Marca_Tenyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Marca_Tenyo));
            this.lblMarcas = new System.Windows.Forms.Label();
            this.lblNombreMarca = new System.Windows.Forms.Label();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridViewMarca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Algerian", 20.25F);
            this.lblMarcas.Location = new System.Drawing.Point(263, 18);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(121, 30);
            this.lblMarcas.TabIndex = 0;
            this.lblMarcas.Text = "Marcas";
            // 
            // lblNombreMarca
            // 
            this.lblNombreMarca.AutoSize = true;
            this.lblNombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNombreMarca.Location = new System.Drawing.Point(23, 66);
            this.lblNombreMarca.Name = "lblNombreMarca";
            this.lblNombreMarca.Size = new System.Drawing.Size(140, 17);
            this.lblNombreMarca.TabIndex = 1;
            this.lblNombreMarca.Text = "Nombre de la Marca:";
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreMarca.Location = new System.Drawing.Point(162, 66);
            this.txtNombreMarca.MaxLength = 70;
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(312, 20);
            this.txtNombreMarca.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(487, 50);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 51);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridViewMarca
            // 
            this.dataGridViewMarca.AllowUserToAddRows = false;
            this.dataGridViewMarca.AllowUserToDeleteRows = false;
            this.dataGridViewMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarca.Location = new System.Drawing.Point(26, 107);
            this.dataGridViewMarca.Name = "dataGridViewMarca";
            this.dataGridViewMarca.Size = new System.Drawing.Size(554, 167);
            this.dataGridViewMarca.TabIndex = 4;
            // 
            // Form_Marca_Tenyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(626, 302);
            this.Controls.Add(this.dataGridViewMarca);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreMarca);
            this.Controls.Add(this.lblNombreMarca);
            this.Controls.Add(this.lblMarcas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Marca_Tenyo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MARCA";
            this.Load += new System.EventHandler(this.Form_Marca_Tenyo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Label lblNombreMarca;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridViewMarca;
    }
}