using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D col;
    private Vector2 direction;
    private GameObject player;
    private Lives playerLives;
    public float radius = 0.1f;
    [Range (0f,5f)]
    public float speed = 1f;
    public float lifeSpan = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerLives = player.GetComponent<Lives>();

        direction = player.transform.position - gameObject.transform.position;
        rb.velocity = direction.normalized * speed;
        StartCoroutine("LifeSpan");
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] hit = Physics2D.OverlapCircleAll(gameObject.transform.position, radius);
        foreach(Collider2D cols in hit)
        {
            if(cols.gameObject.CompareTag("Player"))
            {
                playerLives.LifeDown();
                Destroy(gameObject);
            }
        }
    }

    private IEnumerator LifeSpan()
    {
        yield return new WaitForSeconds(lifeSpan);
        Destroy(gameObject);
    }



}
