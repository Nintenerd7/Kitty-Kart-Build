using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  //public float DashSpeed = 10;
  public float SpeedCap;
   float speed = 0;
   public float velocity = 0.5f;
    public float turn_Speed;
     public Drift boost;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      Controls();
    }
public void Accelerator()
{
 SpeedCap = speed + velocity;
 SpeedCap++;

 if(SpeedCap >=5)
 {
  SpeedCap = 5f;//max speed
 }
   if(Input.GetKey(KeyCode.Space))
   {
          SpeedCap --;
          if(SpeedCap <= 0)
          {
            SpeedCap = 0;
          }
        }
}
   public void Controls()
   {
        if(Input.GetKey(KeyCode.S))
        {
          Accelerator();
          rb.AddRelativeForce(Vector3.forward * SpeedCap);
        }

         if(Input.GetKey(KeyCode.D))
        {
          rb.AddTorque(Vector3.up * turn_Speed);
        }

        if(Input.GetKey(KeyCode.A))
        {
          rb.AddTorque(-Vector3.up * turn_Speed);
        }
        if(Input.GetMouseButtonDown(0))
        {
           Debug.Log("Drifting");
           boost.isDrifting = true;
           boost.StartCoroutine(boost.Drifting_QUEUE());
        }
   }
}
