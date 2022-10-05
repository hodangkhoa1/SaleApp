﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp
{
    public class GradientBackground : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }
        public float Angle { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush = new(this.ClientRectangle, this.ColorTop, this.ColorBottom, this.Angle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
