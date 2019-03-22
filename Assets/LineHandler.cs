using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineHandler : MonoBehaviour {
    public Material lineMaterial;
    // Use this for initialization
    //Vector3[] newVertices;
    Vector2[] newUV;
    int[] newTriangles;

    void Start()
    {
        Leap.Unity.DetectionExamples.PinchDraw.lineHandler = this.gameObject.GetComponent<LineHandler>();

    }
       
    public void newMesh(Vector3[] vertices, Vector2[] uvs, int[] triangles)
    {
        GameObject line = new GameObject();
        Mesh mesh = new Mesh();
        line.AddComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = vertices;
        mesh.uv = uvs;
        mesh.triangles = triangles;
        line.name = "Copied Line Object";
        line.AddComponent<MeshRenderer>().material = lineMaterial;
    }
	
	
	// Update is called once per frame
	void Update () {
        //GameObject[] lines = GameObject.FindGameObjectsWithTag("Lines");
        ////Debug.Log(lines.Length);
        //if (lines.Length > 0)
        //{
        //   Mesh lineMesh = lines[lines.Length - 1].GetComponent<MeshFilter>().sharedMesh;
        //   Vector2[] UVs = lineMesh.uv;
        //   Vector3[] vertices = lineMesh.vertices;
        //   int[] triangles = lineMesh.triangles;
        // }
      }
}
