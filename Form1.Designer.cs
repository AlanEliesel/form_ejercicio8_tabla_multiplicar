namespace form_ejercicio8_tabla_multiplicar
{
    partial class Form1
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
            this.lst_Tabla_Multiplicar = new System.Windows.Forms.ListBox();
            this.lbl_multi = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Tabla_Multiplicar
            // 
            this.lst_Tabla_Multiplicar.FormattingEnabled = true;
            this.lst_Tabla_Multiplicar.ItemHeight = 20;
            this.lst_Tabla_Multiplicar.Location = new System.Drawing.Point(135, 213);
            this.lst_Tabla_Multiplicar.Name = "lst_Tabla_Multiplicar";
            this.lst_Tabla_Multiplicar.Size = new System.Drawing.Size(331, 284);
            this.lst_Tabla_Multiplicar.TabIndex = 0;
            // 
            // lbl_multi
            // 
            this.lbl_multi.AutoSize = true;
            this.lbl_multi.Location = new System.Drawing.Point(287, 55);
            this.lbl_multi.Name = "lbl_multi";
            this.lbl_multi.Size = new System.Drawing.Size(148, 20);
            this.lbl_multi.TabIndex = 1;
            this.lbl_multi.Text = "Tabla de multiplicar:";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(309, 124);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(157, 26);
            this.txt_num.TabIndex = 2;
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(142, 130);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(147, 20);
            this.lbl_num.TabIndex = 3;
            this.lbl_num.Text = "Ingrese un numero:";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(548, 124);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(148, 45);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(548, 175);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(148, 45);
            this.btn_Limpiar.TabIndex = 5;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(548, 226);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(148, 45);
            this.btn_Cerrar.TabIndex = 6;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 566);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_multi);
            this.Controls.Add(this.lst_Tabla_Multiplicar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Tabla_Multiplicar;
        private System.Windows.Forms.Label lbl_multi;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}

