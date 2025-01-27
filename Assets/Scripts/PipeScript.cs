using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float speed = 1f;
    public float deadZone = -60;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe destroyed");
            Destroy(gameObject);
        }
    }
}
