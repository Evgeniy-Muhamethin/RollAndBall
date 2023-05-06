using System;
using UnityEngine;

namespace Assets.Scripts.Player
{
	public class MovePlayer : MainPlayer
	{
		[SerializeField]
		private Transform _playerTransform;
	
		private float _speedPlayer = 10f;
		private float _dataSpeed;
	
		private KeyCode[] _keyButtonFirst;
		private KeyCode[] _keyButtonLast;
		private Data _data;

		[SerializeField]
		private bool _alternativeKeypad;
	
		private void Start()
		{
			_keyButtonFirst = new KeyCode[] {KeyCode.W,
			KeyCode.S, KeyCode.A, KeyCode.D };

			_keyButtonLast = new KeyCode[] {KeyCode.UpArrow,
			KeyCode.DownArrow, KeyCode.LeftArrow, KeyCode.RightArrow };

			_data.SetSpeed(_speedPlayer);
			_dataSpeed = _data.GetSpeed();
		}
	
		private void FixedUpdate()
		{
			switch (_alternativeKeypad)
			{
				case true:
					Move(_playerTransform,
						_keyButtonFirst[0], _keyButtonFirst[1],
						_keyButtonFirst[2], _keyButtonFirst[3], _dataSpeed);
					break;
				case false:
					Move(_playerTransform,
						_keyButtonLast[0], _keyButtonLast[1],
						_keyButtonLast[2], _keyButtonLast[3], _dataSpeed);
					break;
			}
		}
	
	}
}
