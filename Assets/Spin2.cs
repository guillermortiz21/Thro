﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin2 : MonoBehaviour
{
    
    public float spinValue = 90;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(2,0,0);
    }

    public void flipSpin(){
        spinValue = -spinValue;
    }
}
