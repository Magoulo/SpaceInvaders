using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{
    public GameObject bullet;
    private float startShooting = 1f;
    public float shootingInterval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shootBullet", startShooting, shootingInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void shootBullet()
    {
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
