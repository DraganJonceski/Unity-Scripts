using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjects : MonoBehaviour
{
    public GameObject ItemScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && !ItemScreen.activeSelf)
            ItemScreen.SetActive(true);
        else if (Input.GetKeyDown(KeyCode.P))
            ItemScreen.SetActive(false);
    }
}
