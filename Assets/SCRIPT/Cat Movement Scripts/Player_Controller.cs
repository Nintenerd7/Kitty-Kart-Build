using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
     public float SpeedCap;
   float speed = 0;
   public float velocity = 0.5f;
  public float jumpforce = 1f;
  public int CanDrift = 1;
   
   public float DriftPower = 1;
  public bool isDrifting = false;
    public float turn_Speed;
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
     void Accelerator()
{
 SpeedCap = speed + velocity;
 SpeedCap++;

 if(SpeedCap >=20)
 {
  SpeedCap = 20f;//max speed
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
        //DRIFT
        if(Input.GetMouseButtonDown(0))
        {
          Initiate_Drift();
        }
        if(Input.GetMouseButtonUp(0))
        {
          isDrifting = false;
          SpeedCap += DriftPower;//drift speed added to normal speed
          Debug.Log("ZOOM");
        }
        //Item Shooter button
   }
    void Initiate_Drift()
{
   //player hops
  rb.AddForce(Vector3.up * jumpforce * 10);
  isDrifting = true;
  CanDrift--;
  if(CanDrift == 0)
  {
     jumpforce = 0;
            //start the drift coroutine
            Drift();
  }
}

 void Drift()
{
  DriftPower++;

  if (DriftPower <=5)
  {
    Debug.Log("blue sparks");
  }
    if (DriftPower <=10)
  {
    Debug.Log("orange sparks");
  }
    if (DriftPower <=15)
  {
    Debug.Log("purple sparks");
  }
}
}


