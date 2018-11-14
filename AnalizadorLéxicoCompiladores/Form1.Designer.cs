namespace AnalizadorLéxicoCompiladores
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonArchivo = new System.Windows.Forms.RadioButton();
            this.radioButtonConsola = new System.Windows.Forms.RadioButton();
            this.groupBoxConsola = new System.Windows.Forms.GroupBox();
            this.buttonCargarConsola = new System.Windows.Forms.Button();
            this.textBoxConsola = new System.Windows.Forms.TextBox();
            this.groupBoxArchivo = new System.Windows.Forms.GroupBox();
            this.LabelSeleccionarArchivo = new System.Windows.Forms.LinkLabel();
            this.textBoxSeleccionArchivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCarga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBoxConsola.SuspendLayout();
            this.groupBoxArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de carga:";
            // 
            // radioButtonArchivo
            // 
            this.radioButtonArchivo.AutoSize = true;
            this.radioButtonArchivo.Location = new System.Drawing.Point(191, 15);
            this.radioButtonArchivo.Name = "radioButtonArchivo";
            this.radioButtonArchivo.Size = new System.Drawing.Size(64, 17);
            this.radioButtonArchivo.TabIndex = 1;
            this.radioButtonArchivo.TabStop = true;
            this.radioButtonArchivo.Text = "Archivo.";
            this.radioButtonArchivo.UseVisualStyleBackColor = true;
            this.radioButtonArchivo.CheckedChanged += new System.EventHandler(this.radioButtonArchivo_CheckedChanged);
            // 
            // radioButtonConsola
            // 
            this.radioButtonConsola.AutoSize = true;
            this.radioButtonConsola.Location = new System.Drawing.Point(335, 15);
            this.radioButtonConsola.Name = "radioButtonConsola";
            this.radioButtonConsola.Size = new System.Drawing.Size(66, 17);
            this.radioButtonConsola.TabIndex = 2;
            this.radioButtonConsola.TabStop = true;
            this.radioButtonConsola.Text = "Consola.";
            this.radioButtonConsola.UseVisualStyleBackColor = true;
            // 
            // groupBoxConsola
            // 
            this.groupBoxConsola.Controls.Add(this.buttonCargarConsola);
            this.groupBoxConsola.Controls.Add(this.textBoxConsola);
            this.groupBoxConsola.Location = new System.Drawing.Point(46, 38);
            this.groupBoxConsola.Name = "groupBoxConsola";
            this.groupBoxConsola.Size = new System.Drawing.Size(867, 206);
            this.groupBoxConsola.TabIndex = 3;
            this.groupBoxConsola.TabStop = false;
            this.groupBoxConsola.Text = "Carga Consola.";
            // 
            // buttonCargarConsola
            // 
            this.buttonCargarConsola.Location = new System.Drawing.Point(16, 173);
            this.buttonCargarConsola.Name = "buttonCargarConsola";
            this.buttonCargarConsola.Size = new System.Drawing.Size(101, 26);
            this.buttonCargarConsola.TabIndex = 1;
            this.buttonCargarConsola.Text = "Cargar.";
            this.buttonCargarConsola.UseVisualStyleBackColor = true;
            this.buttonCargarConsola.Click += new System.EventHandler(this.buttonCargarConsola_Click);
            // 
            // textBoxConsola
            // 
            this.textBoxConsola.Location = new System.Drawing.Point(15, 23);
            this.textBoxConsola.Multiline = true;
            this.textBoxConsola.Name = "textBoxConsola";
            this.textBoxConsola.Size = new System.Drawing.Size(835, 144);
            this.textBoxConsola.TabIndex = 0;
            // 
            // groupBoxArchivo
            // 
            this.groupBoxArchivo.Controls.Add(this.LabelSeleccionarArchivo);
            this.groupBoxArchivo.Controls.Add(this.textBoxSeleccionArchivo);
            this.groupBoxArchivo.Controls.Add(this.label2);
            this.groupBoxArchivo.Location = new System.Drawing.Point(37, 79);
            this.groupBoxArchivo.Name = "groupBoxArchivo";
            this.groupBoxArchivo.Size = new System.Drawing.Size(544, 109);
            this.groupBoxArchivo.TabIndex = 4;
            this.groupBoxArchivo.TabStop = false;
            this.groupBoxArchivo.Text = "Carga Archivo .txt";
            // 
            // LabelSeleccionarArchivo
            // 
            this.LabelSeleccionarArchivo.AutoSize = true;
            this.LabelSeleccionarArchivo.Location = new System.Drawing.Point(405, 50);
            this.LabelSeleccionarArchivo.Name = "LabelSeleccionarArchivo";
            this.LabelSeleccionarArchivo.Size = new System.Drawing.Size(102, 13);
            this.LabelSeleccionarArchivo.TabIndex = 2;
            this.LabelSeleccionarArchivo.TabStop = true;
            this.LabelSeleccionarArchivo.Text = "Seleccionar Archivo";
            this.LabelSeleccionarArchivo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelSeleccionarArchivo_LinkClicked);
            // 
            // textBoxSeleccionArchivo
            // 
            this.textBoxSeleccionArchivo.Location = new System.Drawing.Point(86, 43);
            this.textBoxSeleccionArchivo.Name = "textBoxSeleccionArchivo";
            this.textBoxSeleccionArchivo.ReadOnly = true;
            this.textBoxSeleccionArchivo.Size = new System.Drawing.Size(292, 20);
            this.textBoxSeleccionArchivo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Archivo:";
            // 
            // textBoxCarga
            // 
            this.textBoxCarga.Location = new System.Drawing.Point(38, 267);
            this.textBoxCarga.Multiline = true;
            this.textBoxCarga.Name = "textBoxCarga";
            this.textBoxCarga.ReadOnly = true;
            this.textBoxCarga.Size = new System.Drawing.Size(875, 241);
            this.textBoxCarga.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Carga:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Analizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(821, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Tabla de simbolos";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(702, 13);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(85, 13);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Tabla de Errores";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 611);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxArchivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCarga);
            this.Controls.Add(this.radioButtonConsola);
            this.Controls.Add(this.radioButtonArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxConsola);
            this.Name = "Form1";
            this.Text = "Analizador Léxico";
            this.groupBoxConsola.ResumeLayout(false);
            this.groupBoxConsola.PerformLayout();
            this.groupBoxArchivo.ResumeLayout(false);
            this.groupBoxArchivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonArchivo;
        private System.Windows.Forms.RadioButton radioButtonConsola;
        private System.Windows.Forms.GroupBox groupBoxConsola;
        private System.Windows.Forms.Button buttonCargarConsola;
        private System.Windows.Forms.TextBox textBoxConsola;
        private System.Windows.Forms.GroupBox groupBoxArchivo;
        private System.Windows.Forms.LinkLabel LabelSeleccionarArchivo;
        private System.Windows.Forms.TextBox textBoxSeleccionArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

