
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneManag : MonoBehaviour
{
	public static sceneManag instance = null;
	int sceneIndex;
	int levelComplete;


	

	public void SampleScene()
	{
		SceneManager.LoadScene("Level1");
	}

	public void ForMenu()
	{
		SceneManager.LoadScene("Menu");
	}


}
