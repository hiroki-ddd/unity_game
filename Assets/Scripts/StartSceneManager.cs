using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour {

    public GameObject Sound;

    public void StartButton()
    {
        SceneManager.LoadScene("Main");
        GameObject SoundClone = Instantiate(Sound) as GameObject;
        Destroy(SoundClone, 3.0f);

    }

}
