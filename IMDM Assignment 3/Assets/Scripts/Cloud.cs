
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float opacity;
    public float speed;
    public Vector3 direction;



    public void Initialize(float opacity, float speed, Vector3 direction){
        this.opacity = opacity;
        this.speed = speed;
        this.direction = direction;
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
