using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GSMscript : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer = 0;
    public float stop = 10;
    textFadeScript fs;
    spriteSpawnerScript spawner;
    void Start()
    {
        fs = GetComponent<textFadeScript>();
        spawner = GetComponent<spriteSpawnerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > stop)
        {
            spawner.spawnIn = false;
            fs.textComponent.text = "Round Over!";
            fs.FadeInText();
        }
        timer += Time.deltaTime;
    }


}
