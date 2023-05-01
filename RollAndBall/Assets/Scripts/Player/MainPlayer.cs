using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
	[SerializeField]
	private Transform _playerTransform;

	private float _speedPlayer = 10f;
	private float _dataSpeed;

	private KeyCode[] _keyButton;
	private Data _data;

	private MovePlayer _movePlayer;

	private void Start()
	{
		_keyButton = new KeyCode[] {KeyCode.W,
		KeyCode.S, KeyCode.A, KeyCode.D };

		_movePlayer = new MovePlayer();

		_data.SetSpeed(_speedPlayer);
		_dataSpeed = _data.GetSpeed();
	}

	private void FixedUpdate()
	{
		_movePlayer.Move(_playerTransform,
			_keyButton[0], _keyButton[1],
			_keyButton[2], _keyButton[3], _dataSpeed);
	}
}
