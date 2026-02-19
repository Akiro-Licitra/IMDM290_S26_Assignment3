
using UnityEngine;

public class CloudController : MonoBehaviour {

    /* Feel free to change these */
    public static float[] PHASE_STARTS = {0.0f, 5.0f, 10.0f, 15.0f};
    public static int NUM_CLOUDS = 100;
    ///////////////////////////////

    Cloud[] clouds;
    int phase = 0;

    void Start(){

        clouds = new Cloud[NUM_CLOUDS];

        // Spawn all of the clouds
        for(int i = 0; i < NUM_CLOUDS; i++){
            GameObject cloudObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            cloudObj.name = "Cloud";
            Cloud cloud = cloudObj.AddComponent<Cloud>();


            // Put the cloud somewhere using a random Vector3 param (in Cloud.cs)
            Vector3 startPos = new Vector3(Random.Range(-20f, 20f), Random.Range(5f, 20f), Random.Range(-20f, 20f));
            cloud.Initialize(startPos);
 
            clouds[i] = cloud;
        }
    }

    void Update(){

        if(phase <= 3 && Time.realtimeSinceStartupAsDouble >= PHASE_STARTS[phase]){
            phase++;
            Debug.Log("Entering Phase " + phase);
        }

    }
}
