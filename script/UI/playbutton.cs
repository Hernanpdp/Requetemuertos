﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnClick()
    {
        Debug.Log("algo");
        SceneManager.LoadScene("scene.v.3");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
