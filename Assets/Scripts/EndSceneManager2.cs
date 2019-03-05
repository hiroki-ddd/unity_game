using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneManager2 : MonoBehaviour {
    public GameObject Sound;

    public void HomeButton()
    {
        SceneManager.LoadScene("StartScene");
        GameObject SoundClone = Instantiate(Sound) as GameObject;
        Destroy(SoundClone, 3.0f);


    }

}
