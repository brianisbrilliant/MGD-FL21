using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [Tooltip("The object you would like to follow.")]
    public Transform target;
    
    [Tooltip("If your camera doesn't stay where you set it, flip this.")]
    public bool flipPerspective = false;

    [Tooltip("Does the camera need to change height? If so, make this false.")]
    public bool staticHeight = true;

    float yPos;
    float zPos;
    float xOffset;

    // Start is called before the first frame update
    void Start()
    {
        yPos = this.transform.position.y;
        zPos = this.transform.position.z;
        if(flipPerspective) {
            xOffset = target.position.x - this.transform.position.x;
        } else {
            xOffset = this.transform.position.x - target.position.x;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.position;
        
        // capture our current position as a variable
        Vector3 newPos = this.transform.position;

        // change the yPosition of newPos
        if(staticHeight) newPos.y = yPos;
        newPos.z = zPos;
        newPos.x += xOffset;
        
        // assign our position to the newPosition
        this.transform.position = newPos;
    }
}
