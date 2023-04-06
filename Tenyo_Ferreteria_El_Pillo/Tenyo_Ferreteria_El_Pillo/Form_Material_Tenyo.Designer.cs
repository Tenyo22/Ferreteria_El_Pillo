
namespace Tenyo_Ferreteria_El_Pillo
{
    partial class Form_Material_Tenyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Material_Tenyo));
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblDescripcionMaterial = new System.Windows.Forms.Label();
            this.txtDescripcionMaterial = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridViewMaterial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Algerian", 20.25F);
            this.lblMaterial.Location = new System.Drawing.Point(249, 16);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(146, 30);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Material";
            // 
            // lblDescripcionMaterial
            // 
            this.lblDescripcionMaterial.AutoSize = true;
            this.lblDescripcionMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDescripcionMaterial.Location = new System.Drawing.Point(28, 63);
            this.lblDescripcionMaterial.Name = "lblDescripcionMaterial";
            this.lblDescripcionMaterial.Size = new System.Drawing.Size(163, 17);
            this.lblDescripcionMaterial.TabIndex = 1;
            this.lblDescripcionMaterial.Text = "Descripción del Material:";
            // 
            // txtDescripcionMaterial
            // 
            this.txtDescripcionMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionMaterial.Location = new System.Drawing.Point(192, 63);
            this.txtDescripcionMaterial.MaxLength = 150;
            this.txtDescripcionMaterial.Name = "txtDescripcionMaterial";
            this.txtDescripcionMaterial.Size = new System.Drawing.Size(313, 20);
            this.txtDescripcionMaterial.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(508, 45);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 57);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridViewMaterial
            // 
            this.dataGridViewMaterial.AllowUserToAddRows = false;
            this.dataGridViewMaterial.AllowUserToDeleteRows = false;
            this.dataGridViewMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterial.Location = new System.Drawing.Point(31, 107);
            this.dataGridViewMaterial.Name = "dataGridViewMaterial";
            this.dataGridViewMaterial.Size = new System.Drawing.Size(568, 174);
            this.dataGridViewMaterial.TabIndex = 4;
            // 
            // Form_Material_Tenyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(646, 305);
            this.Controls.Add(this.dataGridViewMaterial);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescripcionMaterial);
            this.Controls.Add(this.lblDescripcionMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Material_Tenyo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MATERIAL";
            this.Load += new System.EventHandler(this.Form_Material_Tenyo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblDescripcionMaterial;
        private System.Windows.Forms.TextBox txtDescripcionMaterial;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridViewMaterial;
    }
}