using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagePanel : MonoBehaviour
{
    public GameObject GeneralCalculationPanel;
    public GameObject BreakCalculationPanel;
    public GameObject ElationCalculationPanel;

    public void ShowGeneralCalculationPanel()//button
    {
        CloseAllPanels();
        GeneralCalculationPanel.SetActive(true);
    }
    public void ShowBreakCalculationPanel()//button
    {
        CloseAllPanels();
        BreakCalculationPanel.SetActive(true);
    }
    public void ShowElationCalculationPanel()
    {
        CloseAllPanels();
        ElationCalculationPanel.SetActive(true);
    }

    void CloseAllPanels()
    {
        GeneralCalculationPanel.SetActive(false);
        BreakCalculationPanel.SetActive(false);
        ElationCalculationPanel.SetActive(false);
    }
}
