using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Waypoints : MonoBehaviour
{
    public List<Transform> WayPoints;
    public NavMeshAgent navMeshAgent;

    public int currentWayPointIndex = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Walking();
    }

    void Walking()
    {
      if(WayPoints.Count == 0) return;

      float distanceToWayPoint = Vector3.Distance(WayPoints[currentWayPointIndex].position, transform.position);

      if(distanceToWayPoint <= 40){
        currentWayPointIndex = (currentWayPointIndex +1) % WayPoints.Count;
      }

      navMeshAgent.SetDestination(WayPoints[currentWayPointIndex].position);
    }
}
