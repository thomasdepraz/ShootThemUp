using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    public float radius = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 1, 0) * Time.deltaTime * bulletSpeed;

        Collider2D[] hit = Physics2D.OverlapCircleAll(gameObject.transform.position, radius);
        foreach (Collider2D cols in hit)
        {
            if (cols.gameObject.CompareTag("Enemy"))
            {
                cols.gameObject.GetComponent<EnemyPistol>().TakeDamage();
                Destroy(gameObject);
            }
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
