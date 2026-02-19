
using UnityEngine;

public class Cloud : MonoBehaviour {
    private Vector3 origin;        
    private float x_offset, y_offset, z_offset;

    /* Feel free to change these */
    public float move_radius = 3f;
    public float move_speed = 0.2f;
    ///////////////////////////////

    public void Initialize(Vector3 startPosition){

        // Where does the ball start?
        origin = startPosition;
        transform.position = startPosition;

        // How does the ball move?
        x_offset = Random.Range(0f, 999f);
        y_offset = Random.Range(0f, 999f);
        z_offset = Random.Range(0f, 999f);
    }

    void Update(){
        float t = Time.time * move_speed;


        /* Perlin Noise: 
            https://adrianb.io/2014/08/09/perlinnoise.html  
                --> Perfect for clouds
        */

        // This implementation returns [0,1] but we want [-1,1]
        float dx = (Mathf.PerlinNoise(x_offset, t) - 0.5f) * 2f;
        float dy = (Mathf.PerlinNoise(y_offset + 100f, t) - 0.5f) * 2f;
        float dz = (Mathf.PerlinNoise(z_offset + 200f, t) - 0.5f) * 2f;

        transform.position = origin + new Vector3(dx, dy, dz) * move_radius;
    }
}
