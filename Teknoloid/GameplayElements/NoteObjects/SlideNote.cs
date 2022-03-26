using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Teknoloid.GameplayElements.NoteObjects
{
    public class SlideNote : NoteObject
    {
        /// <summary>
        /// A byte array of Y positions that should dictate how the slide note waves around.
        /// </summary>
        public byte[] Anchors { get; set; }

        /// <summary>
        /// How often ticks will appear per beat that verify if the player is holding the object.
        /// This will dictate the length of the slide note.
        /// </summary>
        public byte TickInterval { get; set; }

        public SlideNote(int timestamp, byte[] anchors, int len, byte ticks)
        {
            Timestamp = timestamp;
            Anchors = anchors;
            TickInterval = ticks;
            ObjectColor = Color.Yellow;
        }
    }
}
