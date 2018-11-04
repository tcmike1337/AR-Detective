using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Generic functions for buttons in one place for ease of reuse.
/// </summary>
public class ButtonFxns: MonoBehaviour {
    [Tooltip("The text object belonging to the button that toggles the menu's visibility")]
    public Text showHideBtn; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ExitGame()
    {
        //need to make this a prompt to quit instead
        Application.Quit();
    }

    private bool isHidden;
    public void ShowOrHideMenu(GameObject menuPanel)
    {
        RectTransform t = menuPanel.transform as RectTransform;
        if (!isHidden)
        {
            menuPanel.transform.Translate(-t.rect.width,0f,0f);
            isHidden = true;
            showHideBtn.text = "<i>>></i>";// >>
        }
        else
        {
            menuPanel.transform.Translate(t.rect.width, 0f, 0f);
            isHidden = false;
            showHideBtn.text = "<i><<</i>";// <<
        }
        
    }
}
