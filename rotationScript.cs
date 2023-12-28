using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationScript : MonoBehaviour
{
    public float horizonatalInput;
    public float vertiaclInput;
    public Vector3 scaleIn;
    public Vector3 constScale = new Vector3 (1,1,1);
    public bool isGameStarted = true;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        scaleIn = transform.localScale;
        scaleIn *= 1.02f;
        transform.localScale = scaleIn;
    }

    // Update is called once per frame
    void Update()
    {
        horizonatalInput = Input.GetAxis("Horizontal");
        vertiaclInput = Input.GetAxis("Vertical");



        if (isGameStarted == true)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * vertiaclInput * rotateSpeed);
            transform.Rotate(Vector3.up * Time.deltaTime * horizonatalInput * rotateSpeed);

            if (Input.GetKey(KeyCode.Space))
            {
                scaleIn = transform.localScale;
                scaleIn *= 1.02f;
                transform.localScale = scaleIn;
            }
            else if (scaleIn != constScale)
            {
                scaleIn = transform.localScale;
                scaleIn /= 1.02f;
                transform.localScale = scaleIn;
            }
           
        }
        if (Input.GetKeyDown(KeyCode.Q) && isGameStarted == true)
        {
            Time.timeScale = 0f;
            isGameStarted = false;
        }
        if (isGameStarted == false && Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1f;
            isGameStarted = true;
            Debug.Log("Enter Key is Pressed");
        }

    }

     


}