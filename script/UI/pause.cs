using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnClick()
    {
        SceneManager.LoadScene("PAUSA");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
