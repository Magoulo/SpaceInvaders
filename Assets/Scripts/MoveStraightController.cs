using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraightController : MonoBehaviour
{
    public Vector2 velocity;
    private Rigidbody2D rigidbodyBullet;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyBullet = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigidbodyBullet.velocity = velocity;
    }
}
