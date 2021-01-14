using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pipaSpawn : MonoBehaviour {

    public GameObject pipe;
    // Start is called before the first frame update
    void Start () {

    }

    void spawn () {
        Instantiate (pipe, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update () {

    }
}