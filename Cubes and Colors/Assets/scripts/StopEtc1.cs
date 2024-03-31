using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StopEtc1 : MonoBehaviour
{
	[SerializeField] private GameObject game;
	[SerializeField] private score scores;
	[SerializeField] private GameObject lolk;
	static int count = 0;
	[SerializeField] private GameObject me;
	[SerializeField] private MusicOfOther mm;


	private ClickController line;
	private MusicOfOther b;


	public void StartGAme()
	{
		game.SetActive(true);
	}

	public void Lolk()
	{
		lolk.SetActive(false);

	}
	private void Update()
	{
		if (count == 1)
		{
			lolk.SetActive(false);
			me.SetActive(true);
		}
	}
	public void RestartLevel()
	{
		count = 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		line.line.SetActive(false);
	}

	public void NextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		count = 0;
	}

	public void ChoiseLevel(string scoreLevel)
	{
		SceneManager.LoadScene("level"+scoreLevel);
	}
	

}
