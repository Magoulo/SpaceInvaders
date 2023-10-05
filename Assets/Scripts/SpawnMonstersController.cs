using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonstersController : MonoBehaviour
{
    public GameObject trump;
    public GameObject putin;
    public GameObject peppe;
    public GameObject jasmin;
    public static bool bossTime = false;
    public float spawnInterval = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnMonster", spawnInterval, spawnInterval);
    }

    void spawnMonster()
    {
        GameController.Kill = false;
        float myRan = Random.value;
        if (bossTime)
        {
            Debug.Log("Boss Time!");
            if (myRan < 0.05)
            {
                GameObject g = Instantiate(peppe, transform.position, Quaternion.identity);
            }
            else if (myRan < 0.1)
            {
                GameObject g = Instantiate(jasmin, transform.position, Quaternion.identity);
            }
            else if (myRan < 0.2)
            {
                GameObject g = Instantiate(trump, transform.position, Quaternion.identity);
            }
            else if (myRan < 0.3)
            {
                GameObject g = Instantiate(putin, transform.position, Quaternion.identity);
            }
        }
        else
        {
            if (myRan < 0.15)
            {
                GameObject g = Instantiate(trump, transform.position, Quaternion.identity);
            }
            else if (myRan < 0.3)
            {
                GameObject g = Instantiate(putin, transform.position, Quaternion.identity);
            }
            else
            {

            }
        }
    }

}
