using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chncleta : MonoBehaviour
{
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
            Debug.Log("ok");
        }
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 movimiento = transform.rotation * Vector3.forward;
        transform.Translate(movimiento * Time.deltaTime * 50, Space.World);
        time += Time.deltaTime;
        if (time > 2)
        {
            Destroy(gameObject);
            time = 0;
        }
    }
}
