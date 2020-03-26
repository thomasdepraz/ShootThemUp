using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCorbeille : MonoBehaviour
{
    private int hp = 7;
    public GameObject projectileA;
    public GameObject projectileB;
    public GameObject projectileC;
    public float cooldown;
    bool canshoot = true;
    private Score playerScore;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = GameObject.FindGameObjectWithTag("Player").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canshoot)
        {
            StartCoroutine("ShootCooldown");
            Shoot();
        }

        if (hp <= 0)
        {
            playerScore.ScoreUp(500);
            //anim destroy
            Destroy(gameObject); //Pour l'instant
        }
    }

    private void Shoot()
    {
        GameObject ProjectileA = Instantiate(projectileA, gameObject.transform.position, Quaternion.identity);
        GameObject ProjectileB = Instantiate(projectileB, gameObject.transform.position, Quaternion.identity);
        GameObject ProjectileC = Instantiate(projectileC, gameObject.transform.position, Quaternion.identity);
    }

    IEnumerator ShootCooldown()
    {
        canshoot = false;
        yield return new WaitForSeconds(cooldown);
        canshoot = true;
    }

    public void TakeDamage()
    {
        hp--;
    }
}
