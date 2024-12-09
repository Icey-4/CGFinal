using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float xPos;
    float yPos;
    public float sen;
    Vector3 oldPos;
    public GameObject killBox;
    bool on = false;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isOn();
        }

        oldPos = transform.position; 
        xPos = Input.GetAxis("Mouse X");
        yPos = Input.GetAxis("Mouse Y");

        transform.position = oldPos + new Vector3(xPos, yPos, 0f) * sen;
    }

    void isOn()
    {
        switch(on)
        {
            case true:
                killBox.SetActive(true);
                on = false;
                break;

            case false:
                killBox.SetActive(false);
                on = true;
                break;
        }
     
    }

}
