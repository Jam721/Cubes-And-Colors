using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ClickController : MonoBehaviour
{
	public bool actived;
	public bool canBeClicked;
	//public int nearbyNum;
	private nowActive na;

	public GameObject beforeTriggered;
	public GameObject activedTrigger;

	public GameObject line;
	


	private score score;

	public string squareName;
	public GameObject winEc;

	

	void Start()
	{
		na = GameObject.Find("nowActive").GetComponent<nowActive>();
		if (actived)
		{
			GetComponent<SpriteRenderer>().color = Color.blue;
			canBeClicked = false;
			Instantiate(activedTrigger, transform);
		}
	}

	private void Update()
	{
		if (beforeTriggered) if (beforeTriggered.tag != "nowActive") canBeClicked = false;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{	
		if (other.CompareTag("nowActive") & !actived)
		{
			na.beforeTriggered = other.gameObject;
			beforeTriggered = other.gameObject;
			canBeClicked = true;
		}
		if (squareName == "win" & canBeClicked == true & score.Score == 0)
		{
			winEc.SetActive(true);
			
		}
		if (squareName == "double" & canBeClicked == true & score.Score % 2 == 0)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		if (squareName == "two" & canBeClicked == true)
		{
			score.Score--;
		}
		if (beforeTriggered.tag != "nowActive")
		{
			line.SetActive(true);
		}
		if (squareName=="lol" & other.CompareTag("nowActive")){
			canBeClicked = true;
		}
		
	}
}
