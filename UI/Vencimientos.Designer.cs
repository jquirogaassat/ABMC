
namespace UI
{
    partial class Vencimientos
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
            this.list_vencimientos = new System.Windows.Forms.ListBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_vencimientos
            // 
            this.list_vencimientos.FormattingEnabled = true;
            this.list_vencimientos.Location = new System.Drawing.Point(426, 12);
            this.list_vencimientos.Name = "list_vencimientos";
            this.list_vencimientos.Size = new System.Drawing.Size(374, 381);
            this.list_vencimientos.TabIndex = 0;
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(138, 57);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(75, 23);
            this.btn_consulta.TabIndex = 1;
            this.btn_consulta.Text = "Consultar";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // Vencimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.list_vencimientos);
            this.Name = "Vencimientos";
            this.Text = "Vencimientos";
            this.Load += new System.EventHandler(this.Vencimientos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_vencimientos;
        private System.Windows.Forms.Button btn_consulta;
    }
}