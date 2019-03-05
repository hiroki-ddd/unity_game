using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

    float speed = 10.0f;
    Vector3 preMousePos;
  
    int count;
    public Text countText;

    public GameObject Sound;




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();

    }

    void Move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            preMousePos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosDiff = Input.mousePosition - preMousePos;
            preMousePos = Input.mousePosition;
            Vector3 newPos = this.gameObject.transform.position + new Vector3(mousePosDiff.x / Screen.width, 0, mousePosDiff.y / Screen.height) * speed;

            this.transform.position = newPos;
        }
    }


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Debug.Log("あたった");
            PlayerPrefs.SetInt("score", count);
            SceneManager.LoadScene("EndScene");
        }
        if(col.gameObject.tag == "Target")
        {
            Debug.Log("ゲット！");
            count += 10;
            countText.text = count.ToString();
            GameObject SoundClone = Instantiate(Sound) as GameObject;
            Destroy(SoundClone, 3.0f);

        }
        if (col.gameObject.tag == "Target2")
        {
            Debug.Log("ゲット！");
            count += 20;
            countText.text = count.ToString();
            GameObject SoundClone = Instantiate(Sound) as GameObject;
            Destroy(SoundClone, 3.0f);

        }
        if (col.gameObject.tag == "Target3")
        {
            Debug.Log("ゲット！");
            count += 30;
            countText.text = count.ToString();
            GameObject SoundClone = Instantiate(Sound) as GameObject;
            Destroy(SoundClone, 3.0f);


        }
        if (col.gameObject.tag == "Target4")
        {
            Debug.Log("ゲット！");
            count += 50;
            countText.text = count.ToString();
            GameObject SoundClone = Instantiate(Sound) as GameObject;
            Destroy(SoundClone, 3.0f);


        }
        if (col.gameObject.tag == "Target5")
        {
            Debug.Log("ゲット！");
            count += 5;
            countText.text = count.ToString();
            GameObject SoundClone = Instantiate(Sound) as GameObject;
            Destroy(SoundClone, 3.0f);

        }
        if (col.gameObject.tag == "Target6")
        {
            Debug.Log("ゲット！");
            count += 70;
            countText.text = count.ToString();
            GameObject SoundClone = Instantiate(Sound) as GameObject;
            Destroy(SoundClone, 3.0f);

        }




    }
}
