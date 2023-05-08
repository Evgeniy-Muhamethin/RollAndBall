using System.Diagnostics;
using UnityEngine;

namespace Assets.Scripts.Items.Interface
{
	internal interface IFly1
	{
		void Fly()
		{
            UnityEngine.Debug.Log("I can fly");
		}
	}
}
