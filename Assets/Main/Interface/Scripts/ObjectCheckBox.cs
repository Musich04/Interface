using System.Collections;
using UnityEngine;

public class ObjectCheckBox : MonoBehaviour, IActivity, ITransparency
{
    private MeshRenderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

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

    public void SetTransparencyDegree(float degree)
    {
        degree = Mathf.Clamp01(degree);

        Color color = _renderer.material.color;
        color.a = degree;

        _renderer.material.color = color;
    }
}