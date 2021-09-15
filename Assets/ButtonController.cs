using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public bool buttonIsEnemy = true;
    private UIController ui;

    // find scorekeeper to change score.
    void Start() {
        ui = GameObject.Find("Canvas").GetComponent<UIController>();

        if(!buttonIsEnemy) {
            Destroy(this.gameObject, 3);
        }
    }

    public void Pressed() {
        if(buttonIsEnemy) {
            ui.UpdateScore(1);
        } else {
            ui.UpdateScore(-5);
        }
        
        Destroy(this.gameObject);
    }
}
