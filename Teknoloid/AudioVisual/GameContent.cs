using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Teknoloid.AudioVisual
{
	public class GameContent
	{
		// Create the graphic variables
		public Texture2D LogoGraphic { get; }
		public Texture2D NoteGraphic { get; }
		public Texture2D NoteOverlayGraphic { get; }
		public Texture2D RhythmBarGraphic { get; }
		public Texture2D ButtonSideGraphic { get; }
		public Texture2D ButtonMiddleGraphic { get; }

		public GameContent(ContentManager Content)
		{
			// Load graphics
			LogoGraphic = Content.Load<Texture2D>("logo");
			NoteGraphic = Content.Load<Texture2D>("note");
			NoteOverlayGraphic = Content.Load<Texture2D>("note-overlay");
			RhythmBarGraphic = Content.Load<Texture2D>("rhythm-bar");
			ButtonSideGraphic = Content.Load<Texture2D>("button-side");
			ButtonMiddleGraphic = Content.Load<Texture2D>("button-middle");
		}
	}
}
