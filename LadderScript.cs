using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderScript : MonoBehaviour {

    public float ladderSpeed = 3;

    void OnTriggerStay2D(Collider2D other) {
        if(other.tag=="Player" && Input.GetKey(KeyCode.UpArrow)) {

            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, ladderSpeed);

        } else if (other.tag == "Player" && Input.GetKey(KeyCode.DownArrow)) {

            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -ladderSpeed);

        } else {
            other.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0.2f);
        }
    }
}
