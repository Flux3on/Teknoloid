using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace Teknoloid.AudioVisual
{
    public class Sprite
    {
        /// <summary>
        /// The name of the image file.
        /// </summary>
        public string SpritePath { get; }
        /// <summary>
        /// The PositionAnchor that this sprite should use.
        /// </summary>
        public PositionAnchor Anchor { get; set; }
        /// <summary>
        /// The position of the sprite.
        /// </summary>
        public Vector3 Position { get; set; }
        /// <summary>
        /// idk lmfao who do you think i am, the color witch?
        /// </summary>
        public Color AdditiveColor { get; set; }
        /// <summary>
        /// The opacity of the sprite.
        /// </summary>
        public float Opacity { get; set; }
        /// <summary>
        /// The size of the image.
        /// </summary>
        public Vector2 Scale { get; set; }

        public Sprite(string path, Vector3 pos, PositionAnchor anchor, float opacity, Vector2 scale, Color aColor)
        {
            // Set parameter values
            SpritePath = path;
            Position = pos;
            Anchor = anchor;
            Opacity = opacity;
            Scale = scale;
            AdditiveColor = aColor;
        }

    }
}
