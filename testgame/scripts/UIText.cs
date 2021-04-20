﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace testgame.scripts
{
    class UIText : UIElement
    {
        public string text;

        public SpriteFont Font { get => SpritePath != null ? SpriteBucket.spriteFonts[SpritePath] : null; }
        public override Texture2D Texture {get => null;}

        public Vector2 Dimensions { get => Font.MeasureString(text); }

        public UIText(string spritePath) : base(spritePath)
        {
            spriteDepth = 0.1f;
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteDepth = 0.1f;
 
            

            if (Font == null)
            {
                return;
            }
            spriteBatch.DrawString(Font,text, ScreenPosition, color, orientation, Dimensions/2, textureScale, 0, spriteDepth);
        }
        


    }
}