using UnityEngine;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Health _health;

    private readonly int _damageValue = -10;

    public void OnButtonClick()
    {
        _health.ChangeHealth(_damageValue);
    }
}
