using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Finder : MonoBehaviour
{


    public Rigidbody agent;
    public LayerMask hitLayers;


    void Start()
    {



    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))//if the player has left clicked
        {
            Vector3 mouse = Input.mousePosition; //get the mouse position
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);//Cast a ray to get the point where th emouse is pointed at
            RaycastHit hit; // stores the position where the ray hit
            if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers)) //if the raycast has not hit a wall 
            {
                agent.transform.position = hit.point;// move the target into position
            }
        }


    }
}


