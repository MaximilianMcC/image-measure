using System.Numerics;
using Raylib_cs;

class Measurer
{
	public static Texture2D Image;
	public static Camera2D Camera;

	public static void Start()
	{
		// Vector2 offset = new Vector2(Raylib.GetScreenWidth(), Raylib.GetScreenHeight());
		Vector2 offset = Vector2.Zero;
		Camera = new Camera2D(offset, Vector2.Zero, 0f, 1f);
	}

	public static void Update()
	{

	}

	public static void Render()
	{
		// Draw the image (kinda important)
		Raylib.DrawTexture(Image, 0, 0, Color.White);
	}
}