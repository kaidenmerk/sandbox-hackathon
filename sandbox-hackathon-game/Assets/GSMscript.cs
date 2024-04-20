using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GSMscript : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer = 0;
    public float stop = 15;
    public GameObject spawner;
    void Start()
    {
        Instantiate(spawner, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
     
        timer += Time.deltaTime;
    }


}
