using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Tile_Engine;

namespace Gemstone_Hunter2
{
    public class Player : GameObject
    {
        //pg. 364
        private Vector2 fallSpeed = new Vector2(0, 20);
        private float moveScale = 180.0f;
        private bool dead = false;

        public bool Dead
        {
            get { return dead; }
        }

        #region Constructor
        public Player(ContentManager content)
        {
            animations.Add("idle",
                new AnimationStrip(
                    content.Load <Texture2D>(@"Textures\Sprites\Player\ Idle"),
                    48,
                    "idle"));
            animations["idle"].LoopAnimation = true;
            animations.Add("run",
                new AnimationStrip(
                    content.Load<Texture2D>(@"Textures\Sprites\Player\ Run"),
                    48,
                    "run"));
            animations["run"].LoopAnimation = true;
            animations.Add("jump",
                new AnimationStrip(
                    content.Load<Texture2D>(@"Textures\Sprites\Player\Die"),
                    48,
                    "die"));
            animations["die"].LoopAnimation = false;
            frameWidth = 48;
            frameHeight = 48;
            CollisionRectangle = new Rectangle(9, 1, 30, 46);
            drawDepth = 0.825f;
            enabled = true;
            codeBasedBlocks = false;
            PlayAnimation("idle");
        }
        #endregion
    }
}
