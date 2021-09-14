using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    // todo, find scorekeeper and change score.

    public void Pressed() {
        Destroy(this.gameObject);
    }
}
