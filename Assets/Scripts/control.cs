using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control : MonoBehaviour {

    public float berat, tinggiLoncat;
    public GameObject bird, guide, pipeSpawn,skor;
    // Start is called before the first frame update
    void Start () {

    }

    void OnMouseDown () {
        if (Time.timeScale == 1) {
            skor.SetActive(true);
            GameObject.Find ("wing").GetComponent<AudioSource> ().Play ();
            pipeSpawn.SetActive (true);
            guide.SetActive (false);
            bird.GetComponent<Rigidbody2D> ().gravityScale = berat;
            bird.GetComponent<Rigidbody2D> ().velocity = new Vector2 (bird.GetComponent<Rigidbody2D> ().velocity.x, tinggiLoncat);
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.Escape)) {
            Application.Quit ();
        }
    }
}