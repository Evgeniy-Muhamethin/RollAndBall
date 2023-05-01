using UnityEngine;

public class CameraController : MonoBehaviour
{
    public MainPlayer _player;

    private Vector3 _offset;

	private void Start()
	{
		_offset = transform.position - _player.transform.position;
	}

	private void Update()
	{
		transform.position = _player.transform.position + _offset;
	}
}
