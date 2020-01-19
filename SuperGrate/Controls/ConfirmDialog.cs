﻿using System.Drawing;
using System.Windows.Forms;

namespace SuperGrate.Controls
{
    public partial class ConfirmDialog : Form
    {
        public ConfirmDialog(string DialogTitle, string DialogDescription = null, Icon DialogIcon = null)
        {
            InitializeComponent();
            if (DialogDescription == null) DialogDescription = DialogTitle;
            if (DialogIcon == null)
            {
                Icon = Properties.Resources.question;
                Bitmap icon = Properties.Resources.question_32.ToBitmap();
                pbIcon.Image = icon;
            }
            else
            {
                Icon = DialogIcon;
                pbIcon.Image = new Icon(DialogIcon, 32, 32).ToBitmap();
            }
            Text = DialogTitle;
            lblDescription.Text = DialogDescription;
        }
    }
}