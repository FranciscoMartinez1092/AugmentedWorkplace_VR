using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchFollow_R : MonoBehaviour {
    private GameObject bone2 = null;

	// Use this for initialization
	void Start () {
        GameObject handModels = GameObject.Find("HandModels");
        Debug.Log(handModels.name);
        bone2 = handModels.GetComponent<StoreHandChildren>().bone2;
        //this.GetComponent<MeshRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        //GameObject hand = GameObject.Find("HandModels");
        //Debug.Log(hand.name);
        //Debug.Log(hand.transform.GetChildCount());
        //if (hand.transform.GetChildCount() > 0)
        //{
        //    GameObject rightHand = hand.transform.GetChild(3).gameObject;
        //    GameObject index = rightHand.transform.GetChild(1).GetChild(0).gameObject;
        //    Debug.Log("Found: " + index.name);
        //}
        this.transform.position = bone2.transform.position;
    }
}
