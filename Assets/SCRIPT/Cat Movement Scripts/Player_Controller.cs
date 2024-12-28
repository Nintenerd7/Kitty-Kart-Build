using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
  //SPEED AND FORCE VARIABLES
   public float SpeedCap;
   float speed = 0;
   public float velocity;
  public float jumpforce = 1f;
  public int CanDrift = 1;
  public float DriftPower;
  public float turn_Speed;
  //BOOLEANS
  public bool isDrifting = false;
  public bool isSteeringRight;
  public Drfit_Mechanic boost;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();//gets rigidbody
    }

    // Update is called once per frame
    void Update()
    {
      Controls();
    }
     void Accelerator()
{
 SpeedCap = speed + velocity;

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
          StopCoroutine(Drift());
          StartCoroutine(TurboDrift());//turbo starts
        }
        if (Input.GetKey(KeyCode.Space))
        {
          SpeedCap = 0; 
        }
        //Item Shooter button
   }
  #region DRIFTING SECTION

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
     StartCoroutine(Drift());
  }
}

 public IEnumerator Drift()
{
boost.Blue_Boost();
yield return new WaitForSeconds(2f);
boost.Orange_Boost();
yield return new WaitForSeconds(2f);
boost.Purple_Boost();
yield break;

}

public IEnumerator TurboDrift()
{
          Debug.Log("ZOOM");
          velocity += DriftPower;//drift speed added to normal speed to create turbo
         yield return new WaitForSeconds(1f);
         boost.Reset_Values();//sets values back to normal
}
#endregion
}


