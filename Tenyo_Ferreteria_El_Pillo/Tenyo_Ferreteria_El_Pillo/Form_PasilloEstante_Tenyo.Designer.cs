
namespace Tenyo_Ferreteria_El_Pillo
{
    partial class Form_PasilloEstante_Tenyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PasilloEstante_Tenyo));
            this.lblPasilloEstante = new System.Windows.Forms.Label();
            this.lblPasillo = new System.Windows.Forms.Label();
            this.txtNumPasillo = new System.Windows.Forms.TextBox();
            this.lblEstante = new System.Windows.Forms.Label();
            this.txtEstante = new System.Windows.Forms.TextBox();
            this.btnAgregarPasillo = new System.Windows.Forms.Button();
            this.btnAgregarEstante = new System.Windows.Forms.Button();
            this.dataGridViewPasillo = new System.Windows.Forms.DataGridView();
            this.dataGridViewEstante = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstante)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPasilloEstante
            // 
            this.lblPasilloEstante.AutoSize = true;
            this.lblPasilloEstante.Font = new System.Drawing.Font("Algerian", 20.25F);
            this.lblPasilloEstante.Location = new System.Drawing.Point(296, 9);
            this.lblPasilloEstante.Name = "lblPasilloEstante";
            this.lblPasilloEstante.Size = new System.Drawing.Size(258, 30);
            this.lblPasilloEstante.TabIndex = 0;
            this.lblPasilloEstante.Text = "Pasillo - Estante";
            // 
            // lblPasillo
            // 
            this.lblPasillo.AutoSize = true;
            this.lblPasillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPasillo.Location = new System.Drawing.Point(12, 76);
            this.lblPasillo.Name = "lblPasillo";
            this.lblPasillo.Size = new System.Drawing.Size(127, 17);
            this.lblPasillo.TabIndex = 1;
            this.lblPasillo.Text = "Numero de Pasillo:";
            // 
            // txtNumPasillo
            // 
            this.txtNumPasillo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumPasillo.Location = new System.Drawing.Point(146, 76);
            this.txtNumPasillo.MaxLength = 20;
            this.txtNumPasillo.Name = "txtNumPasillo";
            this.txtNumPasillo.Size = new System.Drawing.Size(134, 20);
            this.txtNumPasillo.TabIndex = 2;
            // 
            // lblEstante
            // 
            this.lblEstante.AutoSize = true;
            this.lblEstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblEstante.Location = new System.Drawing.Point(420, 77);
            this.lblEstante.Name = "lblEstante";
            this.lblEstante.Size = new System.Drawing.Size(134, 17);
            this.lblEstante.TabIndex = 3;
            this.lblEstante.Text = "Numero de Estante:";
            // 
            // txtEstante
            // 
            this.txtEstante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstante.Location = new System.Drawing.Point(555, 77);
            this.txtEstante.MaxLength = 20;
            this.txtEstante.Name = "txtEstante";
            this.txtEstante.Size = new System.Drawing.Size(131, 20);
            this.txtEstante.TabIndex = 4;
            // 
            // btnAgregarPasillo
            // 
            this.btnAgregarPasillo.FlatAppearance.BorderSize = 0;
            this.btnAgregarPasillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPasillo.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.btnAgregarPasillo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPasillo.Image")));
            this.btnAgregarPasillo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPasillo.Location = new System.Drawing.Point(282, 60);
            this.btnAgregarPasillo.Name = "btnAgregarPasillo";
            this.btnAgregarPasillo.Size = new System.Drawing.Size(132, 51);
            this.btnAgregarPasillo.TabIndex = 5;
            this.btnAgregarPasillo.Text = "&Agregar";
            this.btnAgregarPasillo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPasillo.UseVisualStyleBackColor = true;
            this.btnAgregarPasillo.Click += new System.EventHandler(this.btnAgregarPasillo_Click);
            // 
            // btnAgregarEstante
            // 
            this.btnAgregarEstante.FlatAppearance.BorderSize = 0;
            this.btnAgregarEstante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEstante.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.btnAgregarEstante.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEstante.Image")));
            this.btnAgregarEstante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEstante.Location = new System.Drawing.Point(692, 60);
            this.btnAgregarEstante.Name = "btnAgregarEstante";
            this.btnAgregarEstante.Size = new System.Drawing.Size(132, 51);
            this.btnAgregarEstante.TabIndex = 6;
            this.btnAgregarEstante.Text = "A&gregar";
            this.btnAgregarEstante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarEstante.UseVisualStyleBackColor = true;
            this.btnAgregarEstante.Click += new System.EventHandler(this.btnAgregarEstante_Click);
            // 
            // dataGridViewPasillo
            // 
            this.dataGridViewPasillo.AllowUserToAddRows = false;
            this.dataGridViewPasillo.AllowUserToDeleteRows = false;
            this.dataGridViewPasillo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPasillo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPasillo.Location = new System.Drawing.Point(12, 119);
            this.dataGridViewPasillo.Name = "dataGridViewPasillo";
            this.dataGridViewPasillo.Size = new System.Drawing.Size(379, 192);
            this.dataGridViewPasillo.TabIndex = 7;
            // 
            // dataGridViewEstante
            // 
            this.dataGridViewEstante.AllowUserToAddRows = false;
            this.dataGridViewEstante.AllowUserToDeleteRows = false;
            this.dataGridViewEstante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEstante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstante.Location = new System.Drawing.Point(423, 117);
            this.dataGridViewEstante.Name = "dataGridViewEstante";
            this.dataGridViewEstante.Size = new System.Drawing.Size(379, 192);
            this.dataGridViewEstante.TabIndex = 8;
            // 
            // Form_PasilloEstante_Tenyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(834, 334);
            this.Controls.Add(this.dataGridViewEstante);
            this.Controls.Add(this.dataGridViewPasillo);
            this.Controls.Add(this.btnAgregarEstante);
            this.Controls.Add(this.btnAgregarPasillo);
            this.Controls.Add(this.txtEstante);
            this.Controls.Add(this.lblEstante);
            this.Controls.Add(this.txtNumPasillo);
            this.Controls.Add(this.lblPasillo);
            this.Controls.Add(this.lblPasilloEstante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_PasilloEstante_Tenyo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PASILLO - ESTANTE";
            this.Load += new System.EventHandler(this.Form_PasilloEstante_Tenyo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPasillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasilloEstante;
        private System.Windows.Forms.Label lblPasillo;
        private System.Windows.Forms.TextBox txtNumPasillo;
        private System.Windows.Forms.Label lblEstante;
        private System.Windows.Forms.TextBox txtEstante;
        private System.Windows.Forms.Button btnAgregarPasillo;
        private System.Windows.Forms.Button btnAgregarEstante;
        private System.Windows.Forms.DataGridView dataGridViewPasillo;
        private System.Windows.Forms.DataGridView dataGridViewEstante;
    }
}