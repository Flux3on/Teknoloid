using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Teknoloid.AudioVisual
{
    public static class SpriteManager
    {
        public static List<Sprite> SpriteList { get; set; }

        public static int DrawSprites(SpriteBatch sb, GameContent gc)
        {
            try
            {
                
                return 0;
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }

    }
}
