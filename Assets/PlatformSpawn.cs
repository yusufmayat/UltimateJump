using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject platformPrefab2;
    private GameObject myPlat;
    private GameObject myPlat2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void newPlatform()
    {
        int count = Random.Range(1, 15);
        if (transform.childCount < 18)
        {
            if (count < 13)
            {
                myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-5.5f, +5.5f), player.transform.position.y + (10 + Random.Range(0.5f, 1f))), Quaternion.identity);
                myPlat.transform.SetParent(transform);

            }
            else
            {
                myPlat2 = (GameObject)Instantiate(platformPrefab2, new Vector2(Random.Range(-5.5f, +5.5f), player.transform.position.y + (10 + Random.Range(0.5f, 1f))), Quaternion.identity);
                myPlat2.transform.SetParent(transform);
            }

        }
        
    }
}
