﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LevelGenerator : MonoBehaviour
{
    public NavMeshSurface surface;

    public int width = 10;
    public int height = 10;

   public GameObject wall;
    public GameObject player;
  

    private bool playerSpawned = false;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.tag = "Player";
       
        GenerateLevel();
        surface.BuildNavMesh();
        //surface.CombineMeshes();
    }


    void GenerateLevel()
    {
      
        for (int x = 0; x <= width; x += 2)
        {
            for (int y = 0; y <= height; y += 2)
            {
                if (Random.value > .7f)
                {
                    Vector3 pos = new Vector3(x - width / 2f, 1f, y - height / 2f);
                    Instantiate(wall, pos, Quaternion.identity, transform);
                }
                else if (!playerSpawned)
                {
                    Vector3 pos = new Vector3(x - width / 2f, 1.25f, y - height / 2f);
                    Instantiate(player, pos, Quaternion.identity);
                    playerSpawned = true;
                }
            }
    }
    // Update is called once per frame

}
    }
