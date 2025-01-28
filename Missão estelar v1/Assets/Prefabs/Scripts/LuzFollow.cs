using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzFollow : MonoBehaviour
{
    public Transform Player;
     
    private void FixedUpdat()
    {
        transform.position = Vector2.Lerp(transform.position, Player.position, 0.1f);
    }
}
