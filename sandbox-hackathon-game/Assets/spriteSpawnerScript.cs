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
    public int spawnCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        sprites = new GameObject[7];
        sprites[0] = backpack;
        sprites[1] = guy;
        sprites[2] = guitar;
        sprites[3] = greenHair;
        sprites[4] = headphones;
        sprites[5] = horns;
        sprites[6] = monk;
    }

    // Update is called once per frame
    void Update()
    {

        //If timer < spawnrate, add delta time to timer
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        // Else, spawn in a character, reset timer to 0. Change spawncount % from 7 to 8 if roller works
        else {
            spawn(spawnCount % 7);
            timer = 0;
            spawnCount++;
        }
        
    }

    // spawns character given index and orientation
    void spawn(int index)
    {
        GameObject sprite = sprites[index];
        bool orientation = Random.Range(0, 100) >= 50;

        if(orientation)
        {
            //Change transformation.position to coordinates right outside left of screen
            Instantiate(sprite, transform.position, transform.rotation);

        }

        else {
            //Change transformation.position to coordinates right outside right of screen
            Instantiate(sprite, transform.position, transform.rotation);
        }
    }
}
