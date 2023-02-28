using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class CheckBoxFactory : MonoBehaviour
{
    [SerializeField] private GameObject Prefab;
    [SerializeField] private Transform Basket;

    private void Awake()
    {
        IEnumerable<ObjectCheckBox> checkBoxes = FindObjectsOfType<MonoBehaviour>().OfType<ObjectCheckBox>();

        foreach (ObjectCheckBox checkBox in checkBoxes)
            Create(checkBox);
    }

    private void Create(ObjectCheckBox box)
    {
        GameObject boxObj = Instantiate(Prefab, Basket);
        boxObj.GetComponent<CheckBox>().Init(box);
    }
}
