using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MechStell
{
    public class StellwerkGame : Game
    {

        Texture2D weicheEinfach;
        
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private formMainMenu mainMenu;
        private String selectedStellwerk;


        public StellwerkGame(formMainMenu mainMenu, string selectedStellwerk)
        {
            _graphics = new GraphicsDeviceManager(this);

            this.mainMenu = mainMenu;
            this.selectedStellwerk = selectedStellwerk;

            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            this.Exiting += StellwerkGame_Exiting;
        }



        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            this.Window.Title = "MechStell - " + selectedStellwerk;
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            weicheEinfach = Content.Load<Texture2D>("weiche_linksOben");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            // TODO: Add your update logic here
            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                Console.WriteLine("X: " + Mouse.GetState().X + " | Y: " + Mouse.GetState().Y);
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkOliveGreen);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();
            _spriteBatch.Draw(weicheEinfach, new Vector2(0, 0), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

        private void StellwerkGame_Exiting(object sender, EventArgs e)
        {
            mainMenu.reActivate();
        } 
    }
}
