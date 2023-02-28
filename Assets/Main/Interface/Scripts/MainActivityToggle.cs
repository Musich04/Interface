using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MainActivityToggle : MenuToggle
{
    private IReadOnlyCollection<ActivityToggle> _activityToggles;

    private void Start()
    {
        IEnumerable<ActivityToggle> list = FindObjectsOfType<MenuToggle>().OfType<ActivityToggle>();
        _activityToggles = list.ToList();

        foreach (MenuToggle toggle in _activityToggles)
            toggle.OnChanged += Init;

        ChangeValue(_toggle.isOn);
    }

    public override void ChangeValue(bool value)
    {
        foreach (ActivityToggle toggle in _activityToggles)
        {
            if (toggle.CheckBox.IsSelected())
            {
                if (value)
                    toggle.Show();
                else
                    toggle.Hide();
            }
        }
    }
    public void Init()
    {
        List<MenuToggle> list = new List<MenuToggle>();

        foreach(ActivityToggle toggle in _activityToggles)
            if (toggle.CheckBox.IsSelected())
                list.Add(toggle);

        if (list.Any(t => t.IsOn() != true))
            _toggle.SetIsOnWithoutNotify(false);
        else
            _toggle.SetIsOnWithoutNotify(true);
    }

    private void OnDisable()
    {
        foreach (MenuToggle toggle in _activityToggles)
            toggle.OnChanged -= Init;
    }
}
