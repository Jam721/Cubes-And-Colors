using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class for2square : MonoBehaviour
{
	[SerializeField] private GameObject sq;
	[SerializeField] private GameObject line;

	private void Update()
	{
		if (sq.GetComponent<BoxCollider2D>().enabled == false)
		{
			line.SetActive(true);
		}
	}

	private void OnMouseDown()
	{
		sq.GetComponent<BoxCollider2D>().enabled = false;
	}
}
