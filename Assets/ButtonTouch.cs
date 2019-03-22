using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTouch : MonoBehaviour
{
    public static Renderer boxColor;
    // Start is called before the first frame update
    void Start()
    {
        boxColor = this.gameObject.GetComponent<Renderer>();
    }

    public static void ChangeColor(Color color)
    {
        boxColor.material.color = color;
    }

}
