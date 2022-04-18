using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunnerAlert : MonoBehaviour
{
    public Text text;
    //private GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.FindWithTag("MainCanvas").GetComponents<Text>()[0];
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Runner is comming";
    }
}
