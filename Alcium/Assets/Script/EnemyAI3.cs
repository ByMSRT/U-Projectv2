using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class EnemyAI3 : MonoBehaviour
{
    protected NavMeshAgent Agent;


    private void Awake()
    {
        Agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitinfo;
            Physics.Raycast(ray, out hitinfo);
            Agent.SetDestination(hitinfo.point);
        }
       
    }

   
}
