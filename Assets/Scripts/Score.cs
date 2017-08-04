using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    public GameObject NextUI;


    public static int pincount ;
    public Text text;
    private void Start()
    {
        pincount = 0;
    }
    public void Update()
    {
        text.text = pincount.ToString();
        if (pincount >10)
        {
            NextUI.SetActive(true);
        }
    }
}
