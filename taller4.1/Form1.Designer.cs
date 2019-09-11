namespace taller4._1
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.dgtabla = new System.Windows.Forms.DataGridView();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnborrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un número";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(209, 62);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 26);
            this.txtnumero.TabIndex = 1;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(341, 57);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(138, 38);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "Ingresar número";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // dgtabla
            // 
            this.dgtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valor,
            this.consecutivo,
            this.resultado});
            this.dgtabla.Location = new System.Drawing.Point(17, 104);
            this.dgtabla.Name = "dgtabla";
            this.dgtabla.Size = new System.Drawing.Size(345, 334);
            this.dgtabla.TabIndex = 3;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // consecutivo
            // 
            this.consecutivo.HeaderText = "Consecutivo";
            this.consecutivo.Name = "consecutivo";
            this.consecutivo.ReadOnly = true;
            // 
            // resultado
            // 
            this.resultado.HeaderText = "Resultado";
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(383, 121);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(96, 69);
            this.btnborrar.TabIndex = 4;
            this.btnborrar.Text = "borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Calculadora multiplicación";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.dgtabla);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgtabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.DataGridView dgtabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultado;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Label label2;
    }
}

