
namespace Empleados
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
            this.components = new System.ComponentModel.Container();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDUI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbDUI = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(638, 30);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.LightCyan;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNombre.Location = new System.Drawing.Point(110, 85);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(64, 17);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDUI
            // 
            this.labelDUI.AutoSize = true;
            this.labelDUI.BackColor = System.Drawing.Color.Azure;
            this.labelDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDUI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDUI.Location = new System.Drawing.Point(110, 127);
            this.labelDUI.Name = "labelDUI";
            this.labelDUI.Size = new System.Drawing.Size(34, 17);
            this.labelDUI.TabIndex = 2;
            this.labelDUI.Text = "DUI";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(175, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.Color.White;
            this.txtDUI.Location = new System.Drawing.Point(174, 127);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 5;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(143, 272);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(80, 24);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.BackColor = System.Drawing.Color.Maroon;
            this.labelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRegistro.Location = new System.Drawing.Point(369, 194);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(0, 17);
            this.labelRegistro.TabIndex = 7;
            this.labelRegistro.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(174, 194);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(110, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Salario";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(175, 159);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(110, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "AFP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(395, 270);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = " Registro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.Color.LightCyan;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbname.Location = new System.Drawing.Point(625, 108);
            this.lbname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(0, 13);
            this.lbname.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(658, 229);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(674, 253);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbDUI
            // 
            this.lbDUI.AutoSize = true;
            this.lbDUI.BackColor = System.Drawing.Color.Azure;
            this.lbDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDUI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDUI.Location = new System.Drawing.Point(625, 145);
            this.lbDUI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDUI.Name = "lbDUI";
            this.lbDUI.Size = new System.Drawing.Size(0, 13);
            this.lbDUI.TabIndex = 17;
            this.lbDUI.Click += new System.EventHandler(this.lbDUI_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Haga click en el boton registro para guardar los datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(823, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDUI);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAFP);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelDUI);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelID);
            this.Name = "Form1";
            this.Text = "Registro de empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDUI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbDUI;
        private System.Windows.Forms.Label label3;
    }
}

