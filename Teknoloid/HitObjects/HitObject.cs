using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Teknoloid.HitObjects
{
    public class HitObject
    {
        public const float OBJECT_RADIUS = 64;
        public int timestamp;
        public double radiusMultiplier;
        public Color ObjectColor;
        public int leniency;


        public HitObject()
        {

        }

    }
}
