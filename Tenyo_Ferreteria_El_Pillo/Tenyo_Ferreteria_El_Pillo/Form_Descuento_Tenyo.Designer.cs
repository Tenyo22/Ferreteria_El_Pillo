
namespace Tenyo_Ferreteria_El_Pillo
{
    partial class Form_Descuento_Tenyo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Descuento_Tenyo));
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblPorcentajeDescuento = new System.Windows.Forms.Label();
            this.spnDescuento = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewDescuento = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spnDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Algerian", 20.25F);
            this.lblDescuento.Location = new System.Drawing.Point(107, 9);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(174, 30);
            this.lblDescuento.TabIndex = 0;
            this.lblDescuento.Text = "DESCUENTOS";
            // 
            // lblPorcentajeDescuento
            // 
            this.lblPorcentajeDescuento.AutoSize = true;
            this.lblPorcentajeDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPorcentajeDescuento.Location = new System.Drawing.Point(24, 60);
            this.lblPorcentajeDescuento.Name = "lblPorcentajeDescuento";
            this.lblPorcentajeDescuento.Size = new System.Drawing.Size(172, 17);
            this.lblPorcentajeDescuento.TabIndex = 1;
            this.lblPorcentajeDescuento.Text = "Porcentaje de Descuento:";
            // 
            // spnDescuento
            // 
            this.spnDescuento.Location = new System.Drawing.Point(196, 60);
            this.spnDescuento.Name = "spnDescuento";
            this.spnDescuento.Size = new System.Drawing.Size(70, 20);
            this.spnDescuento.TabIndex = 2;
            // 
            // dataGridViewDescuento
            // 
            this.dataGridViewDescuento.AllowUserToAddRows = false;
            this.dataGridViewDescuento.AllowUserToDeleteRows = false;
            this.dataGridViewDescuento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDescuento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDescuento.Location = new System.Drawing.Point(34, 103);
            this.dataGridViewDescuento.Name = "dataGridViewDescuento";
            this.dataGridViewDescuento.Size = new System.Drawing.Size(323, 149);
            this.dataGridViewDescuento.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bell MT", 14.25F);
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(272, 42);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 57);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form_Descuento_Tenyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(413, 277);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewDescuento);
            this.Controls.Add(this.spnDescuento);
            this.Controls.Add(this.lblPorcentajeDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Descuento_Tenyo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DESCUENTOS";
            this.Load += new System.EventHandler(this.Form_Descuento_Tenyo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spnDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblPorcentajeDescuento;
        private System.Windows.Forms.NumericUpDown spnDescuento;
        private System.Windows.Forms.DataGridView dataGridViewDescuento;
        private System.Windows.Forms.Button btnAgregar;
    }
}