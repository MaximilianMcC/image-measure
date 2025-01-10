using Raylib_cs;

class Program
{
	public static void Main(string[] args)
	{
		Raylib.SetTraceLogLevel(TraceLogLevel.Warning);
		Raylib.SetConfigFlags(ConfigFlags.ResizableWindow);
		Raylib.InitWindow(500, 500, "Image measure");

		// Load in the image (debug)
		Measurer.Image = Raylib.LoadTexture("./test.png");

		Measurer.Start();

		while (!Raylib.WindowShouldClose())
		{
			Raylib.BeginDrawing();
			Raylib.ClearBackground(Color.Magenta);

			Raylib.BeginMode2D(Measurer.Camera);
			Measurer.Render();
			Raylib.EndMode2D();
			Ui.Render();

			Raylib.EndDrawing();
		}

		Raylib.UnloadTexture(Measurer.Image);
		Raylib.CloseWindow();
	}
}