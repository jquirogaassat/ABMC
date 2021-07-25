
namespace UI
{
    partial class Socio
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
            this.lbl_nrosoc = new System.Windows.Forms.Label();
            this.txt_nrosoc = new System.Windows.Forms.TextBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.lbl_ape = new System.Windows.Forms.Label();
            this.txt_ape = new System.Windows.Forms.TextBox();
            this.lbl_prov = new System.Windows.Forms.Label();
            this.comb_prov = new System.Windows.Forms.ComboBox();
            this.lbl_cat = new System.Windows.Forms.Label();
            this.comb_cat = new System.Windows.Forms.ComboBox();
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.list_soc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_nrosoc
            // 
            this.lbl_nrosoc.AutoSize = true;
            this.lbl_nrosoc.Location = new System.Drawing.Point(22, 30);
            this.lbl_nrosoc.Name = "lbl_nrosoc";
            this.lbl_nrosoc.Size = new System.Drawing.Size(81, 13);
            this.lbl_nrosoc.TabIndex = 0;
            this.lbl_nrosoc.Text = "Numero de Soc";
            // 
            // txt_nrosoc
            // 
            this.txt_nrosoc.Location = new System.Drawing.Point(133, 27);
            this.txt_nrosoc.Name = "txt_nrosoc";
            this.txt_nrosoc.Size = new System.Drawing.Size(100, 20);
            this.txt_nrosoc.TabIndex = 1;
            this.txt_nrosoc.TextChanged += new System.EventHandler(this.txt_nrosoc_TextChanged);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(22, 77);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(44, 13);
            this.lbl_nom.TabIndex = 2;
            this.lbl_nom.Text = "Nombre";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(133, 70);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(154, 20);
            this.txt_nom.TabIndex = 3;
            // 
            // lbl_ape
            // 
            this.lbl_ape.AutoSize = true;
            this.lbl_ape.Location = new System.Drawing.Point(22, 123);
            this.lbl_ape.Name = "lbl_ape";
            this.lbl_ape.Size = new System.Drawing.Size(44, 13);
            this.lbl_ape.TabIndex = 4;
            this.lbl_ape.Text = "Apellido";
            // 
            // txt_ape
            // 
            this.txt_ape.Location = new System.Drawing.Point(133, 116);
            this.txt_ape.Name = "txt_ape";
            this.txt_ape.Size = new System.Drawing.Size(154, 20);
            this.txt_ape.TabIndex = 5;
            // 
            // lbl_prov
            // 
            this.lbl_prov.AutoSize = true;
            this.lbl_prov.Location = new System.Drawing.Point(22, 176);
            this.lbl_prov.Name = "lbl_prov";
            this.lbl_prov.Size = new System.Drawing.Size(51, 13);
            this.lbl_prov.TabIndex = 6;
            this.lbl_prov.Text = "Provincia";
            // 
            // comb_prov
            // 
            this.comb_prov.FormattingEnabled = true;
            this.comb_prov.Location = new System.Drawing.Point(133, 167);
            this.comb_prov.Name = "comb_prov";
            this.comb_prov.Size = new System.Drawing.Size(154, 21);
            this.comb_prov.TabIndex = 7;
            // 
            // lbl_cat
            // 
            this.lbl_cat.AutoSize = true;
            this.lbl_cat.Location = new System.Drawing.Point(25, 226);
            this.lbl_cat.Name = "lbl_cat";
            this.lbl_cat.Size = new System.Drawing.Size(52, 13);
            this.lbl_cat.TabIndex = 8;
            this.lbl_cat.Text = "Categoria";
            // 
            // comb_cat
            // 
            this.comb_cat.FormattingEnabled = true;
            this.comb_cat.Location = new System.Drawing.Point(133, 226);
            this.comb_cat.Name = "comb_cat";
            this.comb_cat.Size = new System.Drawing.Size(154, 21);
            this.comb_cat.TabIndex = 9;
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(120, 313);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(75, 23);
            this.btn_alta.TabIndex = 10;
            this.btn_alta.Text = "Alta";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(235, 313);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(75, 23);
            this.btn_baja.TabIndex = 11;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.btn_baja_Click);
            // 
            // list_soc
            // 
            this.list_soc.FormattingEnabled = true;
            this.list_soc.Location = new System.Drawing.Point(439, 12);
            this.list_soc.Name = "list_soc";
            this.list_soc.Size = new System.Drawing.Size(349, 199);
            this.list_soc.TabIndex = 12;
            // 
            // Socio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_soc);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.comb_cat);
            this.Controls.Add(this.lbl_cat);
            this.Controls.Add(this.comb_prov);
            this.Controls.Add(this.lbl_prov);
            this.Controls.Add(this.txt_ape);
            this.Controls.Add(this.lbl_ape);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.txt_nrosoc);
            this.Controls.Add(this.lbl_nrosoc);
            this.Name = "Socio";
            this.Text = "Socio";
            this.Load += new System.EventHandler(this.Socio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nrosoc;
        private System.Windows.Forms.TextBox txt_nrosoc;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_ape;
        private System.Windows.Forms.TextBox txt_ape;
        private System.Windows.Forms.Label lbl_prov;
        private System.Windows.Forms.ComboBox comb_prov;
        private System.Windows.Forms.Label lbl_cat;
        private System.Windows.Forms.ComboBox comb_cat;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.ListBox list_soc;
    }
}