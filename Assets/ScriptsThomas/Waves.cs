using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{
    public GameObject nextWave;
    private bool canStartCoroutine = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(gameObject.transform.childCount == 0 && canStartCoroutine)
       {
            StartCoroutine("NextWave");
       }
    }

    private IEnumerator NextWave()
    {
        canStartCoroutine = false;
        yield return new WaitForSeconds(2);
        nextWave.SetActive(true);
        Destroy(gameObject);
    }
}
