using UnityEngine;

public class UIPanel : MonoBehaviour, IActivity
{
    public void Hide()
    {
        if (gameObject.activeSelf)
            gameObject.SetActive(false);
    }

    public void Show()
    {
        if (!gameObject.activeSelf)
            gameObject.SetActive(true);
    }
}
