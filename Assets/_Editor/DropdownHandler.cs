using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownHandler : MonoBehaviour
{
    TMP_Dropdown dropdown;
    public List<GameObject> allPanels;

    // Start is called before the first frame update
    void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();

        DeactivativeAllPanels();
        DropdownItemSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
    }

    public void DropdownItemSelected(TMP_Dropdown dropdown)
    {
        int index = dropdown.value;

        switch (index)
        {
            case 0:
                DeactivativeAllPanels();
                allPanels[0].SetActive(true);
                break;
            case 1:
                DeactivativeAllPanels();
                allPanels[1].SetActive(true);
                break;
            case 2:
                DeactivativeAllPanels();
                allPanels[2].SetActive(true);
                break;
            default:
                break;
        }
    }

    void DeactivativeAllPanels()
    {
        foreach (var panel in allPanels)
        {
            panel.SetActive(false);
        }
    }
}
