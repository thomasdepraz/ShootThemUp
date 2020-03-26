using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorbeilleProjectile : MonoBehaviour
{

    private GameObject player;
    private Lives playerLives;
    public float radius = 0.1f;
    public float lifeSpan = 5f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerLives = player.GetComponent<Lives>();
        StartCoroutine("LifeSpan");
    }

    // Update is called once per frame
    void Update()
    {
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

    private IEnumerator LifeSpan()
    {
        yield return new WaitForSeconds(lifeSpan);
        Destroy(gameObject);
    }
}
