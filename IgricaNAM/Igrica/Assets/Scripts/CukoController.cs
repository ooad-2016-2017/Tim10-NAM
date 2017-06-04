using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CukoController : MonoBehaviour {

	public Camera cam;
	public float speed;
	private float maxWidth;

	private bool canControl;



	

	// Use this for initialization
	void Start()
	{

		if (cam == null)
		{
			cam = Camera.main;
		}
		canControl = false;
		Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
		Renderer renderer = GetComponent<Renderer>();
		float cukoWidth = renderer.bounds.extents.x;
		maxWidth = targetWidth.x - cukoWidth;

		
	}

	// Update is called once per physics timestep
	void FixedUpdate()
	{
		if (canControl)
		{
			Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
			Vector3 targetPosition = new Vector3(rawPosition.x, 0.0f, 0.0f);
			float targetWidth = Mathf.Clamp(targetPosition.x, -maxWidth, maxWidth);
			targetPosition = new Vector3(targetWidth, targetPosition.y, targetPosition.z);
			Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
			rigidbody2D.MovePosition(targetPosition);


		}
	}


	public void ToggleControl(bool toggle)
	{
		canControl = toggle;
	}
}
