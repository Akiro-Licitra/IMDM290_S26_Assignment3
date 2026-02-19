using UnityEngine;

public class LightningPos : MonoBehaviour
{
    public float targetX = 0f;

    void Update()
    {
        Vector3 p = transform.position;
        float targetX = Random.Range(-50f, 50f);

        transform.position = new Vector3(targetX, p.y, p.z);
    }
}