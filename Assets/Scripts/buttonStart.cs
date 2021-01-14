using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonStart : MonoBehaviour {
    float x, y;
    // Start is called before the first frame update
    void Start () {
        x = transform.localScale.x;
        y = transform.localScale.y;
    }

    void OnMouseDown () {
        transform.localScale = new Vector2 (x/1.2f, y/1.2f);
    }

    void OnMouseUp () {
        transform.localScale = new Vector2 (x, y);
        Time.timeScale = 1;
        SceneManager.LoadScene("play");
    } 

    // Update is called once per frame
    void Update () {

    }
}