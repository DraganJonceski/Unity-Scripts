using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class ModalWindowPanel : MonoBehaviour
{
    [Header("Header")]
    [SerializeField]
    private Transform headerArea;
    [SerializeField]
    private TextMeshProUGUI titlefield;
    [Header("Content")]
    [SerializeField]
    private Transform contentArea;
   // [SerializeField] private Transform varticalLayoutArea; [SerializeField] private Image heroImage;[SerializeField] private TextMeshProUGUI heroText; //[Space()]
    [SerializeField]
    private Transform horizontalLayoutArea;
    [SerializeField]
    private Image popUpImage;
    [SerializeField]
    private TextMeshProUGUI popUpText;
    [SerializeField]
    private Transform iconContainer;

    [Header("Footer")]
    [SerializeField]
    private Transform footerArea;
    [SerializeField]
    private Button confirmButton;
    [SerializeField]
    private Button declineButton;

    private Action _confirmAction;
    private Action _declineAction;

    public static bool[] isInOrder = { false, false, false };
    
    public void ShowAsPrompt(string title, Image icon, string message )
    {
        LeanTween.cancel(gameObject);

        horizontalLayoutArea.gameObject.SetActive(true);

      //  bool hasTitle = string.IsNullOrEmpty(title);
      //  headerArea.gameObject.SetActive(hasTitle);
        titlefield.text = title;

        popUpImage = icon;
        popUpText.text = message;
        isInOrder[0] = true;
        isInOrder[1] = true;
        isInOrder[2] = true;


    }

    public void Confirm()
    {
       // _confirmAction?.Invoke();
        gameObject.SetActive(false);
        isInOrder[0] = true;
        Cursor.lockState = CursorLockMode.Locked;
        Debug.Log((isInOrder[0]));
    }

    public void Decline()
    {
       // _declineAction?.Invoke();
        gameObject.SetActive(false);
         Cursor.lockState = CursorLockMode.Locked;
    }
}
