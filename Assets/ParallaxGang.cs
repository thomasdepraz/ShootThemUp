using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxGang : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject waypoint;
    public float speed;

    private Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);

        if(Vector2.Distance(transform.position, waypoint.transform.position) >= 10)
        {
            transform.position = waypoint.transform.position;

        }
    }
}
