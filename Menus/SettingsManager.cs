using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SettingsManager : MonoBehaviour
{
    public Canvas canvas;
    [SerializeField] private TextMeshProUGUI sliderText;
    public Slider FovSlider;
    void Start()
    {
         FovSlider.value = StateNameController.FovValue;
        sliderText.text = FovSlider.value.ToString();
        FovSlider.onValueChanged.AddListener((v) =>
        {
            sliderText.text = v.ToString();
        });
      
    }

        void Update()
    {
        StateNameController.FovValue = (int)FovSlider.value;
    }

}
