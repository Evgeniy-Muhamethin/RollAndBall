using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.TestFolder
{
	internal class PlayerBall : Player
	{
		public PlayerBall() =>
			Debug.Log($"{nameof(PlayerBall)}");
	}
}
