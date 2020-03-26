using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiBulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    private GameObject player;
    private Lives playerLives;
    public float radius = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerLives = player.GetComponent<Lives>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += transform.up *bulletSpeed* Time.deltaTime;

        Collider2D[] hit = Physics2D.OverlapCircleAll(gameObject.transform.position, radius);
        foreach (Collider2D cols in hit)
        {
            if (cols.gameObject.CompareTag("Player"))
            {
                playerLives.LifeDown();
                Destroy(gameObject);
            }
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
