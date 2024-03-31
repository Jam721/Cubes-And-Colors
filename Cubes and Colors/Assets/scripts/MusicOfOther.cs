using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicOfOther : MonoBehaviour
{
	[Header("Теги")]
	[SerializeField] private string createdTag;

	public AudioSource audiosz;
	public Button btn;


	private void Awake()
	{
		btn = GameObject.Find("mb").GetComponent<Button>();
		btn.onClick.AddListener(MuteAudio);



		GameObject obj = GameObject.FindWithTag(createdTag);


		audiosz = GameObject.Find("music").GetComponent<AudioSource>();


		if (obj != null)
		{
			Destroy(gameObject);
		}
		else
		{
			gameObject.tag = createdTag;
			DontDestroyOnLoad(gameObject);
		}
	}



	public void Update()
	{

		if (btn == null)
		{
			btn = GameObject.Find("mb").GetComponent<Button>();
			btn.onClick.AddListener(MuteAudio);
		}
	}







	public void MuteAudio()
	{
		audiosz.mute = !audiosz.mute;
	}
}
