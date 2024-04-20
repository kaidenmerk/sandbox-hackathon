using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteSpawnerScript : MonoBehaviour
{
    public GameObject backpack;
    public GameObject guy;
    public GameObject guitar;
    public GameObject greenHair;
    public GameObject headphones;
    public GameObject horns;
    public GameObject monk;
    public GameObject roller;
    public GameObject[] sprites;
    public float timer = 0;
    public float spawnrate = 6;
    // Start is called before the first frame update
    void Start()
    {
        sprites[0] = backpack;
        sprites[1] = guy;
        sprites[2] = guitar;
        sprites[3] = greenHair;
        sprites[4] = headphones;
        sprites[5] = horns;
        sprites[6] = monk;
        sprites[7] = roller;
    }

    // Update is called once per frame
    void Update()
    {

        //If timer < spawnrate, add delta time to timer

        // Else, spawn in a random character, reset timer to 0
        
    }
}
