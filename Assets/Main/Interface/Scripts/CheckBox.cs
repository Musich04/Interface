using UnityEngine;

public class CheckBox : MonoBehaviour
{
    [SerializeField] private ObjectCheckBox Object;

    private bool _isSelected;
    private bool _isEnabled;

    public CheckBox()
    {

    }

    public void Init(ObjectCheckBox checkBox) => Object = checkBox;

    public void ChangeSelection(bool value)
    {
        if (_isSelected != value)
            _isSelected = value;
    }

    public void ChangeEnabler(bool value)
    {
        if (_isEnabled != value)
        {
            _isEnabled = value;

            if (_isEnabled)
                Object.Show();
            else
                Object.Hide();
        }
    }

    public bool IsSelected() => _isSelected;
    public void SetTransparency(float degree) => Object.SetTransparencyDegree(degree);

}
