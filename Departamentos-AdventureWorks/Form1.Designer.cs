namespace Departamentos_AdventureWorks
{
    partial class frmOperacionesCRUD
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
            this.gbOperacionesCRUD = new System.Windows.Forms.GroupBox();
            this.btnListarDpt = new System.Windows.Forms.Button();
            this.btnActualizarDpt = new System.Windows.Forms.Button();
            this.btnCrearDpt = new System.Windows.Forms.Button();
            this.btnEliminarDpt = new System.Windows.Forms.Button();
            this.gbOperacionesCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOperacionesCRUD
            // 
            this.gbOperacionesCRUD.Controls.Add(this.btnEliminarDpt);
            this.gbOperacionesCRUD.Controls.Add(this.btnCrearDpt);
            this.gbOperacionesCRUD.Controls.Add(this.btnActualizarDpt);
            this.gbOperacionesCRUD.Controls.Add(this.btnListarDpt);
            this.gbOperacionesCRUD.Location = new System.Drawing.Point(12, 12);
            this.gbOperacionesCRUD.Name = "gbOperacionesCRUD";
            this.gbOperacionesCRUD.Size = new System.Drawing.Size(413, 199);
            this.gbOperacionesCRUD.TabIndex = 0;
            this.gbOperacionesCRUD.TabStop = false;
            this.gbOperacionesCRUD.Text = "OPCIONES DISPONIBLES PARA DEPARTAMENTOS";
            // 
            // btnListarDpt
            // 
            this.btnListarDpt.Location = new System.Drawing.Point(23, 57);
            this.btnListarDpt.Name = "btnListarDpt";
            this.btnListarDpt.Size = new System.Drawing.Size(180, 51);
            this.btnListarDpt.TabIndex = 0;
            this.btnListarDpt.Text = "Listar Departamentos";
            this.btnListarDpt.UseVisualStyleBackColor = true;
            // 
            // btnActualizarDpt
            // 
            this.btnActualizarDpt.Location = new System.Drawing.Point(23, 114);
            this.btnActualizarDpt.Name = "btnActualizarDpt";
            this.btnActualizarDpt.Size = new System.Drawing.Size(180, 51);
            this.btnActualizarDpt.TabIndex = 1;
            this.btnActualizarDpt.Text = "Actualizar Departamento";
            this.btnActualizarDpt.UseVisualStyleBackColor = true;
            // 
            // btnCrearDpt
            // 
            this.btnCrearDpt.Location = new System.Drawing.Point(209, 57);
            this.btnCrearDpt.Name = "btnCrearDpt";
            this.btnCrearDpt.Size = new System.Drawing.Size(180, 51);
            this.btnCrearDpt.TabIndex = 2;
            this.btnCrearDpt.Text = "Crear Departamento";
            this.btnCrearDpt.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDpt
            // 
            this.btnEliminarDpt.Location = new System.Drawing.Point(209, 114);
            this.btnEliminarDpt.Name = "btnEliminarDpt";
            this.btnEliminarDpt.Size = new System.Drawing.Size(180, 51);
            this.btnEliminarDpt.TabIndex = 3;
            this.btnEliminarDpt.Text = "Eliminar Departamento";
            this.btnEliminarDpt.UseVisualStyleBackColor = true;
            // 
            // frmOperacionesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 227);
            this.Controls.Add(this.gbOperacionesCRUD);
            this.Name = "frmOperacionesCRUD";
            this.Text = "Operaciones CRUD con Departamentos Adventure Works";
            this.gbOperacionesCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperacionesCRUD;
        private System.Windows.Forms.Button btnEliminarDpt;
        private System.Windows.Forms.Button btnCrearDpt;
        private System.Windows.Forms.Button btnActualizarDpt;
        private System.Windows.Forms.Button btnListarDpt;
    }
}

