namespace GTemperaturas_VersionGrafica_FranGV
{
    partial class Temperaturas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAgregarCiudad = new System.Windows.Forms.Button();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.labelAgregarCiudad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregarTemperatura = new System.Windows.Forms.Button();
            this.comboBoxListaCiudades = new System.Windows.Forms.ComboBox();
            this.comboBoxListaTemperaturas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMedia = new System.Windows.Forms.Button();
            this.textBoxMediaAnual = new System.Windows.Forms.TextBox();
            this.listBoxTemperaturas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAgregarCiudad
            // 
            this.buttonAgregarCiudad.Location = new System.Drawing.Point(397, 24);
            this.buttonAgregarCiudad.Name = "buttonAgregarCiudad";
            this.buttonAgregarCiudad.Size = new System.Drawing.Size(146, 23);
            this.buttonAgregarCiudad.TabIndex = 0;
            this.buttonAgregarCiudad.Text = "Agregar Ciudad";
            this.buttonAgregarCiudad.UseVisualStyleBackColor = true;
            this.buttonAgregarCiudad.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(154, 27);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(202, 20);
            this.textBoxCiudad.TabIndex = 2;
            // 
            // labelAgregarCiudad
            // 
            this.labelAgregarCiudad.AutoSize = true;
            this.labelAgregarCiudad.Location = new System.Drawing.Point(55, 29);
            this.labelAgregarCiudad.Name = "labelAgregarCiudad";
            this.labelAgregarCiudad.Size = new System.Drawing.Size(86, 13);
            this.labelAgregarCiudad.TabIndex = 3;
            this.labelAgregarCiudad.Text = "Agregar Ciudad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Agregar Temepratura: ";
            // 
            // buttonAgregarTemperatura
            // 
            this.buttonAgregarTemperatura.Enabled = false;
            this.buttonAgregarTemperatura.Location = new System.Drawing.Point(377, 128);
            this.buttonAgregarTemperatura.Name = "buttonAgregarTemperatura";
            this.buttonAgregarTemperatura.Size = new System.Drawing.Size(146, 23);
            this.buttonAgregarTemperatura.TabIndex = 4;
            this.buttonAgregarTemperatura.Text = "Agregar Temperaturas";
            this.buttonAgregarTemperatura.UseVisualStyleBackColor = true;
            this.buttonAgregarTemperatura.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // comboBoxListaCiudades
            // 
            this.comboBoxListaCiudades.FormattingEnabled = true;
            this.comboBoxListaCiudades.Location = new System.Drawing.Point(154, 55);
            this.comboBoxListaCiudades.Name = "comboBoxListaCiudades";
            this.comboBoxListaCiudades.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListaCiudades.TabIndex = 7;
            // 
            // comboBoxListaTemperaturas
            // 
            this.comboBoxListaTemperaturas.FormattingEnabled = true;
            this.comboBoxListaTemperaturas.Location = new System.Drawing.Point(154, 281);
            this.comboBoxListaTemperaturas.Name = "comboBoxListaTemperaturas";
            this.comboBoxListaTemperaturas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListaTemperaturas.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista Ciudades:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lista Temperaturas: ";
            // 
            // buttonMedia
            // 
            this.buttonMedia.Location = new System.Drawing.Point(21, 326);
            this.buttonMedia.Name = "buttonMedia";
            this.buttonMedia.Size = new System.Drawing.Size(146, 23);
            this.buttonMedia.TabIndex = 11;
            this.buttonMedia.Text = "Media Anual";
            this.buttonMedia.UseVisualStyleBackColor = true;
            this.buttonMedia.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // textBoxMediaAnual
            // 
            this.textBoxMediaAnual.Location = new System.Drawing.Point(183, 328);
            this.textBoxMediaAnual.Name = "textBoxMediaAnual";
            this.textBoxMediaAnual.Size = new System.Drawing.Size(202, 20);
            this.textBoxMediaAnual.TabIndex = 12;
            // 
            // listBoxTemperaturas
            // 
            this.listBoxTemperaturas.FormattingEnabled = true;
            this.listBoxTemperaturas.Location = new System.Drawing.Point(155, 128);
            this.listBoxTemperaturas.Name = "listBoxTemperaturas";
            this.listBoxTemperaturas.Size = new System.Drawing.Size(201, 121);
            this.listBoxTemperaturas.TabIndex = 13;
            // 
            // Temperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 415);
            this.Controls.Add(this.listBoxTemperaturas);
            this.Controls.Add(this.textBoxMediaAnual);
            this.Controls.Add(this.buttonMedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxListaTemperaturas);
            this.Controls.Add(this.comboBoxListaCiudades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAgregarTemperatura);
            this.Controls.Add(this.labelAgregarCiudad);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.buttonAgregarCiudad);
            this.Name = "Temperaturas";
            this.Text = "Temperaturas";
            this.Load += new System.EventHandler(this.Temperaturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregarCiudad;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label labelAgregarCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregarTemperatura;
        private System.Windows.Forms.ComboBox comboBoxListaCiudades;
        private System.Windows.Forms.ComboBox comboBoxListaTemperaturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMedia;
        private System.Windows.Forms.TextBox textBoxMediaAnual;
        private System.Windows.Forms.ListBox listBoxTemperaturas;
    }
}

