﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide_Show : MonoBehaviour
{
    public GameObject Char_Static_Mesh;
    public GameObject char_static;
    // public GameObject HardHat;
    // public GameObject OnScreenPrompt_01;
    // public GameObject OnScreenPrompt_02;
    // public GameObject HiVisVest;
    // public GameObject Boots;

    void Start() {

    }

    void Update() {
        
    }

    public void whenButton01Clicked() {
            Char_Static_Mesh.SetActive(false);

        // if (char_static.activeInHierarchy == true)
        //     char_static.SetActive(false);
        // else
        //     char_static.SetActive(true);

    }
}
