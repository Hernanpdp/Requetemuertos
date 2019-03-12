using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour
{
    float time;
    public GameObject nave;
    public Vector3 navepos;
    public GameObject shootin;
    public Transform posshootin;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        nave = GameObject.Find("ricardo");
    }

    void shoot()
    {
        GameObject bulletClon = Instantiate(shootin, posshootin.position, posshootin.rotation) as GameObject;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 shooterpos = new Vector3(this.transform.position.x,0.5f, this.transform.position.z);
        navepos = new Vector3(nave.transform.position.x, 0.5f, nave.transform.position.z);
        transform.LookAt(navepos);



        if (Vector3.Distance(navepos,shooterpos)<100)
        {
            time += Time.deltaTime;
            if (time > 1)
            {
                shoot();
                time = 0;
            }
        }
        else
        {
            Vector3 movimiento = transform.rotation * Vector3.forward;
            GetComponent<Rigidbody>().velocity = movimiento * 10;
        }

    }
}
