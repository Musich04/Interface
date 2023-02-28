using UnityEngine;
using System;

public class SelectionToggle : MenuToggle
{
    public CheckBox CheckBox => transform.parent.GetComponent<CheckBox>();

    private void Start()
    {
        ChangeValue(_toggle.isOn);
    }

    public override void ChangeValue(bool value)
    {
        CheckBox.ChangeSelection(value);
        base.ChangeValue(value);
    }
}
