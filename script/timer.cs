using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{

    float time;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject nave;
    public GameObject[] enemies;

    Vector3 posnave;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void death()
    {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        for(int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        posnave = new Vector3 (nave.transform.position.x, nave.transform.position.y, nave.transform.position.z);
        time += Time.deltaTime;
        if (time >= 1)
        {
            if (Random.Range(0, 10) >= 1)
            {
                GameObject bulletClon = Instantiate(enemy1, new Vector3 (Random.Range(-208, 208),0.5f, Random.Range(-208, 208)), nave.transform.rotation) as GameObject;
            }
            time = 0;
            if (Random.Range(0, 10) >= 5)
            {
                GameObject bulletClon = Instantiate(enemy2, new Vector3(Random.Range(-208, 208), 0.5f, Random.Range(-208, 208)), nave.transform.rotation) as GameObject;
            }
            time = 0;
            if (Random.Range(0, 10) >= 8)
            {
                GameObject bulletClon = Instantiate(enemy3, new Vector3(Random.Range(-208, 208), 0.5f, Random.Range(-208, 208)), nave.transform.rotation) as GameObject;
            }
            time = 0;
        }
    }
}
