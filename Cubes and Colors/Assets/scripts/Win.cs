using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject win_ec;
    public GameObject game;

    public void WinEc() {
        win_ec.SetActive(true);
        game.SetActive(false);
    }
}
