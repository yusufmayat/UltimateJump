using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public PlatformSpawn platformSpawn;
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject platformPrefab2;
    private GameObject myPlat;
    private GameObject myPlat2;
    public GameObject LOS1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("NormalBlock"))
        {
            if (Random.Range(1, 15) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab2, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (3 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
            }
            else
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (3 + Random.Range(0.2f, 1.0f)));
                if (Random.Range(1, 15) == 1) 
                {
                    Instantiate(LOS1, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (4 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
                }
            }

        }
        else if (collision.gameObject.name.StartsWith("Bouncy"))
        {
            if (Random.Range(1, 15) == 1)
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (3+ Random.Range(0.2f, 1.0f)));
            }
            else
            {
                Destroy(collision.gameObject);
                Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (3 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
                if (Random.Range(1,15)== 1) 
                {
                    Instantiate(LOS1, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (4 + Random.Range(0.2f, 1.0f))), Quaternion.identity);
                }

            }

        }
        else
        {
            Destroy(collision.gameObject);
        }
        
        
        
        
        
        
        //if (platformPrefab != null)
        //{
          //  platformSpawn.newPlatform();
            //Destroy(collision.gameObject);

        //}
        //if (platformPrefab2 != null)
        //{
          //  platformSpawn.newPlatform();
            //Destroy(collision.gameObject);
        //}
    }
}
