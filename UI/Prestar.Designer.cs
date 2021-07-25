
namespace UI
{
    partial class Prestar
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.comBoxIsbn = new System.Windows.Forms.ComboBox();
            this.lbl_isbn = new System.Windows.Forms.Label();
            this.lbl_nsoc = new System.Windows.Forms.Label();
            this.comBoxSoc = new System.Windows.Forms.ComboBox();
            this.lbl_fdev = new System.Windows.Forms.Label();
            this.lbl_fpmo = new System.Windows.Forms.Label();
            this.date_pmo = new System.Windows.Forms.DateTimePicker();
            this.date_dev = new System.Windows.Forms.DateTimePicker();
            this.btn_prestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(96, 32);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(113, 20);
            this.txt_id.TabIndex = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(12, 39);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID";
            // 
            // comBoxIsbn
            // 
            this.comBoxIsbn.FormattingEnabled = true;
            this.comBoxIsbn.Location = new System.Drawing.Point(96, 91);
            this.comBoxIsbn.Name = "comBoxIsbn";
            this.comBoxIsbn.Size = new System.Drawing.Size(113, 21);
            this.comBoxIsbn.TabIndex = 2;
            // 
            // lbl_isbn
            // 
            this.lbl_isbn.AutoSize = true;
            this.lbl_isbn.Location = new System.Drawing.Point(12, 99);
            this.lbl_isbn.Name = "lbl_isbn";
            this.lbl_isbn.Size = new System.Drawing.Size(67, 13);
            this.lbl_isbn.TabIndex = 3;
            this.lbl_isbn.Text = "Lista de Isbn";
            // 
            // lbl_nsoc
            // 
            this.lbl_nsoc.AutoSize = true;
            this.lbl_nsoc.Location = new System.Drawing.Point(380, 39);
            this.lbl_nsoc.Name = "lbl_nsoc";
            this.lbl_nsoc.Size = new System.Drawing.Size(85, 13);
            this.lbl_nsoc.TabIndex = 4;
            this.lbl_nsoc.Text = "numero de socio";
            // 
            // comBoxSoc
            // 
            this.comBoxSoc.FormattingEnabled = true;
            this.comBoxSoc.Location = new System.Drawing.Point(542, 31);
            this.comBoxSoc.Name = "comBoxSoc";
            this.comBoxSoc.Size = new System.Drawing.Size(113, 21);
            this.comBoxSoc.TabIndex = 5;
            this.comBoxSoc.SelectedIndexChanged += new System.EventHandler(this.comBoxSoc_SelectedIndexChanged);
            // 
            // lbl_fdev
            // 
            this.lbl_fdev.AutoSize = true;
            this.lbl_fdev.Location = new System.Drawing.Point(380, 257);
            this.lbl_fdev.Name = "lbl_fdev";
            this.lbl_fdev.Size = new System.Drawing.Size(104, 13);
            this.lbl_fdev.TabIndex = 6;
            this.lbl_fdev.Text = "fecha de devolucion";
            // 
            // lbl_fpmo
            // 
            this.lbl_fpmo.AutoSize = true;
            this.lbl_fpmo.Location = new System.Drawing.Point(380, 150);
            this.lbl_fpmo.Name = "lbl_fpmo";
            this.lbl_fpmo.Size = new System.Drawing.Size(72, 13);
            this.lbl_fpmo.TabIndex = 7;
            this.lbl_fpmo.Text = "fecha de pmo";
            // 
            // date_pmo
            // 
            this.date_pmo.Location = new System.Drawing.Point(520, 143);
            this.date_pmo.Name = "date_pmo";
            this.date_pmo.Size = new System.Drawing.Size(226, 20);
            this.date_pmo.TabIndex = 8;
            this.date_pmo.ValueChanged += new System.EventHandler(this.date_pmo_ValueChanged);
            // 
            // date_dev
            // 
            this.date_dev.Location = new System.Drawing.Point(520, 250);
            this.date_dev.Name = "date_dev";
            this.date_dev.Size = new System.Drawing.Size(226, 20);
            this.date_dev.TabIndex = 9;
            this.date_dev.ValueChanged += new System.EventHandler(this.date_dev_ValueChanged);
            // 
            // btn_prestar
            // 
            this.btn_prestar.Location = new System.Drawing.Point(580, 360);
            this.btn_prestar.Name = "btn_prestar";
            this.btn_prestar.Size = new System.Drawing.Size(75, 23);
            this.btn_prestar.TabIndex = 10;
            this.btn_prestar.Text = "prestamo";
            this.btn_prestar.UseVisualStyleBackColor = true;
            this.btn_prestar.Click += new System.EventHandler(this.btn_prestar_Click);
            // 
            // Prestar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_prestar);
            this.Controls.Add(this.date_dev);
            this.Controls.Add(this.date_pmo);
            this.Controls.Add(this.lbl_fpmo);
            this.Controls.Add(this.lbl_fdev);
            this.Controls.Add(this.comBoxSoc);
            this.Controls.Add(this.lbl_nsoc);
            this.Controls.Add(this.lbl_isbn);
            this.Controls.Add(this.comBoxIsbn);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txt_id);
            this.Name = "Prestar";
            this.Text = "Prestar";
            this.Load += new System.EventHandler(this.Prestar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.ComboBox comBoxIsbn;
        private System.Windows.Forms.Label lbl_isbn;
        private System.Windows.Forms.Label lbl_nsoc;
        private System.Windows.Forms.ComboBox comBoxSoc;
        private System.Windows.Forms.Label lbl_fdev;
        private System.Windows.Forms.Label lbl_fpmo;
        private System.Windows.Forms.DateTimePicker date_pmo;
        private System.Windows.Forms.DateTimePicker date_dev;
        private System.Windows.Forms.Button btn_prestar;
    }
}