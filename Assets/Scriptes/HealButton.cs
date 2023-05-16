using UnityEngine;

public class HealButton : MonoBehaviour
{
    [SerializeField] private Health _health;

    private readonly int _healValue = 10;

    public void OnButtonClick()
    {
        _health.ChangeHealth(_healValue);
    }
}
