using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPistol : MonoBehaviour
{
    private int hp = 3;
    public GameObject projectile;
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

        if(hp<=0)
        {
            playerScore.ScoreUp(100);
            //anim destroy
            Destroy(gameObject); //Pour l'instant
        }
    }

    private void Shoot()
    {
        GameObject Projectile = Instantiate(projectile, gameObject.transform.position, Quaternion.identity);
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

