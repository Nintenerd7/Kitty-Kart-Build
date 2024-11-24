using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public static float DashSpeed = 10;
   [SerializeField] public static float speed = 0;
    public float turn_Speed;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      Controls();
    }

   public void Controls()
   {
        if(Input.GetKey(KeyCode.W))
        {
          speed = 10;
          rb.AddRelativeForce(Vector3.forward * speed);
        }
        if(Input.GetKey(KeyCode.Space))
        {
          speed --;
          if(speed <= 0)
          {
            speed = 0;
          }
        }
         if(Input.GetKey(KeyCode.S))
        {
        rb.AddRelativeForce(-Vector3.forward * speed);
        }

         if(Input.GetKey(KeyCode.D))
        {
          rb.AddTorque(Vector3.up * turn_Speed);
        }

        if(Input.GetKey(KeyCode.A))
        {
          rb.AddTorque(-Vector3.up * turn_Speed);
        }
   }
    public static void DashAccelerator()
    {
       speed +=DashSpeed;
    }
}
