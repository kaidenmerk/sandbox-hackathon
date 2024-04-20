using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button add;
    public Button subtract;
    public ScoreManager scoreManager;
    void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
        add.onClick.AddListener(scoreManager.AddToScore);
        subtract.onClick.AddListener(scoreManager.SubtractToScore);
    }
}
