using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
   public int Score;
    private SpriteRenderer sr;
    private CircleCollider2D circle;

    
    
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
        
    }

  

    void OnTriggerEnter2D(Collider2D collider)
    {

            if(collider.gameObject.tag == "Player")
            {
                
                  sr.enabled = false;
                  circle.enabled = false;
                  GameController.instance.totalScore += Score;
                  GameController.instance.UpdateScoreText();


                 Destroy (gameObject, 2f);
            }
    }
}
