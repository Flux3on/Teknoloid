using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Teknoloid.GameplayElements.NoteObjects
{
    public class RepeatNote : NoteObject
    {
        /// <summary>
        /// An integer array of timestamps that should dictate when to repeatedly tap the note.
        /// </summary>
        public int[] TimeTicks { get; set; }
        public RepeatNote(int[] timestamps, byte y)
        {
            TimeTicks = timestamps;
            Y = y;
            ObjectColor = Color.Purple;
        }
    }
}
