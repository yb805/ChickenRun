﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverScene : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("DemoDay");
    }
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }
}
