﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public float lifetime;
    void Start()
    {
        Destroy (gameObject, lifetime);
    }
}
