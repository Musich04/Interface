using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MainSelectionToggle : MenuToggle
{
    private IReadOnlyCollection<SelectionToggle> _selectionToggles;

    private void Start()
    {
        IEnumerable<SelectionToggle> list = FindObjectsOfType<MonoBehaviour>().OfType<SelectionToggle>();
        _selectionToggles = list.ToList();

        foreach (MenuToggle toggle in _selectionToggles)
            toggle.OnChanged += Init;

        ChangeValue(_toggle.isOn);
    }

    public override void ChangeValue(bool value)
    {
        foreach (SelectionToggle toggle in _selectionToggles)
        {
            if (value)
                toggle.Show();
            else
                toggle.Hide();
        }
    }

    public void Init()
    {
        if (_selectionToggles.Any(t => t.IsOn() != true))
            _toggle.SetIsOnWithoutNotify(false);
        else
            _toggle.SetIsOnWithoutNotify(true);
    }

    private void OnDisable()
    {
        foreach (MenuToggle toggle in _selectionToggles)
            toggle.OnChanged -= Init;
    }
}