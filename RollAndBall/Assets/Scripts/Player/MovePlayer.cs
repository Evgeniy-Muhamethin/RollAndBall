using System;
using UnityEngine;

public class MovePlayer : MainPlayer
{
	[SerializeField]
	private Transform _playerTransform;

	private float _speedPlayer = 10f;
	private float _dataSpeed;

	private KeyCode[] _keyButton;
	private Data _data;

	private void Start()
	{
		_keyButton = new KeyCode[] {KeyCode.W,
		KeyCode.S, KeyCode.A, KeyCode.D };

		_data.SetSpeed(_speedPlayer);
		_dataSpeed = _data.GetSpeed();
	}

	private void FixedUpdate()
	{
		Move(_playerTransform,
			_keyButton[0], _keyButton[1],
			_keyButton[2], _keyButton[3], _dataSpeed);
	}
}
