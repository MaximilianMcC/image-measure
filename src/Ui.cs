using System.Numerics;
using Raylib_cs;

class Ui
{
	private static readonly Color backgroundColor = new Color(15, 15, 15, 255);

	public static void Render()
	{
		// Measurement stuff
		int bottom = Raylib.GetScreenHeight();
		int width = Raylib.GetScreenWidth();
		int height = 100;

		// Draw the background
		Raylib.DrawRectangleV(new Vector2(0, bottom - height), new Vector2(width, height), backgroundColor);
	}
}