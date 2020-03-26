using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiShot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Score playerScore;
    public GameObject ennemiShot;
    public float timeBetweenShots;
    public float offset = 0.1f;
    bool canshoot =true ;
    public float angle;
    private int hp = 5;

    public AudioSource shotgunAudioSource;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerScore = player.GetComponent<Score>();
        shotgunAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetdir = player.transform.position - gameObject.transform.position;
        if (player.transform.position.x >=0)
        {
            angle = -Vector3.Angle(targetdir, gameObject.transform.position);
        }
        else
        {
            angle = Vector3.Angle(targetdir, gameObject.transform.position);
        }
        
        if (canshoot == true)
        {
            shotgunAudioSource.Play();
            Instantiate(ennemiShot, transform.position, Quaternion.Euler(0,0,angle));
            Instantiate(ennemiShot, transform.position, Quaternion.Euler(0, 0, angle- offset));
            Instantiate(ennemiShot, transform.position, Quaternion.Euler(0, 0, angle + offset));

            
            StartCoroutine(cooldown());
        }

        if (hp <= 0)
        {
            playerScore.ScoreUp(250);
            //anim destroy
            Destroy(gameObject); //Pour l'instant
        }
    }
    IEnumerator cooldown()
    {
        canshoot = false;
        yield return new WaitForSeconds(timeBetweenShots);
        canshoot = true;
    }
    public void TakeDamage()
    {
        hp--;
    }
}
