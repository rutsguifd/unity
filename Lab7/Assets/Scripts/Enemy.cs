using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent myAgent;
    int i;
    public List<Transform> targets;

    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }
    void TargetUpdate(){
        i = Random.Range(0,targets.Count);
    }


    // Update is called once per frame
    void Update()
    {
        if (myAgent.transform.position == myAgent.pathEndPosition){
            TargetUpdate();
        }
        myAgent.SetDestination(targets[i].position);
    }
}
