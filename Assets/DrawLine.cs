using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {

    public GameObject lineGeneratorPrefab;
    private List<GameObject> lineGeneratorList;
    private void Start()
    {
        lineGeneratorList = new List<GameObject>();
    }
    public void SpawnLineGenerator(Vector3[] pointPositions)
    {
        //Debug.Log("Spawning line generator");
        //Debug.Log("Points: " + pointPositions);
        //Debug.Log("Length: " + pointPositions.GetLength(0));
        //Debug.Log("Other length: " + pointPositions.Length);
        GameObject lineGeneratorClone = Instantiate(lineGeneratorPrefab);
        LineRenderer lineRenderer = lineGeneratorClone.GetComponent<LineRenderer>();

        lineRenderer.positionCount = pointPositions.Length;
        lineRenderer.SetPositions(pointPositions);
        
        lineGeneratorList.Add(lineGeneratorClone);
    }
}
