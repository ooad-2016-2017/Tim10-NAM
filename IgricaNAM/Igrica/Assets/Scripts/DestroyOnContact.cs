using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
	{
		Destroy(other.gameObject);
	}
}
