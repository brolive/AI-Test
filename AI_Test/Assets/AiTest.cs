using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiTest : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target;

    public float speed = 5;
    public float watchDistance = 5.0f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;
        //if (Vector3.Distance(transform.position, target.position) < watchDistance)
        //transform.LookAt(target);
        //transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
            
    }
}
