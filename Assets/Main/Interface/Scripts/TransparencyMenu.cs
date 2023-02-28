using UnityEngine;

public class TransparencyMenu : MonoBehaviour
{
    [SerializeField] private MenuInterface _menu;

    public void SetTransparencySelected(float degree)
    {
        foreach (CheckBox check in _menu.ListCheckBoxes)
        {
            if (check.IsSelected())
                check.SetTransparency(degree);
        }
    }
}
