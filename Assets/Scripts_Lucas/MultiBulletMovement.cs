﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiBulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += transform.up *bulletSpeed* Time.deltaTime;
    }
}
