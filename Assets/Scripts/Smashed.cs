using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smashed : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathBall")
        {
            Destroy(gameObject);
        } 
    }
}
