using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreHandChildren : MonoBehaviour {
    public GameObject bone1 = null;
    public GameObject bone2 = null;
	// Use this for initialization
	void Start () {
        Debug.Log(bone1);
        Debug.Log(bone2);
	}
	public void SetBone1(GameObject bone)
    {
        Debug.Log("Bone1 set");
        bone1 = bone;
    }
    public void SetBone2(GameObject bone)
    {
        Debug.Log("Bone2 set");
        bone2 = bone;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
