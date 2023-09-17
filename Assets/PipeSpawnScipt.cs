using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScipt : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float _timer = 0;
    public float heightOffset = 4;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer < spawnRate)
        {
            _timer = _timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            _timer = 0;
        }
        
    }

    void spawnPipe()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-heightOffset, heightOffset), 0), transform.rotation);
    }
}
