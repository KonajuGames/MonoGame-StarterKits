using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Microsoft.Xna.Framework;

namespace Marblets
{
	[Activity (Label = "Marblets", MainLauncher = true,ConfigurationChanges=ConfigChanges.Orientation|ConfigChanges.Keyboard|ConfigChanges.KeyboardHidden)]
	public class Activity1 : AndroidGameActivity
	{
        MarbletsGame game;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            MarbletsGame.Activity = this;
            game = new MarbletsGame();
            SetContentView(game.Window);
            game.Run();
		}
	}
}


