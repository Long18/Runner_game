using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Runner.Utilities;

namespace Runner.UI
{

	public class UILastScoreText : Text
	{

		protected override void Awake ()
		{
			GameManager.OnScoreChanged += GameManager_OnScoreChanged;
			base.Awake ();
		}

		void GameManager_OnScoreChanged ( float newScore, float highScore, float lastScore )
		{
			text = lastScore.ToLength ();
		}

	}

}