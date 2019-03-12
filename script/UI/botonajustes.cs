using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botonajustes : MonoBehaviour {
    public void OnClick()
    {
        Debug.Log("algo");
        SceneManager.LoadScene("OPCIONES");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
