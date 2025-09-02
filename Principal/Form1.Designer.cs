namespace Principal
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
            label4 = new Label();
            label5 = new Label();
            txtPlaca = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            txtColor = new TextBox();
            btnGuardar = new Button();
            btnVer = new Button();
            btnActualiz = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 24);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Parqueadero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 77);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 1;
            label2.Text = "Placa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 151);
            label3.Name = "label3";
            label3.Size = new Size(56, 16);
            label3.TabIndex = 2;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 228);
            label4.Name = "label4";
            label4.Size = new Size(50, 16);
            label4.TabIndex = 3;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 311);
            label5.Name = "label5";
            label5.Size = new Size(42, 16);
            label5.TabIndex = 4;
            label5.Text = "Color";
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlaca.Location = new Point(59, 96);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(259, 26);
            txtPlaca.TabIndex = 5;
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModelo.Location = new Point(59, 170);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(259, 26);
            txtModelo.TabIndex = 6;
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMarca.Location = new Point(59, 247);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(259, 26);
            txtMarca.TabIndex = 7;
            // 
            // txtColor
            // 
            txtColor.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtColor.Location = new Point(59, 330);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(259, 26);
            txtColor.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(59, 417);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 31);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVer
            // 
            btnVer.BackColor = SystemColors.ActiveCaption;
            btnVer.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVer.Location = new Point(205, 417);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(113, 31);
            btnVer.TabIndex = 10;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += btnVer_Click;
            // 
            // btnActualiz
            // 
            btnActualiz.BackColor = SystemColors.ActiveCaption;
            btnActualiz.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualiz.Location = new Point(59, 454);
            btnActualiz.Name = "btnActualiz";
            btnActualiz.Size = new Size(113, 31);
            btnActualiz.TabIndex = 11;
            btnActualiz.Text = "Actualizar";
            btnActualiz.UseVisualStyleBackColor = false;
            btnActualiz.Click += btnActualiz_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ActiveCaption;
            btnEliminar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(205, 454);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 31);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(131, 380);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(113, 31);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 497);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualiz);
            Controls.Add(btnVer);
            Controls.Add(btnGuardar);
            Controls.Add(txtColor);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(txtPlaca);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPlaca;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private TextBox txtColor;
        private Button btnGuardar;
        private Button btnVer;
        private Button btnActualiz;
        private Button btnEliminar;
        private Button btnBuscar;
    }
}
