using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MenuInterface : MonoBehaviour, IActivity
{
    [SerializeField] private UIPanel Panel;
    public IReadOnlyList<CheckBox> ListCheckBoxes { get; set; }

    private void Start()
    {
        IEnumerable<CheckBox> list = FindObjectsOfType<MonoBehaviour>().OfType<CheckBox>();
        ListCheckBoxes = list.ToList();
    }

    public void Hide() => Panel.Hide();
    public void Show() => Panel.Show();
}
