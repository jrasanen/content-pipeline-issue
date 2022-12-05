using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Jelly;

public class JellyGame : Game
{
    public static string ContentDirectory { get; private set; }
    private GraphicsDeviceManager _graphics;
    private Texture2D texture;
    
    public JellyGame() 
    {
        ContentDirectory = "Content";
        _graphics = new GraphicsDeviceManager(this);
        _graphics.PreferredBackBufferWidth = 1280;
        _graphics.PreferredBackBufferHeight = 720;
        Window.AllowUserResizing = true;
        Window.Title = "Test";
        IsMouseVisible = false;
        IsFixedTimeStep = true;
    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        base.LoadContent();
        texture = Content.Load<Texture2D>("Graphics/fire");
    }

    protected override void UnloadContent()
    {
        base.UnloadContent();
    }
    protected override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }
}