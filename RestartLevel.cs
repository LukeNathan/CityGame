using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform playerSprite;
    public float offset = 3.02f;

    void Update() {
        transform.position = new Vector3(playerSprite.position.x, playerSprite.position.y + offset, transform.position.z);
    }
}
