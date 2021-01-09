using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    float xMoveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <=0)
            {
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 500f);
            }
        }


    }
}
//public float jumpForce = 10f;

  //  void OnCollisionEnter2D(Collision2D collision)
    //{
      //  if (collision.relativeVelocity.y <= 0f)
        //{
          //  Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            //if (rb != null)
            //{
              //  Vector2 velocity = rb.velocity;
                //velocity.y = jumpForce;
                //rb.velocity = velocity;
            //}
        //}


    //}