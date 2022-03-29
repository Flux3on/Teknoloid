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
        /// The X position of the sprite.
        /// </summary>
        public float X { get; set; }
        /// <summary>
        /// The Y position of the sprite.
        /// </summary>
        public float Y { get; set; }
        /// <summary>
        /// The draw layer of the sprite. Higher value = closer to the front of the screen
        /// </summary>
        public int Z { get; set; }
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
        public float Scale { get; set; }

        
        public Sprite(string path, float x, float y)
        {
            // Set parameters
            SpritePath = path;
            X = x;
            Y = y;

            // Set default values
            Anchor = PositionAnchor.Center;
            Z = 0;
            AdditiveColor = Color.White;
            Opacity = 1.0f;
            Scale = 1.0f;
        }
        public Sprite(string path, float x, float y, int z)
        {
            // Set parameters
            SpritePath = path;
            X = x;
            Y = y;
            Z = z;

            // Set default values
            Anchor = PositionAnchor.Center;
            AdditiveColor = Color.White;
            Opacity = 1.0f;
            Scale = 1.0f;
        }
        public Sprite(string path, float x, float y, PositionAnchor anchor)
        {
            // Set parameters
            SpritePath = path;
            X = x;
            Y = y;
            Anchor = anchor;

            // Set default values
            Z = 0;
            AdditiveColor = Color.White;
            Opacity = 1.0f;
            Scale = 1.0f;
        }
        public Sprite(string path, float x, float y, int z, PositionAnchor anchor)
        {
            // Set parameters
            SpritePath = path;
            X = x;
            Y = y;
            Z = z;
            Anchor = anchor;

            // Set default values
            AdditiveColor = Color.White;
            Opacity = 1.0f;
            Scale = 1.0f;
        }
        public Sprite(string path, float x, float y, int z, PositionAnchor anchor, float opacity, float scale, Color acolor)
        {
            // Set parameters
            SpritePath = path;
            X = x;
            Y = y;
            Z = z;
            Anchor = anchor;
            Opacity = opacity;
            Scale = scale;
            AdditiveColor = acolor;
        }


    }
}
