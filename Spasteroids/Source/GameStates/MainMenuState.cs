﻿using Azimuth;
using Azimuth.GameObjects;
using Azimuth.GameStates;

using Raylib_cs;

using System.Numerics;

namespace Spasteroids.UI
{
	public class MainMenuState : IGameState
	{
		public string ID => "Main Menu";

		private Button playButton;
		
		public void Load()
		{
			int screenWidth = Application.Instance.Window.Width;
			int screenHeight = Application.Instance.Window.Height;

			Vector2 size = new Vector2(screenWidth * 0.5f, 100);
			Vector2 pos = new Vector2(size.X, screenHeight * 0.5f - size.X * 0.5f);
			ColorBlock buttonColors = new ColorBlock(Color.RAYWHITE, Color.LIGHTGRAY, Color.DARKGRAY, Color.BLACK);
			Button.RenderSettings renderSettings = new Button.RenderSettings(buttonColors, 100, "Fonts/poxel");

			playButton = new Button(pos, size, "Play", renderSettings);
			GameObjectManager.Spawn(playButton);
		}

		public void Update(float _deltaTime)
		{
			
		}

		public void Draw()
		{
			
		}

		public void Unload()
		{
			
		}
	}
}