using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI outText;
    public Slider slider1;
    public Dropdown dropdown1;
    public void ButtonAction1()
    {
        outText.text = "Button Clicked";
    }

    public void SliderAction1()
    {
        outText.text = "Slider: " + slider1.value.ToString("F2");
    }

    public void DropdownAction1()
    {
        outText.text = "Dropdown: " + dropdown1.value;
    }
}
