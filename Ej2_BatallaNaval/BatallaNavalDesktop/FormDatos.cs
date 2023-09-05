﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatallaNavalDesktop
{
    public partial class FormDatos : Form
    {
        public FormDatos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool isNoOk = false;

            if (string.IsNullOrEmpty(tbNombre.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbNombre.BackColor = Color.Orange;
            }

            if (isNoOk == false)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.None;
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            tbNombre.BackColor = Color.White;
        }

    }
}
