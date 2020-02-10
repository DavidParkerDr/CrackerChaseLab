using Microsoft.Xna.Framework.Graphics;
using System;

namespace CrackerChase
{
    class Target : Sprite
    {

        static Random rand = new Random();
        override public void Reset()
        {
            int x = rand.Next(0, screenWidth - rectangle.Width);
            int y = rand.Next(0, screenHeight - rectangle.Height);
            SetPosition(x, y);
        }

        public Target(int inScreenWidth, int inScreenHeight, Texture2D inSpriteTexture, int inDrawWidth, float inResetX, float inResetY) :
            base(inScreenWidth, inScreenHeight, inSpriteTexture, inDrawWidth, inResetX, inResetY)
        {
        }
    }
}
