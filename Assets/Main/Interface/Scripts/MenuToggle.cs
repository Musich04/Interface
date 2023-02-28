using UnityEngine;
using UnityEngine.UI;
using System;

[RequireComponent(typeof(Toggle))]
public abstract class MenuToggle : MonoBehaviour, IActivity
{
    public event Action OnChanged;
    protected Toggle _toggle => GetComponent<Toggle>();

    public virtual void ChangeValue(bool value) // to toggle
    {
        OnChanged?.Invoke();
    }

    public void Show() => _toggle.isOn = true;
    public void Hide() => _toggle.isOn = false;
    public bool IsOn() => _toggle.isOn;
}
