using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class atras : MonoBehaviour {

    public void OnClick()
    {
        Debug.Log("algo");
        SceneManager.LoadScene("MENU");
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
