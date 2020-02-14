﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public Vector3 mousePos;
    public float limit = 4;
    public float speed = 2;
    float distance;
    public float distanceMin = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //position de la souris (vector3)
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //vecteur entre le personnage et la souris
        Vector3 direction = mousePos - gameObject.transform.position ;
        direction = direction.normalized;
        //distance entre le joueur et la souris (float)
        distance = Vector3.Distance(gameObject.transform.position, mousePos);
        direction.z = transform.position.z;

        //si la distance entre la souris et le joueur est supérieure à la distance min choisie il peut se déplacer
        if (distance>distanceMin && transform.position.y<=limit)
        {
            gameObject.transform.position += direction * Time.deltaTime * speed;
            if (transform.position.y > 4)
            {
                transform.position = new Vector3 (transform.position.x,limit,transform.position.z);
            }
        }
        
    }
}
