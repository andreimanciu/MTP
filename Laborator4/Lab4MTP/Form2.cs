﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4MTP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(String CNP)
        {
            InitializeComponent();
            txtCNP.Text = CNP;
        }

        public string CNP { get { return txtCNP.Text;  } }
        public DateTime Data { get { return dateTimePicker1.Value; } }
        public string Imagine { get { return txtImagine.Text; } }
        public string Diagnostic { get { return txtDiagnostic.Text; } }
        public string Comentarii { get { return txtComentarii.Text; } }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Form1.imgFolder;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtImagine.Text = GetFileName(dlg.FileName);
            }

        }

        private string GetFileName(string path)
        {
            string[] splitChars = new string[] { "\\" };
            string[] result = path.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
            return result[result.GetLength(0) - 1];
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
