using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float vel;
    public float limit;
    float rot;
    public Vector3 mousepos;
    Vector3 accel;
    public Transform posDisparo;
    public GameObject bullet;
    float life;
    public GameObject c1;
    public GameObject c2;
    public Camera viewCamera;
    public ParticleSystem explosion;
    Vector3 point;
    // Use this for initialization
    void Start () {
        vel = 1f;
        limit = 60f;
        accel = new Vector3(0,0,0);
        life = 3;
    }

    private void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "bullet" || collision.gameObject.tag == "niebla"){
            //GameObject.Find("Controlador").GetComponent<timer>().death();
            Destroy(collision.gameObject);
            life --;
            livin();
            }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet" || other.gameObject.tag == "niebla" || other.gameObject.tag == "enemy")
        {
            //GameObject.Find("Controlador").GetComponent<timer>().death();
            Destroy(other.gameObject);
            life--;
            livin();
        }

    }

    public void livin()
    {
        if (life == 2)
        {
            c1.SetActive(false) ;
            Instantiate(explosion, gameObject.transform.position,Quaternion.identity);
        }
        if (life == 1)
        {
            c2.SetActive(false);
            Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        }
        if (life == 0)
        {
            c1.SetActive(true);
            c2.SetActive(true);
            gameObject.transform.position = new Vector3(0, 0, 0);
            life = 3;
            GameObject.Find("Controlador").GetComponent<timer>().death();
            accel = Vector3.zero;
        }
    }

    void Disparo()
    {
        GameObject bulletClon = Instantiate(bullet, posDisparo.position, posDisparo.rotation) as GameObject;
    }
    // Update is called once per frame
    void Update () {
        mousepos = new Vector3(Input.mousePosition.x,0.5f,Input.mousePosition.z);
        //Vector3 movimiento = transform.rotation * Vector3.forward;

        //transform.Rotate(Vector3.up * Time.deltaTime * rot);
        transform.Translate(accel * Time.deltaTime * vel, Space.World);
        
        //GetComponent<Rigidbody>().velocity = movimiento * vel;

        if (Input.GetKey("w")) {
            accel += Vector3.forward * 8;
        }

        if (Input.GetKey("a"))
        {
            accel += Vector3.left * 8;
        }

        if (Input.GetKey("s"))
        {
            accel += Vector3.back * 8;
        }

        if (Input.GetKey("d"))
        {
            accel += Vector3.right * 8;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Disparo();
        }

        if (accel.x > limit){accel.x = limit;}else if(accel.x < -limit){accel.x = -limit;}
        if (accel.y > limit) { accel.y = limit; } else if (accel.y < -limit) { accel.y = -limit; }
        if (accel.z > limit) { accel.z = limit; } else if (accel.z < -limit) { accel.z = -limit; }

        Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayDistance;

        if (groundPlane.Raycast(ray, out rayDistance))
        {
            point = ray.GetPoint(rayDistance);
            Debug.DrawLine(ray.origin, point, Color.red);
        }
        Vector3 fixedPoint = new Vector3(point.x, transform.position.y, point.z);
        transform.LookAt(fixedPoint);
    }
}
