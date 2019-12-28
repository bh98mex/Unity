using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Threding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Start() :: Starting()");

        Thread myThread = new Thread(SlowJob);

        myThread.Start();

    }
    bool isRunning = false;

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
            Debug.Log("SlowJob isRunning");
    }

    private void FixedUpdate()
    {

    }

    void SlowJob()
    {
        isRunning = true;
        Debug.Log("ExampleScript::SlowJob() -- Doing 100 things, each taking 2 ms");
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        sw.Start();

        for (int i = 0; i < 1000; i++)
        {
            Thread.Sleep(2);    //Sleep for 2ms

        }

        sw.Stop();

        // NOTE: Because of various overheads and context-switches, elapsed time
        //will be moe than 2 seconds.
        Debug.Log("Threading :: SlowJob() -- Done! Elapsed time:" + sw.ElapsedMilliseconds / 1000f);

        isRunning = false;

        

    }
}
