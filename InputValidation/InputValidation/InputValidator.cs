﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputValidation
{
    public partial class InputValidator : Form
    {
        public InputValidator()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!InputService.IsValidName(txtName.Text))
            {
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");
            }
            if (!InputService.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("The e-mail address is not valid.");
            }
            if (!InputService.IsValidPhoneNumber(txtPhone.Text))
            {
                MessageBox.Show("The phone number is not a valid US phone number");
            }
            InputService.ReformatPhoneNumber(txtPhone.Text);
        }
    }
}
