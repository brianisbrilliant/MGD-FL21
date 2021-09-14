using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButtons : MonoBehaviour
{
    [SerializeField] private Vector2 screenBounds;
    [SerializeField] private bool debug = true;
    [SerializeField] GameObject[] buttons;

    Transform canvas;

    // Start is called before the first frame update
    void Start()
    {
        // TODO find screen bounds and set them

        canvas = GameObject.Find("Canvas").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(debug && Input.GetKeyDown(KeyCode.B)) {
            // create a button at a random spot within the bounds
            Vector3 newPos = new Vector3(Random.Range(-screenBounds.x, screenBounds.x),
                                        Random.Range(-screenBounds.y, screenBounds.y),
                                        0);
            Transform btn = Instantiate(buttons[Random.Range(0,buttons.Length)], newPos, Quaternion.identity).transform;
            btn.SetParent(canvas);
        }
    }

    public void ButtonPressed(GameObject button) {
        Destroy(button);
    }
}
