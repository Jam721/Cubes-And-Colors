using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inClickPlace : MonoBehaviour
{
	[SerializeField] private LineRendererController _lineRendererController;
	public ClickController cc;
	public bool canBeClicked;
	public bool actived;
	private nowActive na;
	private score score;

	public AudioSource sm;


	[SerializeField] private string namein;
	private void Start()
	{
		na = GameObject.Find("nowActive").GetComponent<nowActive>();
		cc = GetComponentInParent<ClickController>();
		sm.volume = 0.3f;
		sm.Pause();
	}

	private void Update()
	{
		canBeClicked = cc.canBeClicked;
		actived = cc.actived;
	}

	private void OnMouseUp()
	{
		if (canBeClicked)
		{
			_lineRendererController.SetLineRendererPoint(transform.position);
			na.beforeTriggered.tag = "actived";
			if (namein == "double")
			{
				GetComponentInParent<SpriteRenderer>().color = Color.red;
			}
			else if (namein == "two")
			{
				GetComponentInParent<SpriteRenderer>().color = Color.green;
			}
			else
			{
				GetComponentInParent<SpriteRenderer>().color = Color.blue;
			}
			cc.canBeClicked = false;
			Instantiate(cc.activedTrigger, cc.gameObject.transform);
			score.Score = score.Score - 1;
			sm.Play();
		}


	}
}
