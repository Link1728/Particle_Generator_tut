using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle_Generator_Tut
{
    class LeafGenerator
    {
        Texture2D texture;

        float spawnWidth;
        float density;

        List<Leafs> leafs = new List<Leafs>();

        float timer;

        Random rand1, rand2;

        public LeafGenerator(Texture2D newTexture, float newSpawnWidth, float newDensity)
        {
            texture = newTexture;
            spawnWidth = newSpawnWidth;
            density = newDensity;

            rand1 = new Random();
            rand2 = new Random();
        }

        public void createParticles()
        {
            //new Vector([left of screen] + (float)rand1.NextDouble() * (spawnWidth + [right of screen], 0)
            leafs.Add(new Leafs(texture, new Vector2(-80 + (float)rand1.NextDouble() * (spawnWidth + 50), 0), new Vector2(1, rand2.Next(5, 8))));
        }

        public void Update(GameTime gameTime, GraphicsDevice graphics)
        {
            timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            while (timer > 0)
            {
                timer -= 1f / density;
                createParticles();
            }

            for (int i = 0; i < leafs.Count; i++)
            {
                leafs[i].Update();

                if (leafs[i].Position.Y > graphics.Viewport.Height)
                {
                    leafs.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Leafs leafs in leafs)
                leafs.Draw(spriteBatch);
        }
    }
}
