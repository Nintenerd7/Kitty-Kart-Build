using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    public float speed = 10;
    public float TurnSpeed = 10f;
    public Transform Track;
    private List<Transform>nodes;
    private int currentNode = 0;
    // Start is called before the first frame update
    void Start()
    {
        Transform[] pathTransforms = Track.GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for(int i = 0; i < pathTransforms.Length; i++)
        {
         if(pathTransforms[i] != Track.transform)
         {
           nodes.Add(pathTransforms[i]);
         }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.InverseTransformPoint(nodes[currentNode].position), transform.position, speed);
    }
}
