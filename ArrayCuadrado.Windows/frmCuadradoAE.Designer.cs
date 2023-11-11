namespace ArrayCuadrado.Windows
{
    partial class frmCuadradoAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtLado = new TextBox();
            btnOk = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            cboColores = new ComboBox();
            gbxBordes = new GroupBox();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            gbxBordes.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Medida del lado:";
            // 
            // txtLado
            // 
            txtLado.Location = new Point(150, 33);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(125, 27);
            txtLado.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(427, 45);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 58);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(427, 154);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 58);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 96);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 0;
            label2.Text = "Color Relleno:";
            // 
            // cboColores
            // 
            cboColores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColores.FormattingEnabled = true;
            cboColores.Location = new Point(129, 93);
            cboColores.Name = "cboColores";
            cboColores.Size = new Size(183, 28);
            cboColores.TabIndex = 3;
            // 
            // gbxBordes
            // 
            gbxBordes.Controls.Add(radioButton1);
            gbxBordes.Location = new Point(21, 140);
            gbxBordes.Name = "gbxBordes";
            gbxBordes.Size = new Size(278, 141);
            gbxBordes.TabIndex = 4;
            gbxBordes.TabStop = false;
            gbxBordes.Text = "Tipo de Bordes ";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // frmCuadradoAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 326);
            ControlBox = false;
            Controls.Add(gbxBordes);
            Controls.Add(cboColores);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txtLado);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(582, 373);
            MinimumSize = new Size(582, 373);
            Name = "frmCuadradoAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCuadradoAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            gbxBordes.ResumeLayout(false);
            gbxBordes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLado;
        private Button btnOk;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
        private ComboBox cboColores;
        private Label label2;
        private GroupBox gbxBordes;
        private RadioButton radioButton1;
    }
}