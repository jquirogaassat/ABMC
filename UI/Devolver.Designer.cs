
namespace UI
{
    partial class Devolver
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
            this.listPmo = new System.Windows.Forms.ListBox();
            this.devuelto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPmo
            // 
            this.listPmo.FormattingEnabled = true;
            this.listPmo.Location = new System.Drawing.Point(12, 12);
            this.listPmo.Name = "listPmo";
            this.listPmo.Size = new System.Drawing.Size(236, 238);
            this.listPmo.TabIndex = 0;
            this.listPmo.SelectedIndexChanged += new System.EventHandler(this.listPmo_SelectedIndexChanged);
            // 
            // devuelto
            // 
            this.devuelto.Location = new System.Drawing.Point(410, 213);
            this.devuelto.Name = "devuelto";
            this.devuelto.Size = new System.Drawing.Size(168, 36);
            this.devuelto.TabIndex = 1;
            this.devuelto.Text = "devolver";
            this.devuelto.UseVisualStyleBackColor = true;
            this.devuelto.Click += new System.EventHandler(this.button1_Click);
            // 
            // Devolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.devuelto);
            this.Controls.Add(this.listPmo);
            this.Name = "Devolver";
            this.Text = "Devolver";
            this.Load += new System.EventHandler(this.Devolver_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listPmo;
        private System.Windows.Forms.Button devuelto;
    }
}