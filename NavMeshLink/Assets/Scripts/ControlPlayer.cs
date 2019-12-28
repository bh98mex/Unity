using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class ControlPlayer : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;
    public float speed;
   

    // Start is called before the first frame update
    void Start()
    {
        agent.updatePosition = false;
        character.GetComponent<Rigidbody>();
        speed = 6.0f;

    }

    // Update is called once per frame
  
    void Update()
    {

  
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //move our agent
                agent.SetDestination(hit.point);
                speed++;
            }
        }
        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }
       
    }
    void FixedUpdate()
    {
      
    }
   
}
