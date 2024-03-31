using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
	[SerializeField] static public int Score;
	
	[SerializeField] private GameObject score_text;


	private void Start()
	{
		if (SceneManager.GetActiveScene().name == "level1")
		{
			score.Score = 3;
		}
		else if (SceneManager.GetActiveScene().name == "level2")
		{
			score.Score = 4;
		}
		else if (SceneManager.GetActiveScene().name == "level3")
		{
			score.Score = 6;
		}
		else if (SceneManager.GetActiveScene().name == "level4")
		{
			score.Score = 5;
		}
		else if (SceneManager.GetActiveScene().name == "level5")
		{
			score.Score = 8;
		}
		else if (SceneManager.GetActiveScene().name == "level6")
		{
			score.Score = 9;
		}
		else if (SceneManager.GetActiveScene().name == "level7")
		{
			score.Score = 11;
		}
		else if (SceneManager.GetActiveScene().name == "level8")
		{
			score.Score = 11;
		}
		else if (SceneManager.GetActiveScene().name == "level9")
		{
			score.Score = 10;
		}
		else if (SceneManager.GetActiveScene().name == "level10")
		{
			score.Score = 12;
		}
		else if (SceneManager.GetActiveScene().name == "level11")
		{
			score.Score = 5;
		}
		else if (SceneManager.GetActiveScene().name == "level12")
		{
			score.Score = 8;
		}
		else if (SceneManager.GetActiveScene().name == "level13")
		{
			score.Score = 9;
		}
		else if (SceneManager.GetActiveScene().name == "level14")
		{
			score.Score = 14;
		}
		else if (SceneManager.GetActiveScene().name == "level15")
		{
			score.Score = 12;
		}
		else if (SceneManager.GetActiveScene().name == "level16")
		{
			score.Score = 12;
		}
		else if (SceneManager.GetActiveScene().name == "level17")
		{
			score.Score = 14;
		}
		else if (SceneManager.GetActiveScene().name == "level18")
		{
			score.Score = 32;
		}
		else if (SceneManager.GetActiveScene().name == "level19")
		{
			score.Score = 20;
		}
		else if (SceneManager.GetActiveScene().name == "level20")
		{
			score.Score = 31;
		}
		else if (SceneManager.GetActiveScene().name == "level21")
		{
			score.Score = 4;
		}
		else if (SceneManager.GetActiveScene().name == "level22")
		{
			score.Score = 6;
		}
		else if (SceneManager.GetActiveScene().name == "level23")
		{
			score.Score = 12;
		}
		else if (SceneManager.GetActiveScene().name == "level24")
		{
			score.Score = 15;
		}
		else if (SceneManager.GetActiveScene().name == "level25")
		{
			score.Score = 13;
		}
		else if (SceneManager.GetActiveScene().name == "level26")
		{
			score.Score = 25;
		}
		else if (SceneManager.GetActiveScene().name == "level28")
		{
			score.Score = 22;
		}
	}
	private void Update()
	{
		score_text.GetComponent<Text>().text = Score.ToString();
	}


}
