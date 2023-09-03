using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i = 3;
    private int randomBlueInt;

    // Start is called before the first frame update
    void Start()
    {
        randomBlueInt = Random.Range(150, 251);// 251 is exclusive
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if (gameObject.CompareTag("Red") && i == 100)

        {
            gameObject.SetActive(false);
        }

        else if (gameObject.CompareTag("Blue") && i == randomBlueInt)
        {
            rend.enabled = false;
        }
    }   
}
