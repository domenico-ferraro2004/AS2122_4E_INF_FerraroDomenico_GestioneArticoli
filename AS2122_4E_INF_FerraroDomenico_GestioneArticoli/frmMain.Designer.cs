namespace AS2122_4E_INF_FerraroDomenico_GestioneArticoli
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
            this.cmbUnitaMisura = new System.Windows.Forms.ComboBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.cmbVisualizza = new System.Windows.Forms.ComboBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.lstVisualizza = new System.Windows.Forms.ListBox();
            this.grbGestioneArticoli = new System.Windows.Forms.GroupBox();
            this.lblArticoli = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbGestioneArticoli.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUnitaMisura
            // 
            this.cmbUnitaMisura.FormattingEnabled = true;
            this.cmbUnitaMisura.Location = new System.Drawing.Point(199, 120);
            this.cmbUnitaMisura.Name = "cmbUnitaMisura";
            this.cmbUnitaMisura.Size = new System.Drawing.Size(121, 23);
            this.cmbUnitaMisura.TabIndex = 1;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(199, 51);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 23);
            this.txtCodice.TabIndex = 2;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(199, 84);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(100, 23);
            this.txtDescrizione.TabIndex = 3;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(199, 156);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(100, 23);
            this.txtPrezzo.TabIndex = 4;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(91, 234);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(183, 39);
            this.btnAggiungi.TabIndex = 5;
            this.btnAggiungi.Text = "Aggiungi/Modifica Articolo";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            // 
            // cmbVisualizza
            // 
            this.cmbVisualizza.FormattingEnabled = true;
            this.cmbVisualizza.Location = new System.Drawing.Point(480, 54);
            this.cmbVisualizza.Name = "cmbVisualizza";
            this.cmbVisualizza.Size = new System.Drawing.Size(200, 23);
            this.cmbVisualizza.TabIndex = 6;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(712, 54);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(33, 23);
            this.btnVisualizza.TabIndex = 7;
            this.btnVisualizza.Text = "...";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            // 
            // lstVisualizza
            // 
            this.lstVisualizza.FormattingEnabled = true;
            this.lstVisualizza.ItemHeight = 15;
            this.lstVisualizza.Location = new System.Drawing.Point(480, 86);
            this.lstVisualizza.Name = "lstVisualizza";
            this.lstVisualizza.Size = new System.Drawing.Size(265, 289);
            this.lstVisualizza.TabIndex = 8;
            // 
            // grbGestioneArticoli
            // 
            this.grbGestioneArticoli.Controls.Add(this.label6);
            this.grbGestioneArticoli.Controls.Add(this.label5);
            this.grbGestioneArticoli.Controls.Add(this.label4);
            this.grbGestioneArticoli.Controls.Add(this.label3);
            this.grbGestioneArticoli.Controls.Add(this.btnAggiungi);
            this.grbGestioneArticoli.Controls.Add(this.txtPrezzo);
            this.grbGestioneArticoli.Controls.Add(this.txtCodice);
            this.grbGestioneArticoli.Controls.Add(this.cmbUnitaMisura);
            this.grbGestioneArticoli.Controls.Add(this.txtDescrizione);
            this.grbGestioneArticoli.Location = new System.Drawing.Point(21, 30);
            this.grbGestioneArticoli.Name = "grbGestioneArticoli";
            this.grbGestioneArticoli.Size = new System.Drawing.Size(392, 292);
            this.grbGestioneArticoli.TabIndex = 9;
            this.grbGestioneArticoli.TabStop = false;
            this.grbGestioneArticoli.Text = "Gestione Articoli";
            // 
            // lblArticoli
            // 
            this.lblArticoli.AutoSize = true;
            this.lblArticoli.Location = new System.Drawing.Point(60, 399);
            this.lblArticoli.Name = "lblArticoli";
            this.lblArticoli.Size = new System.Drawing.Size(16, 15);
            this.lblArticoli.TabIndex = 10;
            this.lblArticoli.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descrizione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unità di misura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Prezzo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArticoli);
            this.Controls.Add(this.grbGestioneArticoli);
            this.Controls.Add(this.lstVisualizza);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.cmbVisualizza);
            this.Name = "Form1";
            this.Text = "Ferraro Domenico; Lab2.2 18/05/2022;Prova Singola Gestione di articoli";
            this.grbGestioneArticoli.ResumeLayout(false);
            this.grbGestioneArticoli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbUnitaMisura;
        private TextBox txtCodice;
        private TextBox txtDescrizione;
        private TextBox txtPrezzo;
        private Button btnAggiungi;
        private ComboBox cmbVisualizza;
        private Button btnVisualizza;
        private ListBox lstVisualizza;
        private GroupBox grbGestioneArticoli;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblArticoli;
    }
}