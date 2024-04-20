using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GSMscript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawner;
    void Start()
    {
        Instantiate(spawner, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
     
    }


}
