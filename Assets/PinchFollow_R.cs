using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchFollow_R : MonoBehaviour {
    public GameObject bone1;

	// Use this for initialization
	void Start () {
        this.GetComponent<MeshRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = bone1.transform.position;
	}
}
