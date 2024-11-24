namespace WinFormsTabla
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
            panelPrincipal = new Panel();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            labelNombre = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.Thistle;
            panelPrincipal.Controls.Add(labelNombre);
            panelPrincipal.Controls.Add(richTextBoxResultados);
            panelPrincipal.Controls.Add(buttonVer);
            panelPrincipal.Controls.Add(textBoxNum);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Location = new Point(12, 12);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1301, 787);
            panelPrincipal.TabIndex = 0;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBoxResultados.Location = new Point(679, 134);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(333, 476);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.BackColor = Color.Plum;
            buttonVer.Location = new Point(273, 379);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(112, 34);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver Tabla\r\n";
            buttonVer.UseVisualStyleBackColor = false;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(127, 314);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(390, 31);
            textBoxNum.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumero.Location = new Point(91, 229);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(482, 50);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "¿Cual tabla quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Old English Text MT", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(353, 24);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(395, 53);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Tabla de multiplicar";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(624, 708);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(486, 38);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Gabriela Atenea González Medina";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 811);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelNumero;
        private Label labelTitulo;
        private RichTextBox richTextBoxResultados;
        private Button buttonVer;
        private TextBox textBoxNum;
        private Label labelNombre;
    }
}
