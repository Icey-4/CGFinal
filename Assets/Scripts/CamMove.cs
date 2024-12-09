using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    float inputAxis = 0f;
    float mouseX; 
    float mouseY;
    public float sen;
    Quaternion moving;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        moving = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {


        mouseX = Input.GetAxis("Mouse X") * sen;
        mouseY = Input.GetAxis("Mouse Y") * sen * Time.deltaTime;

        mouseY = Mathf.Clamp(mouseY, -90f, 90f);
        inputAxis -= mouseY;
        moving = Quaternion.Euler(0f, 0f, 0f);


    }
}
