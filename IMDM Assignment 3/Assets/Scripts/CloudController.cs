
using UnityEngine;
using System;


public class CloudController : MonoBehaviour {

/* CHANGE THESE FIELDS AS NEEDED */
public static float[] PHASE_STARTS = {0.0f, 5.0f, 10.0f, 15.0f};
public static int NUM_CLOUDS = 10;
///////////////////////////////////



Cloud[] clouds;
int phase = 0;  // Where in the song are we?



    void Start(){
        clouds = new Cloud[NUM_CLOUDS];


        // Sequentially fill the Clouds array with new clouds {Opacity, Speed, Direction}
        for(int i = 0; i < NUM_CLOUDS; i++){
            GameObject cloudObj = new GameObject("Cloud");
            Cloud cloud = cloudObj.AddComponent<Cloud>();

            cloud.Initialize(2.0f, 2.0f, new Vector3(UnityEngine.Random.Range(0f, 360f), UnityEngine.Random.Range(0f, 360f), 
                        UnityEngine.Random.Range(0f, 360f)));

            clouds[i] = cloud;         
        }

    }


    void Update(){

        // Update the current phase if necessary.
        if(phase <= 3 && Time.realtimeSinceStartupAsDouble >= PHASE_STARTS[phase]){
            phase++;
            Console.Write("Entering Phase " + phase + "\n");
        }

    }


}
