using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Teknoloid.GameplayElements.NoteObjects
{
    public abstract class NoteObject
    {
        /// <summary>
        /// The offset in milliseconds that this note should be hit.
        /// </summary>
        protected int Timestamp { get; set; }

        /// <summary>
        /// The vertical position in which this object should appear.
        /// This gets offset by 256 for the upper half of the screen.
        /// </summary>
        protected byte Y { get; set; }

        /// <summary>
        /// The color of the object. Tap = Red, Hold = Blue, Slide = Yellow, Purple = Repeat
        /// </summary>
        protected Color ObjectColor { get; set; }

    }
}
