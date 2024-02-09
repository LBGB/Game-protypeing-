using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypotintpath : MonoBehaviour
{
   public Transform GetWaypoint (int waypointIndex)
    {
        return transform.GetChild(waypointIndex);

    }


    public int GetNextWaypoint (int currentpointIndex)
    {
        int nextwaypointIndex = currentpointIndex + 1;
        if (nextwaypointIndex == transform.childCount)
        {
            nextwaypointIndex = 0;
        }

        return nextwaypointIndex;
    }
}
