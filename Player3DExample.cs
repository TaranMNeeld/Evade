using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3DExample : MonoBehaviour
{
   public float moveSpeed = 8f;

	public Joystick joystick;

	private void Update()
	{
		Vector3 vector = Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical;
		if (vector != Vector3.zero)
		{
			base.transform.rotation = Quaternion.LookRotation(vector);
			base.transform.Translate(vector * moveSpeed * Time.deltaTime, Space.World);
		}
	}
}
