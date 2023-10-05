using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerBulletController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(),GetComponent<Collider2D>());
        } else
        {
            Destroy(gameObject);
            if(collision.gameObject.tag != "Wall")
            {
                if(collision.gameObject.tag == "Monster")
                {
                ScoreController.Score += 1;
                GameController.Kill = true;
                } 
                if (collision.gameObject.tag == "Boss")
                {
                    ScoreController.Score += 3;
                    GameController.Kill = true;
                } 
                      
                Destroy(collision.gameObject);
            }
        }
    }
}
