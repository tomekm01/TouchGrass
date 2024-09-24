using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSpawnerScript : MonoBehaviour
{

    public GameObject grass;

    public float spawnRate;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        grass.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(grass, transform.position, transform.rotation);
            timer = 0;
        }

    }
}
