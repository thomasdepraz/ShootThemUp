using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementKeyboard : MonoBehaviour
{
    [Header("Logic")]
    private float horizontalMovement;
    private float verticalMovement;
    private Vector2 direction;
    public Rigidbody2D rb;

    [Header("Tweaks")]
    [Range(0f, 5f)]
    public float speedModifier = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(horizontalMovement != 0 && verticalMovement !=0)
        {
            //il se passe des trucs
        }
        rb.velocity = direction * Time.deltaTime * speedModifier;

    }

    private void GetInput()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        direction = new Vector2(horizontalMovement, verticalMovement).normalized;
    }
}
