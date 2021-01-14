using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour {
    public GameObject nilai;
    public int score;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        nilai.GetComponent<Text> ().text = score.ToString ();
    }
}