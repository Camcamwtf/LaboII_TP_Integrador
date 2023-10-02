namespace MiCalculadora
{
    partial class FrmCalculadora : Form
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
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            cmbOperacion = new ComboBox();
            rdbDecimal = new RadioButton();
            rdbBinario = new RadioButton();
            lblOperacion = new Label();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            grpSistema = new GroupBox();
            lblResultado = new Label();
            lblPrimerOperador = new Label();
            lblSegundoOperador = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.BackColor = Color.White;
            btnOperar.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(105, 336);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(184, 53);
            btnOperar.TabIndex = 3;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = false;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(306, 336);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(184, 53);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(507, 336);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(184, 53);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // cmbOperacion
            // 
            cmbOperacion.BackColor = SystemColors.Window;
            cmbOperacion.DropDownHeight = 110;
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.IntegralHeight = false;
            cmbOperacion.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperacion.Location = new Point(306, 279);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(184, 32);
            cmbOperacion.TabIndex = 1;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(13, 28);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(92, 25);
            rdbDecimal.TabIndex = 6;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(13, 59);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(84, 25);
            rdbBinario.TabIndex = 6;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.Location = new Point(306, 258);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(86, 18);
            lblOperacion.TabIndex = 1;
            lblOperacion.Text = "Operación:";
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrimerOperador.Location = new Point(63, 279);
            txtPrimerOperador.Multiline = true;
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.PlaceholderText = "Ingrese el primer número";
            txtPrimerOperador.Size = new Size(226, 32);
            txtPrimerOperador.TabIndex = 0;
            txtPrimerOperador.KeyPress += txtPrimerOperador_KeyPress;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSegundoOperador.Location = new Point(507, 279);
            txtSegundoOperador.Multiline = true;
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.PlaceholderText = "Ingrese el segundo número";
            txtSegundoOperador.Size = new Size(226, 32);
            txtSegundoOperador.TabIndex = 2;
            txtSegundoOperador.KeyPress += txtSegundoOperador_KeyPress;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            grpSistema.Location = new Point(284, 122);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(235, 100);
            grpSistema.TabIndex = 6;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar resultado en:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("ARCO", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(51, 52);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(281, 42);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado:";
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(63, 258);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(128, 18);
            lblPrimerOperador.TabIndex = 0;
            lblPrimerOperador.Text = "Primer operador:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(507, 258);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(145, 18);
            lblSegundoOperador.TabIndex = 2;
            lblSegundoOperador.Text = "Segundo operador:";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblPrimerOperador);
            Controls.Add(lblResultado);
            Controls.Add(grpSistema);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(lblOperacion);
            Controls.Add(cmbOperacion);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimizeBox = false;
            MinimumSize = new Size(816, 489);
            Name = "FrmCalculadora";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Camila Perea";
            FormClosing += FrmCalculadora_FormClosing;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private ComboBox cmbOperacion;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
        private Label lblOperacion;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private GroupBox grpSistema;
        private Label lblResultado;
        private Label lblPrimerOperador;
        private Label lblSegundoOperador;
    }
}