
namespace Tenyo_Ferreteria_El_Pillo
{
    partial class Form_Caracteristica_Tenyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Caracteristica_Tenyo));
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.lblClaveCar = new System.Windows.Forms.Label();
            this.txtClaveCar = new System.Windows.Forms.TextBox();
            this.lblNombreCar = new System.Windows.Forms.Label();
            this.txtNombreCar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Font = new System.Drawing.Font("Algerian", 20.25F);
            this.lblCaracteristicas.Location = new System.Drawing.Point(189, 18);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(250, 30);
            this.lblCaracteristicas.TabIndex = 0;
            this.lblCaracteristicas.Text = "Caracteristicas";
            // 
            // lblClaveCar
            // 
            this.lblClaveCar.AutoSize = true;
            this.lblClaveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblClaveCar.Location = new System.Drawing.Point(25, 75);
            this.lblClaveCar.Name = "lblClaveCar";
            this.lblClaveCar.Size = new System.Drawing.Size(157, 17);
            this.lblClaveCar.TabIndex = 1;
            this.lblClaveCar.Text = "Clave de Caracteristica:";
            // 
            // txtClaveCar
            // 
            this.txtClaveCar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveCar.Location = new System.Drawing.Point(182, 75);
            this.txtClaveCar.MaxLength = 20;
            this.txtClaveCar.Name = "txtClaveCar";
            this.txtClaveCar.Size = new System.Drawing.Size(228, 20);
            this.txtClaveCar.TabIndex = 2;
            // 
            // lblNombreCar
            // 
            this.lblNombreCar.AutoSize = true;
            this.lblNombreCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNombreCar.Location = new System.Drawing.Point(25, 111);
            this.lblNombreCar.Name = "lblNombreCar";
            this.lblNombreCar.Size = new System.Drawing.Size(172, 17);
            this.lblNombreCar.TabIndex = 3;
            this.lblNombreCar.Text = "Nombre de Caracteristica:";
            // 
            // txtNombreCar
            // 
            this.txtNombreCar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCar.Location = new System.Drawing.Point(199, 111);
            this.txtNombreCar.MaxLength = 150;
            this.txtNombreCar.Name = "txtNombreCar";
            this.txtNombreCar.Size = new System.Drawing.Size(296, 20);
            this.txtNombreCar.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(525, 76);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 51);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form_Caracteristica_Tenyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(661, 159);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreCar);
            this.Controls.Add(this.lblNombreCar);
            this.Controls.Add(this.txtClaveCar);
            this.Controls.Add(this.lblClaveCar);
            this.Controls.Add(this.lblCaracteristicas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Caracteristica_Tenyo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARACTERISTICAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.Label lblClaveCar;
        private System.Windows.Forms.TextBox txtClaveCar;
        private System.Windows.Forms.Label lblNombreCar;
        private System.Windows.Forms.TextBox txtNombreCar;
        private System.Windows.Forms.Button btnAgregar;
    }
}