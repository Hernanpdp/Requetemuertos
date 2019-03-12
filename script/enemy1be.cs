using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1be : MonoBehaviour
{
    public GameObject nave;
    public Vector3 navepos;
    // Start is called before the first frame update
    void Start()
    {
        nave = GameObject.Find("ricardo");
    }

    // Update is called once per frame
    void Update()
    {
        navepos = new Vector3(nave.transform.position.x, 0.5f, nave.transform.position.z);
        transform.LookAt(navepos);
        Vector3 movimiento = transform.rotation * Vector3.forward;
        transform.Translate(movimiento * Time.deltaTime * 50, Space.World);
    }
}
