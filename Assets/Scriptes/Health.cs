using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    private readonly int _minHealth = 0;
    private readonly int _maxHealth = 100;
    private int _health;

    public event UnityAction OnHealthChanged;

    public int HealthPoint => _health;

    private void Awake()
    {
        _health = _maxHealth;
    }

    public void ChangeHealth(int value)
    {
        _health = Mathf.Clamp(_health + value, _minHealth, _maxHealth);

        OnHealthChanged?.Invoke();
    }
}
