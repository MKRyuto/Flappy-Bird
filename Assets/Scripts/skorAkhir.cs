using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skorAkhir : MonoBehaviour {
    public GameObject skor, nilaiAkhir, highscore;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (GameObject.Find ("skor akhir")) {
            nilaiAkhir.GetComponent<Text> ().text = skor.GetComponent<skor> ().score.ToString ();
        } 
        if (GameObject.Find ("highscore")) {
            int HS = PlayerPrefs.GetInt ("highscore");
            highscore.GetComponent<Text> ().text = HS.ToString ();
        }
    }
}