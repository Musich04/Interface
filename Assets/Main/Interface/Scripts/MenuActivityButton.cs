using UnityEngine;

public class MenuActivityButton : UIButton
{
    [SerializeField] MenuInterface _menu;

    private bool _isEnabled = false;

    public override void Click()
    {
        if (_isEnabled)
            _menu.Show();
        else
            _menu.Hide();

        _isEnabled = !_isEnabled;
    }
}