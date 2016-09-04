﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;

namespace VauxGame.Components
{
    public class Cursor : IUpdateable, IDrawable, IMovable
    {
        private Vector2 _position;
        private Vector2 _size;
        private Texture2D _texture;

        public Cursor()
        {
            _size = new Vector2(25);
        }

        public void MoveTo(Vector2 position)
        {
            _position = position;
        }

        public void LoadContent(Microsoft.Xna.Framework.Content.ContentManager content)
        {
            _texture = content.Load<Texture2D>("gui/cursor-3-xxl");
        }

        public void UnloadContent(Microsoft.Xna.Framework.Content.ContentManager content)
        {
            throw new NotImplementedException();
        }

        public void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var destinationRectangle = new Rectangle(_position.ToPoint(), _size.ToPoint());
            spriteBatch.Draw(_texture, destinationRectangle, Color.White);
        }
    }
}
