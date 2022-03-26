using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Teknoloid.GameplayElements.NoteObjects
{
    public class HoldNote : NoteObject
    {
        /// <summary>
        /// How long, in milliseconds, the note is.
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// How often ticks will appear per beat that verify if the player is holding the object.
        /// </summary>
        public byte TickInterval { get; set; }

        public HoldNote(int timestamp, byte y, int len, byte ticks)
        {
            Timestamp = timestamp;
            Y = y;
            Length = len;
            TickInterval = ticks;
            ObjectColor = Color.Blue;
        }
    }
}
