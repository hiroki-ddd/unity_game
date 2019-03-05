using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuideSceneManager : MonoBehaviour {

    public GameObject Sound;

    public void GuideButton()
    {
        SceneManager.LoadScene("Guide");
        GameObject SoundClone = Instantiate(Sound) as GameObject;
        Destroy(SoundClone, 3.0f);

    }

}
