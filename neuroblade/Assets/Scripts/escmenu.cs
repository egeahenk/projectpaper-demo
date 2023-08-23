using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;

public class escmenu : MonoBehaviour
{

    public GameObject escapePanel;
    public TextMeshProUGUI orangeCash;
    

    #region escmenu
    
    public void OpenEscapeMenu()
    {
        escapePanel.SetActive(true);
        orangeCash.gameObject.SetActive(false);
    }

    public void CloseEscapeMenu()
    {
        escapePanel.SetActive(false);
        orangeCash.gameObject.SetActive(true);
    }

    #endregion
    
    
    void Update()
    {

        
        if(Input.GetKey(KeyCode.Escape))
        {
            OpenEscapeMenu();
        }


    }
}
