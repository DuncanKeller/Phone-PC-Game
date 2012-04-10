using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;

namespace PhoneClient
{
    class World
    {
        static string serverName = "viridian.csh.rit.edu";
        static int portNumber = 13001;
        static SocketClient client;
        static Random rand;

        public static void Init()
        {
            client = new SocketClient(serverName, portNumber);
            rand = new Random();
        }

        public static void Update()
        {
            TouchCollection tc = TouchPanel.GetState();

            foreach (TouchLocation tl in tc)
            {
                if (tl.State == TouchLocationState.Pressed)
                {
                    client.SendData(
                        rand.Next(255).ToString() + "." +
                        rand.Next(255).ToString() + "." +
                        rand.Next(255).ToString());
                }
            }
        }
    }
}
