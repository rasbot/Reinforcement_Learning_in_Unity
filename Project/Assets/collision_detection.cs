﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_detection : MonoBehaviour
{
    PuncherAgent puncher;

    void Start()
    {
        puncher = GetComponentInParent<PuncherAgent>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target")
        {
            puncher.setIsHitting(true);
        }
	}

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Target")
        {
            puncher.setIsHitting(false);
        }
    }
}
