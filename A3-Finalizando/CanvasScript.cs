using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    GameObject Player;
    public GameObject groundPrefeb;
    public Text scoreText;
    public int score = 0;
    void Start()
    {
        Instantiate(groundPrefeb, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(groundPrefeb, new Vector3(-6.0f, 3.0f, 0), Quaternion.identity);
        Instantiate(groundPrefeb, new Vector3(6.0f, -3.0f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        
    }
}
