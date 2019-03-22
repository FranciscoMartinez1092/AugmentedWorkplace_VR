using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerDetection : MonoBehaviour
{
    public Example SceneManager;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Button")
        {
            SceneManager.TogglePlay();
        }
    }

}