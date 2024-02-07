using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForText : MonoBehaviour
{
    public Text textField;
    public float timerx;
    // Start is called before the first frame update
    void Start()
    {
        //textField = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        timerx+=Time.deltaTime;
        textField.text = ("Time") + timerx.ToString();
    }
}
