
namespace PracticaFormulariosTarea1
{
    partial class FormularioRegistro
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
            this.AgregaAlumno = new System.Windows.Forms.Label();
            this.ApellidoP = new System.Windows.Forms.Label();
            this.NombreA = new System.Windows.Forms.Label();
            this.ApellidoM = new System.Windows.Forms.Label();
            this.BoxNombre = new System.Windows.Forms.TextBox();
            this.BoxApellidoM = new System.Windows.Forms.TextBox();
            this.BoxApellidoP = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Label();
            this.BoxBuscar = new System.Windows.Forms.TextBox();
            this.GridEstudiantes = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentApPa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentApMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregaAlumno
            // 
            this.AgregaAlumno.AutoSize = true;
            this.AgregaAlumno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregaAlumno.ForeColor = System.Drawing.Color.Maroon;
            this.AgregaAlumno.Location = new System.Drawing.Point(12, 32);
            this.AgregaAlumno.Name = "AgregaAlumno";
            this.AgregaAlumno.Size = new System.Drawing.Size(248, 33);
            this.AgregaAlumno.TabIndex = 0;
            this.AgregaAlumno.Text = "Agregar Alumno";
            // 
            // ApellidoP
            // 
            this.ApellidoP.AutoSize = true;
            this.ApellidoP.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoP.ForeColor = System.Drawing.Color.Black;
            this.ApellidoP.Location = new System.Drawing.Point(196, 87);
            this.ApellidoP.Name = "ApellidoP";
            this.ApellidoP.Size = new System.Drawing.Size(220, 28);
            this.ApellidoP.TabIndex = 1;
            this.ApellidoP.Text = "Apellido Paterno";
            // 
            // NombreA
            // 
            this.NombreA.AutoSize = true;
            this.NombreA.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreA.ForeColor = System.Drawing.Color.Black;
            this.NombreA.Location = new System.Drawing.Point(-1, 87);
            this.NombreA.Name = "NombreA";
            this.NombreA.Size = new System.Drawing.Size(90, 28);
            this.NombreA.TabIndex = 2;
            this.NombreA.Text = "Nombre";
            // 
            // ApellidoM
            // 
            this.ApellidoM.AutoSize = true;
            this.ApellidoM.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoM.ForeColor = System.Drawing.Color.Black;
            this.ApellidoM.Location = new System.Drawing.Point(-1, 157);
            this.ApellidoM.Name = "ApellidoM";
            this.ApellidoM.Size = new System.Drawing.Size(220, 28);
            this.ApellidoM.TabIndex = 3;
            this.ApellidoM.Text = "Apellido Materno";
            // 
            // BoxNombre
            // 
            this.BoxNombre.Location = new System.Drawing.Point(4, 118);
            this.BoxNombre.Name = "BoxNombre";
            this.BoxNombre.Size = new System.Drawing.Size(162, 20);
            this.BoxNombre.TabIndex = 4;
            this.BoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxNombre_KeyPress);
            // 
            // BoxApellidoM
            // 
            this.BoxApellidoM.Location = new System.Drawing.Point(4, 188);
            this.BoxApellidoM.Name = "BoxApellidoM";
            this.BoxApellidoM.Size = new System.Drawing.Size(215, 20);
            this.BoxApellidoM.TabIndex = 5;
            this.BoxApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxApellidoM_KeyPress);
            // 
            // BoxApellidoP
            // 
            this.BoxApellidoP.Location = new System.Drawing.Point(190, 118);
            this.BoxApellidoP.Name = "BoxApellidoP";
            this.BoxApellidoP.Size = new System.Drawing.Size(241, 20);
            this.BoxApellidoP.TabIndex = 6;
            this.BoxApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxApellidoP_KeyPress);
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(225, 186);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(114, 25);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.Location = new System.Drawing.Point(345, 188);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(113, 23);
            this.Limpiar.TabIndex = 8;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.Color.Maroon;
            this.Buscar.Location = new System.Drawing.Point(6, 220);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(117, 33);
            this.Buscar.TabIndex = 9;
            this.Buscar.Text = "Buscar";
            // 
            // BoxBuscar
            // 
            this.BoxBuscar.Location = new System.Drawing.Point(4, 256);
            this.BoxBuscar.Name = "BoxBuscar";
            this.BoxBuscar.Size = new System.Drawing.Size(412, 20);
            this.BoxBuscar.TabIndex = 10;
            // 
            // GridEstudiantes
            // 
            this.GridEstudiantes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.StudentApPa,
            this.StudentApMa});
            this.GridEstudiantes.Location = new System.Drawing.Point(4, 282);
            this.GridEstudiantes.Name = "GridEstudiantes";
            this.GridEstudiantes.Size = new System.Drawing.Size(454, 265);
            this.GridEstudiantes.TabIndex = 11;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Nombre";
            this.StudentName.Name = "StudentName";
            // 
            // StudentApPa
            // 
            this.StudentApPa.HeaderText = "Apellido Paterno";
            this.StudentApPa.Name = "StudentApPa";
            // 
            // StudentApMa
            // 
            this.StudentApMa.HeaderText = "Apellido Materno";
            this.StudentApMa.Name = "StudentApMa";
            // 
            // FormularioRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(470, 559);
            this.Controls.Add(this.GridEstudiantes);
            this.Controls.Add(this.BoxBuscar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.BoxApellidoP);
            this.Controls.Add(this.BoxApellidoM);
            this.Controls.Add(this.BoxNombre);
            this.Controls.Add(this.ApellidoM);
            this.Controls.Add(this.NombreA);
            this.Controls.Add(this.ApellidoP);
            this.Controls.Add(this.AgregaAlumno);
            this.Name = "FormularioRegistro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AgregaAlumno;
        private System.Windows.Forms.Label ApellidoP;
        private System.Windows.Forms.Label NombreA;
        private System.Windows.Forms.Label ApellidoM;
        private System.Windows.Forms.TextBox BoxNombre;
        private System.Windows.Forms.TextBox BoxApellidoM;
        private System.Windows.Forms.TextBox BoxApellidoP;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.TextBox BoxBuscar;
        private System.Windows.Forms.DataGridView GridEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentApPa;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentApMa;
    }
}

