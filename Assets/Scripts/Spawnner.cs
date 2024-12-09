using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    public GameObject Goomba;
    public int goombaCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goombaCount < 6)
        {
            Instantiate(Goomba);
            goombaCount++;
        }
    }

    public void lowerCount()
    {
        goombaCount -= 1;
    }
}
