
namespace UI
{
    partial class MaterialBilbiografico
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
            this.listMatBib = new System.Windows.Forms.ListBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comBoxEs = new System.Windows.Forms.ComboBox();
            this.comBoxTip = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtBoxIsbn = new System.Windows.Forms.TextBox();
            this.txtBoxAutor = new System.Windows.Forms.TextBox();
            this.txtBoxHojas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listMatBib
            // 
            this.listMatBib.FormattingEnabled = true;
            this.listMatBib.Location = new System.Drawing.Point(426, 2);
            this.listMatBib.Name = "listMatBib";
            this.listMatBib.Size = new System.Drawing.Size(362, 394);
            this.listMatBib.TabIndex = 0;
            this.listMatBib.SelectedIndexChanged += new System.EventHandler(this.listMatBib_SelectedIndexChanged);
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(25, 57);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(32, 13);
            this.ISBN.TabIndex = 1;
            this.ISBN.Text = "ISBN";
            this.ISBN.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "AUTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ESTADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "HOJAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "TIPO";
            // 
            // comBoxEs
            // 
            this.comBoxEs.FormattingEnabled = true;
            this.comBoxEs.Location = new System.Drawing.Point(92, 182);
            this.comBoxEs.Name = "comBoxEs";
            this.comBoxEs.Size = new System.Drawing.Size(121, 21);
            this.comBoxEs.TabIndex = 9;
            this.comBoxEs.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comBoxTip
            // 
            this.comBoxTip.FormattingEnabled = true;
            this.comBoxTip.Location = new System.Drawing.Point(92, 264);
            this.comBoxTip.Name = "comBoxTip";
            this.comBoxTip.Size = new System.Drawing.Size(121, 21);
            this.comBoxTip.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(317, 267);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(317, 311);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtBoxIsbn
            // 
            this.txtBoxIsbn.Location = new System.Drawing.Point(92, 50);
            this.txtBoxIsbn.Name = "txtBoxIsbn";
            this.txtBoxIsbn.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIsbn.TabIndex = 13;
            this.txtBoxIsbn.TextChanged += new System.EventHandler(this.txtBoxIsbn_TextChanged);
            // 
            // txtBoxAutor
            // 
            this.txtBoxAutor.Location = new System.Drawing.Point(92, 98);
            this.txtBoxAutor.Name = "txtBoxAutor";
            this.txtBoxAutor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAutor.TabIndex = 14;
            // 
            // txtBoxHojas
            // 
            this.txtBoxHojas.Location = new System.Drawing.Point(92, 142);
            this.txtBoxHojas.Name = "txtBoxHojas";
            this.txtBoxHojas.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHojas.TabIndex = 15;
            this.txtBoxHojas.TextChanged += new System.EventHandler(this.txtBoxHojas_TextChanged);
            // 
            // MaterialBilbiografico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxHojas);
            this.Controls.Add(this.txtBoxAutor);
            this.Controls.Add(this.txtBoxIsbn);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comBoxTip);
            this.Controls.Add(this.comBoxEs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.listMatBib);
            this.Name = "MaterialBilbiografico";
            this.Text = "MaterialBilbiografico";
            this.Load += new System.EventHandler(this.MaterialBilbiografico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMatBib;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comBoxEs;
        private System.Windows.Forms.ComboBox comBoxTip;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtBoxIsbn;
        private System.Windows.Forms.TextBox txtBoxAutor;
        private System.Windows.Forms.TextBox txtBoxHojas;
    }
}