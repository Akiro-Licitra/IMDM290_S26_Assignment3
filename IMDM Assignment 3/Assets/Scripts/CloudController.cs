
using UnityEngine;
using System;


public class CloudController : MonoBehaviour {

/* CHANGE THESE FIELDS AS NEEDED */
public static float[] PHASE_STARTS = {0.0f, 5.0f, 10.0f, 15.0f};
public static int NUM_CLOUDS = 100;
///////////////////////////////////



Cloud[] clouds;
Vector3[] cloudsInitialPositions;
int phase = 0;  // Where in the song are we?



    void Start(){
        clouds = new Cloud[NUM_CLOUDS];
        cloudsInitialPositions = new Vector3[NUM_CLOUDS];

        // Sequentially fill the Clouds array with new clouds {Opacity, Speed, Direction}
        for(int i = 0; i < NUM_CLOUDS; i++){

        GameObject cloudObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        cloudObj.name = "Cloud";

        Cloud cloud = cloudObj.AddComponent<Cloud>();

        cloud.Initialize(2.0f, 2.0f, new Vector3(UnityEngine.Random.Range(0f, 360f), UnityEngine.Random.Range(0f, 360f),
                UnityEngine.Random.Range(0f, 360f)));

        clouds[i] = cloud;

        cloudsInitialPositions[i] = new Vector3(UnityEngine.Random.Range(-20f, 20f), UnityEngine.Random.Range(5f, 20f),
                UnityEngine.Random.Range(-20f, 20f));

        clouds[i].transform.position = cloudsInitialPositions[i];
    }

}


    void Update(){

        // Update the current phase if necessary.
        if(phase <= 3 && Time.realtimeSinceStartupAsDouble >= PHASE_STARTS[phase]){
            phase++;
            Debug.Log("Entering Phase " + phase + "\n");
        }

    }


}
