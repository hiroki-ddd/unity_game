using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour {

    public GameObject itemButton;
    public GameObject reStartButton;
    public GameObject itemPanel;
    public GameObject Sound;

    public void StopGame()
    {
        Time.timeScale = 0f;
        itemButton.SetActive(false);
        reStartButton.SetActive(true);
        itemPanel.SetActive(true);
        GameObject SoundClone = Instantiate(Sound) as GameObject;
        Destroy(SoundClone, 3.0f);

    }

    public void ReStartGame()
    {
        itemPanel.SetActive(false);
        reStartButton.SetActive(false);
        itemButton.SetActive(true);
        Time.timeScale = 1f;
    }

}

