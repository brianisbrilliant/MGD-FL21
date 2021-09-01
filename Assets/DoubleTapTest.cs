using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTapTest : MonoBehaviour
{
    public float interval = 0.5f;

    int tapCount = 0;
    float lastTapTime = 0;
    bool cubeIsLarge = false;
    
    void Start()
    {
        Debug.Log("<color=cyan>DoubleTapTest</color> Starting");
        print("I exist");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            // combined assignment operator.
            tapCount += 1;
            Debug.Log("I've been tapped " + tapCount + " time(s)!");

            // Time.realtimeSinceStartup
            if(lastTapTime > Time.realtimeSinceStartup - interval) {
                // doubleTap! Turn cube Red
                print("DOUBLETAP");

                if(cubeIsLarge) {
                    this.transform.localScale = Vector3.one;
                }
                else {
                    this.transform.localScale = Vector3.one * 2;
                }
                cubeIsLarge = !cubeIsLarge;

                lastTapTime = 0;        //reset taptimer
            }
            else {
                print("SINGLETAP");
                this.GetComponent<Renderer>().material.color = Random.ColorHSV();
                lastTapTime = Time.realtimeSinceStartup;
            }
        }// end of if (we pressed mouse0)
    }
}
