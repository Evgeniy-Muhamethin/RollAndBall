using System;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
	public void Move(Transform player, KeyCode forvard, KeyCode back,
		KeyCode left, KeyCode right, float speedStep)
	{
		if (Input.GetKey(forvard))
		{
			player.Translate(Vector3.forward * speedStep * Time.deltaTime);
		}
		if (Input.GetKey(back))
		{
			player.Translate(Vector3.back * speedStep * Time.deltaTime);
		}
		if (Input.GetKey(left))
		{
			player.Translate(Vector3.left * speedStep * Time.deltaTime);
		}
		if (Input.GetKey(right))
		{
			player.Translate(Vector3.right * speedStep * Time.deltaTime);
		}
	}
}
