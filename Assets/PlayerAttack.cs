using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float distance = 4;

    public GameObject fistPrefab;

    public void Attack() {
        Debug.Log("Attack!");
        // pseudocode
        // spawn a "fist" some distance in front of the player
        GameObject newFist = Instantiate(fistPrefab, this.transform.position, this.transform.rotation);
        newFist.transform.Translate(Vector3.right * distance);
        // let the fist see if it is colliding with an enemy
        // if it is, destroy the enemy and the fist
        // if it isn't, destroy the fist.
        // maybe a cooldown later.
    }
}
