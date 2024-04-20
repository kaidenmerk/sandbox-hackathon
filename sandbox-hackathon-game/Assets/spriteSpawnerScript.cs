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
    public float[,] locations;
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
        // Define Locations -12/12 , (1.8, 0, -2), 0

        //Define X
        locations = new float[6, 3];
        locations[0, 0] = -12;
        locations[1, 0] = -12;
        locations[2, 0] = -12;
        locations[3, 0] = 12;
        locations[4, 0] = 12;
        locations[5, 0] = 12;

        // Define Y
        locations = new float[6, 3];
        locations[0, 1] = 1.8F;
        locations[1, 1] = 0;
        locations[2, 1] = -2;
        locations[3, 1] = 1.8F;
        locations[4, 1] = 0;
        locations[5, 1] = -2;
        //Define Z
        locations = new float[6, 3];
        locations[0, 2] = 0;
        locations[1, 2] = 0;
        locations[2, 2] = 0;
        locations[3, 2] = 0;
        locations[4, 2] = 0;
        locations[5, 2] = 0;

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
        else
        {
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

        if (orientation)
        {
            //Change transformation.position to coordinates right outside left of screen
            GameObject s = Instantiate(sprite, new Vector3(locations[index % 3, 0], locations[index % 3, 1], 0), transform.rotation);
        }

        else
        {
            //Change transformation.position to coordinates right outside right of screen
            GameObject s = Instantiate(sprite, new Vector3(locations[index % 3 + 3, 0], locations[index % 3, 1] + 3, 0), transform.rotation);

        }
    }

    //Create function that takes integer i that represents the lane to spawn in a sprite, size accordingly
    
}
