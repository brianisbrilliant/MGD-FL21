using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistController : MonoBehaviour
{
    public float lifeSpan = 0.2f;

    void Start() {
        Destroy(this.gameObject, lifeSpan);
    }

    // make sure your collider is a trigger!
    void OnTriggerEnter(Collider other) {
        Debug.Log("<color=red>I've hit " + other.name + "!</color>");
        if(other.gameObject.CompareTag("Enemy")) {
            Debug.Log("<color=green>I've hit an enemy!</color>");
            Destroy(other.gameObject);
        }
    }
}
