﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom.Custom_Elements
{
    class TextBoxWithPlaceholder : TextBox
    {
        private string PlaceholderTextDefault = string.Empty;
        private Color PlaceholderColorDefault = Color.Gray;

        [Category("Appearance")]
        public string PlaceholderText { get => PlaceholderTextDefault; set => PlaceholderTextDefault = value; }
        [Category("Appearance")]
        public Color PlaceholderColor { get => PlaceholderColorDefault; set => PlaceholderColorDefault = value; }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            if (!DesignMode)
            {
                this.Text = PlaceholderText;
                this.ForeColor = PlaceholderColor;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            if (Text.Equals(string.Empty))
            {
                this.Text = PlaceholderText;
                this.ForeColor = PlaceholderColor;
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            if (Text.Equals(PlaceholderText))
            {
                this.Text = string.Empty;
                this.ForeColor = Color.Black;
            }
        }
    }
}
