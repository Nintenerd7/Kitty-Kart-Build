using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float smoothing;
    public float rotSmoothing;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Player.position, smoothing);
        //rotation 
        transform.rotation = Quaternion.Slerp(transform.rotation, Player.rotation, rotSmoothing);
        transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y,0));
    }
}
