using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GSMscript : MonoBehaviour
{
    // Start is called before the first frame update
    public spriteSpawnerScript spawner;
    float timer = 0;
    public int spawned;
    void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("spawner").GetComponent<spriteSpawnerScript>();
    }

    // Update is called once per frame
    void Update()
    {
     while (timer < 20)
        {
            timer += Time.deltaTime;
        }
        spawned = spawner.spawnCount;
    }

    int getSpawned()
    {
        return spawned;
    }

}
