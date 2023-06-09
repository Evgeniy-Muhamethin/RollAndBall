using Assets.Scripts.Items.Interface;
using UnityEngine;

namespace Assets.Scripts.Items
{
	public class GoodBonus : InteractiveObject, IFly1, IFlicker
	{
		private Material _material;
		private float _lengthFly;

		private void Awake()
		{
			_material = GetComponent<Renderer>().material;
			_lengthFly = Random.Range(1.0f, 5.0f);
		}

		protected override void Interaction()
		{
			base.Interaction();
			//����� �������� ���� ������ ��� ������
			//�������� ��������� ������� 
		}

		public void Fly()
		{
			transform.localPosition = new Vector3(transform.localPosition.x,
				Mathf.PingPong(Time.time, _lengthFly), transform.localPosition.z);
		}
	
		public void Flicker()
		{
			_material.color = new Color(_material.color.r, _material.color.g,
				_material.color.b, Mathf.PingPong(Time.time, 1.0f));
		}

	}
}
