using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace NetworkingTest
{
    static class World
    {
        static Color c = new Color(0,0,0);

        public static string Update(string data)
        {
            if (!String.IsNullOrWhiteSpace(data))
            {
                string[] members = data.Split('.');

                c.R = byte.Parse(members[0]);
                c.G = byte.Parse(members[1]);
                c.B = byte.Parse(members[2]);

            }
            return "";
        }

        public static void Draw(SpriteBatch sb, GraphicsDevice g)
        {
            g.Clear(c);
        }
    }
}
