namespace Ejercicio_video
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbCodigo = new TextBox();
            tbNombre = new TextBox();
            tbPromedio = new TextBox();
            btnRegistrar = new Button();
            btnEliminar = new Button();
            btnOrdenar = new Button();
            btnBuscar = new Button();
            label4 = new Label();
            tbBuscar = new TextBox();
            dgAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 52);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 89);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 139);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Promedio";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(151, 49);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(135, 27);
            tbCodigo.TabIndex = 3;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(139, 89);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(135, 27);
            tbNombre.TabIndex = 4;
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(131, 136);
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(135, 27);
            tbPromedio.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(51, 196);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(110, 38);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(190, 196);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 38);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(320, 196);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(110, 38);
            btnOrdenar.TabIndex = 8;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(396, 260);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(110, 38);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 266);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 10;
            label4.Text = "Buscar por Codigo";
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(232, 266);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(136, 27);
            tbBuscar.TabIndex = 11;
            // 
            // dgAlumnos
            // 
            dgAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlumnos.Location = new Point(51, 308);
            dgAlumnos.Name = "dgAlumnos";
            dgAlumnos.RowHeadersWidth = 51;
            dgAlumnos.Size = new Size(279, 107);
            dgAlumnos.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dgAlumnos);
            Controls.Add(tbBuscar);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnEliminar);
            Controls.Add(btnRegistrar);
            Controls.Add(tbPromedio);
            Controls.Add(tbNombre);
            Controls.Add(tbCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Resgistro de alumnos";
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbCodigo;
        private TextBox tbNombre;
        private TextBox tbPromedio;
        private Button btnRegistrar;
        private Button btnEliminar;
        private Button btnOrdenar;
        private Button btnBuscar;
        private Label label4;
        private TextBox tbBuscar;
        private DataGridView dgAlumnos;
    }
}
