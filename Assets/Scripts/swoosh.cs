using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swoosh : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

    }

    void suara_swoosh () {
        GameObject.Find ("swoosh").GetComponent<AudioSource> ().Play ();
    }

    // Update is called once per frame
    void Update () {

    }
}