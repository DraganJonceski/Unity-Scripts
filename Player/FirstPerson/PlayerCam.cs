using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCam : MonoBehaviour
{
   

    public float sensX;
    public float sensY;
    public Camera maincam;
    public Transform orientation;
   
    float xRotation;
    float yRotation;
    // Start is called before the first frame update
    void Start()
    {
        maincam.fieldOfView = StateNameController.FovValue;
        
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log(Input.mousePosition);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;

            SceneManager.LoadScene("Menu");

        }
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensX;

        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        if (transform != null && orientation != null)
        {
            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
            orientation.rotation = Quaternion.Euler(0, yRotation, 0);
        }
    }
}
