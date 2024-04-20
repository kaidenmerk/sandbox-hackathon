using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
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
    public float spawnrate = 0.5F;
    public int spawnCount = 0;
    public Vector3[] locations;
    public bool spawnIn = true;
    System.Random rand = new();
    
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
        locations = new Vector3[6];
        locations[0] = new Vector3(-12, 1.8F, 0);
        locations[1] = new Vector3(-12, 0, 0);
        locations[2] = new Vector3(-12, -2, 0);
        locations[3] = new Vector3(12, 1.8F, 0);
        locations[4] = new Vector3(12, 0, 0);
        locations[5] = new Vector3(12, -2, 0);

    }

    // Update is called once per frame
    void Update()
    {

        //If timer < spawnrate, add delta time to timer
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        // Set spawnIn to false in GameManager when game period ends
        else
        {
            if (spawnIn)
            {
                spawn(spawnCount % 7);
                timer = 0;
                spawnCount++;
                spawnrate = (float) rand.NextDouble();
            }
        }

    }

    // spawns character given index and orientation
    void spawn(int index)
    {
        // Selects what sprite to use
        GameObject sprite = sprites[index];
        // Chooses where to spawn
        int orientation = UnityEngine.Random.Range(0, 100);

        if (orientation >= 50)
        {
            // Change transformation.position to coordinates right outside left of screen
            GameObject s = Instantiate(sprite, locations[orientation % 3], transform.rotation);
        }
        else
        {
            // Change transformation.position to coordinates right outside right of screen
            GameObject s = Instantiate(sprite, locations[(orientation % 3)+ 3], transform.rotation);
        }
    }

    //Create function that takes integer i that represents the lane to spawn in a sprite, size accordingly

}
