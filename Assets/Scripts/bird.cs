using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bird : MonoBehaviour {

    public GameObject gameover, skor, emas, perak;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.tag == "ground") {
            GameObject.Find ("hit").GetComponent<AudioSource> ().Play ();
            gameover.SetActive (true);
            if (PlayerPrefs.GetInt ("highscore") < skor.GetComponent<skor> ().score) {
                PlayerPrefs.SetInt ("highscore", skor.GetComponent<skor> ().score);
            }
            Time.timeScale = 0;

            if (skor.GetComponent<skor> ().score > 20) {
                emas.SetActive (true);
            } else if (skor.GetComponent<skor> ().score > 10) {
                perak.SetActive (true);
            }
        }

        if (other.gameObject.name == "addScore") {
            GameObject.Find ("point").GetComponent<AudioSource> ().Play ();
            skor.GetComponent<skor> ().score++;
        }
    }
}