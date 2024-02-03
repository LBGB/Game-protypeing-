using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingplatform : MonoBehaviour
{
    [SerializeField]
    private Waypotintpath Waypotintpath;
    [SerializeField]
    private float _speed;
    private int _targetWaypointIndex;
    private Transform _previousWaypoint;
    private Transform _targetWaypoint;

    private float _TimeToWayponit;
    private float _elaspedTime;
    void Start()
    {
        
    }

    
    
    private void FixedUpdate()
    {
        _elaspedTime += Time.deltaTime;

        float elasedPercentage = _elaspedTime / _TimeToWayponit;
        elasedPercentage = Mathf.SmoothStep(0,1,elasedPercentage);
        transform.position = Vector3.Lerp(_previousWaypoint.position, _targetWaypoint.position, elasedPercentage);

        if (_elaspedTime >=1)
        {
            TargetNexWayponint();
        }
    }

    private void TargetNexWayponint()
    {
        _previousWaypoint = Waypotintpath.GetWaypoint(_targetWaypointIndex);
        _targetWaypointIndex = Waypotintpath.GetNextWaypoint(_targetWaypointIndex);
        _targetWaypoint = Waypotintpath.GetWaypoint(_targetWaypointIndex);

        _elaspedTime = 0;

        float distanceToWaypoint = Vector3.Distance(_previousWaypoint.position, _targetWaypoint.position);
        _TimeToWayponit = distanceToWaypoint / _speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent.SetParent(transform);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
    }
}
