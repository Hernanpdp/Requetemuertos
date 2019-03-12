using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particledeath : MonoBehaviour
{
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(90, 0, 0);
        GetComponent<SphereCollider>().radius = 1;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        GetComponent<SphereCollider>().radius = timer*80;
        if (timer > 0.5f)
        {
            Destroy(gameObject);
            timer = 0;
        }
    }
}
