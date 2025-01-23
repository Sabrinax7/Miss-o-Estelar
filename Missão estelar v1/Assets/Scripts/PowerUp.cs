using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerUp : MonoBehaviour
{

    public int Score;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

            if(collider.gameObject.tag == "Player")
            {
                  GameController.instance.totalScore += Score;
                  GameController.instance.UpdateScoreText();


                 Destroy (gameObject);
            }
    }
}
