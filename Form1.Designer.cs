
namespace Lab_reapao__1
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
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.dataGridViewAsistencia = new System.Windows.Forms.DataGridView();
            this.buttonCargarDatos = new System.Windows.Forms.Button();
            this.dataGridViewSueldos = new System.Windows.Forms.DataGridView();
            this.buttonCalcularSueldo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSueldos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(43, 33);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewEmpleados.TabIndex = 0;
            // 
            // dataGridViewAsistencia
            // 
            this.dataGridViewAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsistencia.Location = new System.Drawing.Point(289, 33);
            this.dataGridViewAsistencia.Name = "dataGridViewAsistencia";
            this.dataGridViewAsistencia.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewAsistencia.TabIndex = 1;
            // 
            // buttonCargarDatos
            // 
            this.buttonCargarDatos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCargarDatos.Location = new System.Drawing.Point(263, 227);
            this.buttonCargarDatos.Name = "buttonCargarDatos";
            this.buttonCargarDatos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonCargarDatos.Size = new System.Drawing.Size(145, 106);
            this.buttonCargarDatos.TabIndex = 2;
            this.buttonCargarDatos.Text = "ver";
            this.buttonCargarDatos.UseVisualStyleBackColor = true;
            this.buttonCargarDatos.Click += new System.EventHandler(this.buttonCargarDatos_Click);
            // 
            // dataGridViewSueldos
            // 
            this.dataGridViewSueldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSueldos.Location = new System.Drawing.Point(535, 33);
            this.dataGridViewSueldos.Name = "dataGridViewSueldos";
            this.dataGridViewSueldos.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewSueldos.TabIndex = 3;
            // 
            // buttonCalcularSueldo
            // 
            this.buttonCalcularSueldo.Location = new System.Drawing.Point(415, 227);
            this.buttonCalcularSueldo.Name = "buttonCalcularSueldo";
            this.buttonCalcularSueldo.Size = new System.Drawing.Size(146, 106);
            this.buttonCalcularSueldo.TabIndex = 4;
            this.buttonCalcularSueldo.Text = "Calcular sueldo";
            this.buttonCalcularSueldo.UseVisualStyleBackColor = true;
            this.buttonCalcularSueldo.Click += new System.EventHandler(this.buttonCalcularSueldo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalcularSueldo);
            this.Controls.Add(this.dataGridViewSueldos);
            this.Controls.Add(this.buttonCargarDatos);
            this.Controls.Add(this.dataGridViewAsistencia);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Name = "Form1";
            this.Text = "EMPLEADOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSueldos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.DataGridView dataGridViewAsistencia;
        private System.Windows.Forms.Button buttonCargarDatos;
        private System.Windows.Forms.DataGridView dataGridViewSueldos;
        private System.Windows.Forms.Button buttonCalcularSueldo;
    }
}

