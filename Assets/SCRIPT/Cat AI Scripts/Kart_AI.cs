using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kart_AI : MonoBehaviour
{
 public Waypoints point_Container;
 public List<Transform> Waypoints;
 public int currentWayPoint;
 
 private PlayerController carController;
 public float waypointRange;

 void start()
 {
   carController = GetComponent<PlayerController>();
   Waypoints = point_Container.WayPoints;
   currentWayPoint = 0;
 }

 void Update()
 {
  if(Vector3.Distance(Waypoints[currentWayPoint].position, transform.position) < waypointRange)
  {
    currentWayPoint++;
    if(currentWayPoint == Waypoints.Count) currentWayPoint = 0;
  }
  Debug.DrawRay(transform.position, Waypoints[currentWayPoint].position - transform.position, Color.yellow);
 }
}
