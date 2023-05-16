using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    private readonly float _duration = 1f;
    private Health _health;
    private Slider _slider;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _health = GetComponentInParent<Health>();

        _slider.value = _health.HealthPoint;
        _health.OnHealthChanged += DrawBar;
    }

    private void OnDisable()
    {
        _health.OnHealthChanged -= DrawBar;
    }

    private void DrawBar()
    {
        _slider.DOValue(_health.HealthPoint, _duration);
    }
}