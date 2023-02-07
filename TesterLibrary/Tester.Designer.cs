
namespace TesterLibrary
{
    partial class frmTester
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
            this.grbNumeros = new System.Windows.Forms.GroupBox();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.tabFill = new System.Windows.Forms.TabControl();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.tabPageDialogos = new System.Windows.Forms.TabPage();
            this.grbPregunta = new System.Windows.Forms.GroupBox();
            this.btnPregunta = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.grbNumeros.SuspendLayout();
            this.tabFill.SuspendLayout();
            this.tabPageText.SuspendLayout();
            this.tabPageDialogos.SuspendLayout();
            this.grbPregunta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNumeros
            // 
            this.grbNumeros.Controls.Add(this.lblNumeros);
            this.grbNumeros.Controls.Add(this.txtNumeros);
            this.grbNumeros.Location = new System.Drawing.Point(6, 14);
            this.grbNumeros.Name = "grbNumeros";
            this.grbNumeros.Size = new System.Drawing.Size(116, 64);
            this.grbNumeros.TabIndex = 0;
            this.grbNumeros.TabStop = false;
            this.grbNumeros.Text = "Números";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(6, 36);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(100, 20);
            this.txtNumeros.TabIndex = 0;
            this.txtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Location = new System.Drawing.Point(7, 20);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(74, 13);
            this.lblNumeros.TabIndex = 1;
            this.lblNumeros.Text = "Sólo números:";
            // 
            // tabFill
            // 
            this.tabFill.Controls.Add(this.tabPageText);
            this.tabFill.Controls.Add(this.tabPageDialogos);
            this.tabFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFill.Location = new System.Drawing.Point(0, 0);
            this.tabFill.Name = "tabFill";
            this.tabFill.SelectedIndex = 0;
            this.tabFill.Size = new System.Drawing.Size(532, 277);
            this.tabFill.TabIndex = 1;
            // 
            // tabPageText
            // 
            this.tabPageText.Controls.Add(this.grbNumeros);
            this.tabPageText.Location = new System.Drawing.Point(4, 22);
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageText.Size = new System.Drawing.Size(524, 251);
            this.tabPageText.TabIndex = 0;
            this.tabPageText.Text = "Textos";
            this.tabPageText.UseVisualStyleBackColor = true;
            // 
            // tabPageDialogos
            // 
            this.tabPageDialogos.Controls.Add(this.grbPregunta);
            this.tabPageDialogos.Location = new System.Drawing.Point(4, 22);
            this.tabPageDialogos.Name = "tabPageDialogos";
            this.tabPageDialogos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDialogos.Size = new System.Drawing.Size(524, 251);
            this.tabPageDialogos.TabIndex = 1;
            this.tabPageDialogos.Text = "Dialogos";
            this.tabPageDialogos.UseVisualStyleBackColor = true;
            // 
            // grbPregunta
            // 
            this.grbPregunta.Controls.Add(this.txtRespuesta);
            this.grbPregunta.Controls.Add(this.btnPregunta);
            this.grbPregunta.Controls.Add(this.lblRespuesta);
            this.grbPregunta.Location = new System.Drawing.Point(8, 6);
            this.grbPregunta.Name = "grbPregunta";
            this.grbPregunta.Size = new System.Drawing.Size(133, 89);
            this.grbPregunta.TabIndex = 1;
            this.grbPregunta.TabStop = false;
            this.grbPregunta.Text = "Pregunta";
            // 
            // btnPregunta
            // 
            this.btnPregunta.Location = new System.Drawing.Point(6, 19);
            this.btnPregunta.Name = "btnPregunta";
            this.btnPregunta.Size = new System.Drawing.Size(121, 23);
            this.btnPregunta.TabIndex = 2;
            this.btnPregunta.Text = "Pregunta";
            this.btnPregunta.UseVisualStyleBackColor = true;
            this.btnPregunta.Click += new System.EventHandler(this.btnPregunta_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(6, 45);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(61, 13);
            this.lblRespuesta.TabIndex = 1;
            this.lblRespuesta.Text = "Respuesta:";
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(7, 62);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(120, 20);
            this.txtRespuesta.TabIndex = 3;
            // 
            // frmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 277);
            this.Controls.Add(this.tabFill);
            this.Name = "frmTester";
            this.Text = "Tester";
            this.grbNumeros.ResumeLayout(false);
            this.grbNumeros.PerformLayout();
            this.tabFill.ResumeLayout(false);
            this.tabPageText.ResumeLayout(false);
            this.tabPageDialogos.ResumeLayout(false);
            this.grbPregunta.ResumeLayout(false);
            this.grbPregunta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNumeros;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.TabControl tabFill;
        private System.Windows.Forms.TabPage tabPageText;
        private System.Windows.Forms.TabPage tabPageDialogos;
        private System.Windows.Forms.GroupBox grbPregunta;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.Button btnPregunta;
        private System.Windows.Forms.Label lblRespuesta;
    }
}

