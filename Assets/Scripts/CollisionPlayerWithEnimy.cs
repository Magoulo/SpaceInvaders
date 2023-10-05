using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerWithEnimy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Monster" || collision.gameObject.tag == "Boss")
        {
            GameController.GameOver = true;
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
