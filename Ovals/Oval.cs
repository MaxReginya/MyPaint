﻿using System;
using System.Drawing;
using System.Runtime.Serialization;
using Shapes;
using Interfaces;

namespace Ovals
{
    [KnownType(typeof(Oval))]
    [DataContract]
    public class Oval: Shape, IEditable, ISelectable
    {
        public int Height
        {
            get
            {
                return (SecondPoint.Y - FirstPoint.Y);
            }
        }
        public int Width
        {
            get
            {
                return (SecondPoint.X - FirstPoint.X);
            }
        }

        public override void Draw(Graphics drawArea, Pen P, bool shiftPressed)
        {
            if (shiftPressed)
                drawArea.DrawEllipse(P, FirstPoint.X, FirstPoint.Y, Width, Width);
            else
                drawArea.DrawEllipse(P, FirstPoint.X, FirstPoint.Y, Width, Height);
        }
    }
}
