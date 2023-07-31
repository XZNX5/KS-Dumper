﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DarkControls.Controls
{
    public class DarkButton : Button
    {
        public DarkButton()
        {
            this.BackColor = Color.FromArgb(33, 33, 33);
            this.ForeColor = Color.Silver;

            this.Size = new Size(75, 23);
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UseVisualStyleBackColor = true;
        }
    }
}
