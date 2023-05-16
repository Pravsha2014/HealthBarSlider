using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ShowValue : MonoBehaviour
{
    private Slider _slider;
    private TextMeshProUGUI _text;

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        _slider = GetComponentInParent<Slider>();
    }

    public void OnChanged()
    {
        int value = (int)_slider.value;
        _text.text = value.ToString();
    }
}
