using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    //[SerializeField]
    //Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        GameObject[] gos;

        gos = GameObject.FindGameObjectsWithTag("Player");
        var player = gos[0];

        float distToPlayer = Vector2.Distance(transform.position, player.transform.position);

        if(distToPlayer < agroRange)
        {
            ChasePlayer(player);
        }
        else
        {
            StopChasingPlayer();
        }
        
    }

    void StopChasingPlayer()
    {
        rb2d.velocity = Vector2.zero;
    }

    void ChasePlayer(GameObject player)
    {
        if (transform.position.x < player.transform.position.x)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            if (transform.position.y < player.transform.position.y)
            {
                rb2d.velocity = new Vector2(moveSpeed, moveSpeed);
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else if (transform.position.y > player.transform.position.y)
            {
                rb2d.velocity = new Vector2(moveSpeed, -moveSpeed);
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }
        else if(transform.position.x > player.transform.position.x) 
        {
            GetComponent<SpriteRenderer>().flipX = true;
            if (transform.position.y < player.transform.position.y)
            {
                rb2d.velocity = new Vector2(-moveSpeed, moveSpeed);
                GetComponent<SpriteRenderer>().flipX = false;
            }
            else if (transform.position.y > player.transform.position.y)
            {
                rb2d.velocity = new Vector2(moveSpeed, -moveSpeed);
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }

    }
}
