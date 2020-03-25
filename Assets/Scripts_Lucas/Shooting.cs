using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float cooldown;
    public GameObject bullet;
    bool canshoot = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && canshoot == true)
        {
            StartCoroutine(ShootCooldown());
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject Bullet = Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
    }
    IEnumerator ShootCooldown()
    {
        canshoot = false;
        yield return new WaitForSeconds(cooldown);
        canshoot = true;
    }
}
