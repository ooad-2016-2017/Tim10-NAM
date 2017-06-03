using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {


	public Camera cam;
	private float maxWidth;
	public GameObject obj;
	public float TimeLeft;
	public Text tekstTimer;

	public GameObject gameoverText;
	public GameObject restartButton;
	public GameObject[] hrana;
	public GameObject playButton;
	public GameObject splashScreen;
	public bool playing;
	public CukoController cukoController;



	void Start()
	{
		if (cam == null)
		{
			cam = Camera.main;
		}

		playing = false;
		Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
		Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
		Renderer renderer = GetComponent<Renderer>();
		float objWidth = obj.GetComponent<Renderer>().bounds.extents.x;
	  
		maxWidth = targetWidth.x - objWidth;
		//StartCoroutine(Spawn());
		updateText();

	}

	public void Play()
	{
		playButton.SetActive(false);
		splashScreen.SetActive(false);
		cukoController.ToggleControl(true);
		StartCoroutine(Spawn());
	}

	private void FixedUpdate()
	{
		if (playing)
		{
			TimeLeft -= Time.deltaTime;
			if (TimeLeft < 0)
			{
				TimeLeft = 0;
			}
			updateText();
		}

	}

	IEnumerator Spawn()
	{
		yield return new WaitForSeconds(2.0f);
		playing = true;
		while (TimeLeft > 0)
		{
			Vector3 spawnPosition = new Vector3(
				Random.Range(-maxWidth, maxWidth),
				transform.position.y,
				0.0f
				);

			Quaternion spawnRotation = Quaternion.identity;
			Instantiate(hrana[(int)Random.Range(0,hrana.Length)] , spawnPosition, spawnRotation);
			yield return new WaitForSeconds(Random.Range(0.5f,2.0f));
		}
		yield return new WaitForSeconds(0.5f);

		gameoverText.SetActive(true);
		yield return new WaitForSeconds(0.5f);
		restartButton.SetActive(true);
	}
	void updateText()
	{
		tekstTimer.text = "Time Left: " + Mathf.RoundToInt(TimeLeft);
	}


	
}
