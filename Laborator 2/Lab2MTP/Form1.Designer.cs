namespace Lab2MTP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxPersoana = new System.Windows.Forms.GroupBox();
            this.adauga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataNastere = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.nume = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tvwAgenda = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pgdAgenda = new System.Windows.Forms.PropertyGrid();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnIncarcare = new System.Windows.Forms.Button();
            this.groupBoxPersoana.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPersoana
            // 
            this.groupBoxPersoana.Controls.Add(this.adauga);
            this.groupBoxPersoana.Controls.Add(this.label3);
            this.groupBoxPersoana.Controls.Add(this.txtAdresa);
            this.groupBoxPersoana.Controls.Add(this.cmbCategorie);
            this.groupBoxPersoana.Controls.Add(this.txtTelefon);
            this.groupBoxPersoana.Controls.Add(this.label2);
            this.groupBoxPersoana.Controls.Add(this.label1);
            this.groupBoxPersoana.Controls.Add(this.dateTimePicker1);
            this.groupBoxPersoana.Controls.Add(this.dataNastere);
            this.groupBoxPersoana.Controls.Add(this.txtNume);
            this.groupBoxPersoana.Controls.Add(this.nume);
            this.groupBoxPersoana.Location = new System.Drawing.Point(35, 19);
            this.groupBoxPersoana.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPersoana.Name = "groupBoxPersoana";
            this.groupBoxPersoana.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPersoana.Size = new System.Drawing.Size(302, 163);
            this.groupBoxPersoana.TabIndex = 0;
            this.groupBoxPersoana.TabStop = false;
            this.groupBoxPersoana.Text = "Persoana";
            // 
            // adauga
            // 
            this.adauga.Location = new System.Drawing.Point(214, 105);
            this.adauga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adauga.Name = "adauga";
            this.adauga.Size = new System.Drawing.Size(69, 43);
            this.adauga.TabIndex = 11;
            this.adauga.Text = "Adauga";
            this.adauga.UseVisualStyleBackColor = true;
            this.adauga.Click += new System.EventHandler(this.adauga_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Categorie";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(79, 102);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(102, 20);
            this.txtAdresa.TabIndex = 9;
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Items.AddRange(new object[] {
            "Prieteni",
            "Colegi",
            "Rude",
            "Diversi"});
            this.cmbCategorie.Location = new System.Drawing.Point(79, 129);
            this.cmbCategorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(102, 21);
            this.cmbCategorie.TabIndex = 8;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(79, 75);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(102, 20);
            this.txtTelefon.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Telefon";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 47);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dataNastere
            // 
            this.dataNastere.AutoSize = true;
            this.dataNastere.Location = new System.Drawing.Point(5, 47);
            this.dataNastere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataNastere.Name = "dataNastere";
            this.dataNastere.Size = new System.Drawing.Size(69, 13);
            this.dataNastere.TabIndex = 2;
            this.dataNastere.Text = " Data nasterii";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(79, 18);
            this.txtNume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(102, 20);
            this.txtNume.TabIndex = 1;
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Location = new System.Drawing.Point(40, 18);
            this.nume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(35, 13);
            this.nume.TabIndex = 0;
            this.nume.Text = "Nume";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCauta);
            this.groupBox1.Controls.Add(this.txtCautare);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(395, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(196, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cautare";
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(122, 79);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(69, 22);
            this.btnCauta.TabIndex = 12;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(7, 54);
            this.txtCautare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(186, 20);
            this.txtCautare.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nume";
            // 
            // tvwAgenda
            // 
            this.tvwAgenda.ImageIndex = 0;
            this.tvwAgenda.ImageList = this.imageList1;
            this.tvwAgenda.Location = new System.Drawing.Point(35, 209);
            this.tvwAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvwAgenda.Name = "tvwAgenda";
            this.tvwAgenda.SelectedImageIndex = 0;
            this.tvwAgenda.Size = new System.Drawing.Size(187, 202);
            this.tvwAgenda.TabIndex = 2;
            this.tvwAgenda.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwAgenda_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "prieteni.png");
            this.imageList1.Images.SetKeyName(2, "colegi.png");
            this.imageList1.Images.SetKeyName(3, "rude.png");
            this.imageList1.Images.SetKeyName(4, "question.png");
            // 
            // pgdAgenda
            // 
            this.pgdAgenda.Location = new System.Drawing.Point(325, 206);
            this.pgdAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pgdAgenda.Name = "pgdAgenda";
            this.pgdAgenda.Size = new System.Drawing.Size(266, 205);
            this.pgdAgenda.TabIndex = 3;
            this.pgdAgenda.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgdAgenda_PropertyValueChanged);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(35, 426);
            this.btnSalveaza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(118, 19);
            this.btnSalveaza.TabIndex = 4;
            this.btnSalveaza.Text = "Salveaza in fisier";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(526, 426);
            this.btnSterge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(69, 19);
            this.btnSterge.TabIndex = 5;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnIncarcare
            // 
            this.btnIncarcare.Location = new System.Drawing.Point(325, 426);
            this.btnIncarcare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIncarcare.Name = "btnIncarcare";
            this.btnIncarcare.Size = new System.Drawing.Size(130, 19);
            this.btnIncarcare.TabIndex = 6;
            this.btnIncarcare.Text = "Incarcare din fisier";
            this.btnIncarcare.UseVisualStyleBackColor = true;
            this.btnIncarcare.Click += new System.EventHandler(this.btnIncarcare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 467);
            this.Controls.Add(this.btnIncarcare);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.pgdAgenda);
            this.Controls.Add(this.tvwAgenda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxPersoana);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPersoana.ResumeLayout(false);
            this.groupBoxPersoana.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersoana;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dataNastere;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label nume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adauga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView tvwAgenda;
        private System.Windows.Forms.PropertyGrid pgdAgenda;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnIncarcare;
    }
}

