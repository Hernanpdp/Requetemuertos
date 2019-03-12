using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootmove : MonoBehaviour
{
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movimiento = transform.rotation * Vector3.forward;
        transform.Translate(movimiento * Time.deltaTime * 50, Space.World);
        timer += Time.deltaTime;
        if (timer > 2)
        {
            Destroy(gameObject);
            timer = 0;
        }
    }
}
