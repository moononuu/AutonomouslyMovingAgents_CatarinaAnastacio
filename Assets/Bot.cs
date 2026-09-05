using System.IO;
using UnityEngine;
using UnityEngine.AI;

public class Bot : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    void Seek(Vector3 location) 
    
    {
        agent.SetDestination(location);
    }   

// Update is called once per frame
void Update()
    {
        Seek(target.transform.position);
}
}
