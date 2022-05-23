using System;
using System.Windows.Forms;

namespace Lab4MTP
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
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxDimensComplet = new System.Windows.Forms.PictureBox();
            this.txtDetalii = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.pacientiDataGridView = new System.Windows.Forms.DataGridView();
            this.radiografiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientDataSet = new Lab4MTP.PacientDataSet();
            this.pacientiTableAdapter = new Lab4MTP.PacientDataSetTableAdapters.PacientiTableAdapter();
            this.tableAdapterManager = new Lab4MTP.PacientDataSetTableAdapters.TableAdapterManager();
            this.radiografiiTableAdapter = new Lab4MTP.PacientDataSetTableAdapters.RadiografiiTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDimensComplet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(57, 393);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(172, 23);
            this.btnSalveaza.TabIndex = 0;
            this.btnSalveaza.Text = "Salveaza modificari";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(290, 392);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(153, 23);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "Adauga radiografie";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(449, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(191, 426);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picBoxDimensComplet);
            this.panel1.Location = new System.Drawing.Point(668, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 316);
            this.panel1.TabIndex = 3;
            // 
            // picBoxDimensComplet
            // 
            this.picBoxDimensComplet.Location = new System.Drawing.Point(15, 27);
            this.picBoxDimensComplet.Name = "picBoxDimensComplet";
            this.picBoxDimensComplet.Size = new System.Drawing.Size(391, 214);
            this.picBoxDimensComplet.TabIndex = 0;
            this.picBoxDimensComplet.TabStop = false;
            // 
            // txtDetalii
            // 
            this.txtDetalii.Enabled = false;
            this.txtDetalii.Location = new System.Drawing.Point(668, 334);
            this.txtDetalii.Multiline = true;
            this.txtDetalii.Name = "txtDetalii";
            this.txtDetalii.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalii.Size = new System.Drawing.Size(453, 139);
            this.txtDetalii.TabIndex = 4;
            this.txtDetalii.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cautare dupa nume";
            // 
            // txtCautare
            // 
            this.txtCautare.Location = new System.Drawing.Point(174, 39);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(147, 22);
            this.txtCautare.TabIndex = 6;
            this.txtCautare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCautare_KeyDown);
            // 
            // pacientiDataGridView
            // 
            this.pacientiDataGridView.AutoGenerateColumns = false;
            this.pacientiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pacientiDataGridView.DataSource = this.pacientiBindingSource;
            this.pacientiDataGridView.Location = new System.Drawing.Point(37, 77);
            this.pacientiDataGridView.Name = "pacientiDataGridView";
            this.pacientiDataGridView.RowTemplate.Height = 24;
            this.pacientiDataGridView.Size = new System.Drawing.Size(353, 255);
            this.pacientiDataGridView.TabIndex = 8;
            this.pacientiDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientiDataGridView_CellClick);
            // 
            // radiografiiBindingSource
            // 
            this.radiografiiBindingSource.DataMember = "FK__Radiografii__CNP__25869641";
            this.radiografiiBindingSource.DataSource = this.pacientiBindingSource;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CNP";
            this.dataGridViewTextBoxColumn1.HeaderText = "CNP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // pacientiBindingSource
            // 
            this.pacientiBindingSource.DataMember = "Pacienti";
            this.pacientiBindingSource.DataSource = this.pacientDataSet;
            // 
            // pacientDataSet
            // 
            this.pacientDataSet.DataSetName = "PacientDataSet";
            this.pacientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientiTableAdapter
            // 
            this.pacientiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacientiTableAdapter = this.pacientiTableAdapter;
            this.tableAdapterManager.RadiografiiTableAdapter = this.radiografiiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lab4MTP.PacientDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // radiografiiTableAdapter
            // 
            this.radiografiiTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 544);
            this.Controls.Add(this.pacientiDataGridView);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetalii);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnSalveaza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDimensComplet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pacientiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowImages();
        }

        #endregion

        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBoxDimensComplet;
        private System.Windows.Forms.TextBox txtDetalii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCautare;
        private PacientDataSet pacientDataSet;
        private System.Windows.Forms.BindingSource pacientiBindingSource;
        private PacientDataSetTableAdapters.PacientiTableAdapter pacientiTableAdapter;
        private PacientDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pacientiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private PacientDataSetTableAdapters.RadiografiiTableAdapter radiografiiTableAdapter;
        private System.Windows.Forms.BindingSource radiografiiBindingSource;
    }
}

