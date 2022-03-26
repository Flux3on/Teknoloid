using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Teknoloid.GameplayElements.NoteObjects
{
    public class TapNote : NoteObject
    {
        public TapNote(int timestamp, byte y)
        {
            Timestamp = timestamp;
            Y = y;
            ObjectColor = Color.Red;
        }
    }
}
