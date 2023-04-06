
namespace Tenyo_Ferreteria_El_Pillo
{
    partial class Form_Medida_Tenyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Medida_Tenyo));
            this.lblMedida = new System.Windows.Forms.Label();
            this.lblNombreMedida = new System.Windows.Forms.Label();
            this.txtNombreMedida = new System.Windows.Forms.TextBox();
            this.lblAbrevMedida = new System.Windows.Forms.Label();
            this.txtAbrevMedida = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Font = new System.Drawing.Font("Algerian", 20.25F);
            this.lblMedida.Location = new System.Drawing.Point(223, 9);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(110, 30);
            this.lblMedida.TabIndex = 0;
            this.lblMedida.Text = "Medida";
            // 
            // lblNombreMedida
            // 
            this.lblNombreMedida.AutoSize = true;
            this.lblNombreMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNombreMedida.Location = new System.Drawing.Point(27, 63);
            this.lblNombreMedida.Name = "lblNombreMedida";
            this.lblNombreMedida.Size = new System.Drawing.Size(147, 17);
            this.lblNombreMedida.TabIndex = 1;
            this.lblNombreMedida.Text = "Nombre de la Medida:";
            // 
            // txtNombreMedida
            // 
            this.txtNombreMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreMedida.Location = new System.Drawing.Point(179, 63);
            this.txtNombreMedida.MaxLength = 50;
            this.txtNombreMedida.Name = "txtNombreMedida";
            this.txtNombreMedida.Size = new System.Drawing.Size(190, 20);
            this.txtNombreMedida.TabIndex = 2;
            // 
            // lblAbrevMedida
            // 
            this.lblAbrevMedida.AutoSize = true;
            this.lblAbrevMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblAbrevMedida.Location = new System.Drawing.Point(28, 98);
            this.lblAbrevMedida.Name = "lblAbrevMedida";
            this.lblAbrevMedida.Size = new System.Drawing.Size(155, 17);
            this.lblAbrevMedida.TabIndex = 3;
            this.lblAbrevMedida.Text = "Abreviatura de Medida:";
            // 
            // txtAbrevMedida
            // 
            this.txtAbrevMedida.Location = new System.Drawing.Point(180, 97);
            this.txtAbrevMedida.MaxLength = 50;
            this.txtAbrevMedida.Name = "txtAbrevMedida";
            this.txtAbrevMedida.Size = new System.Drawing.Size(190, 20);
            this.txtAbrevMedida.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(396, 59);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 56);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form_Medida_Tenyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(551, 148);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAbrevMedida);
            this.Controls.Add(this.lblAbrevMedida);
            this.Controls.Add(this.txtNombreMedida);
            this.Controls.Add(this.lblNombreMedida);
            this.Controls.Add(this.lblMedida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Medida_Tenyo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEDIDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.Label lblNombreMedida;
        private System.Windows.Forms.TextBox txtNombreMedida;
        private System.Windows.Forms.Label lblAbrevMedida;
        private System.Windows.Forms.TextBox txtAbrevMedida;
        private System.Windows.Forms.Button btnAgregar;
    }
}