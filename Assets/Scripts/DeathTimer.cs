using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTimer : MonoBehaviour {

    public float deathTime = 5;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject, deathTime);
    }
}
