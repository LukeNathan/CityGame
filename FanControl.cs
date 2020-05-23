using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanControl : MonoBehaviour { 

    public float fanSpeed = 5;

    void OnTriggerStay2D(Collider2D other) {
        if (other.tag == "Player") {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, fanSpeed);
        }
    }
}
