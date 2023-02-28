using UnityEngine;
using System;

public class ActivityToggle : MenuToggle
{
    public CheckBox CheckBox => transform.parent.GetComponent<CheckBox>();

    private void Start()
    {
        ChangeValue(_toggle.isOn);
    }

    public override void ChangeValue(bool value)
    {
        CheckBox.ChangeEnabler(value);
        base.ChangeValue(value);
    }
}
