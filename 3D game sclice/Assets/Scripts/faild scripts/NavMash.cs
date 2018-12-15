using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMash : MonoBehaviour
{

    [SerializeField]
    Transform _destinations;

    NavMeshAgent _navMeshAgent;

    private int m_CurrentWaypoint;




    // Use this for initialization
    void Start()
    {

        _navMeshAgent = this.GetComponent<NavMeshAgent>(); //gets nav mesh

        SetDestination();




    }

    private void SetDestination()
    {
        if(_destinations != null)
        {
            Vector3 targetVector = _destinations.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }
}