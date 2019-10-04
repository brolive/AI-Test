using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolBot : MonoBehaviour
{
    public List<Transform> nodes;
    public int nodeIndex = 0;
    public float speed = 1.0f;
    // Start is called before the first frame update

    public enum States
    {
        patrol,
        idle,
        charge
    }

    public States state = States.idle;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            case States.idle:
                UpdateIdle();
                break;

            case States.patrol:
                UpdatePatrol();
                break;
        }
    }

    void UpdateIdle()
    {
        if (Input.GetButtonDown("Jump"))
        {
            state = States.patrol;
        }
    }

    void UpdatePatrol()
    {
        transform.position = Vector3.Lerp(transform.position,
                                          nodes[nodeIndex].transform.position,
                                          speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, nodes[nodeIndex].transform.position) < 2)
        {
            nodeIndex++;

            if (nodeIndex >= nodes.Count)
            {
                nodeIndex = 0;
            }
        }
    }
}
