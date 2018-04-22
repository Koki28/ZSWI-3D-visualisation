﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ShowPanels : MonoBehaviour
{

    public GameObject optionsPanel;                         //Store a reference to the Game Object OptionsPanel 
    public GameObject optionsTint;                          //Store a reference to the Game Object OptionsTint 
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject menuPanel;                            //Store a reference to the Game Object MenuPanel 
    public GameObject scenePanel;                           //Store a reference to the Game Object ScenePanel 
    public GameObject aboutPanel;                           //Store a reference to the Game Object AboutPanel 
=======
=======
>>>>>>> parent of 1feef8d... Editor 4
=======
>>>>>>> parent of 9a88f2a... revert Editor 3.2
=======
>>>>>>> parent of 2351622... Editor 3.2
    public GameObject menuPanel;							//Store a reference to the Game Object MenuPanel 
    public GameObject scenePanel;							//Store a reference to the Game Object ScenePanel 

>>>>>>> parent of 1feef8d... Editor 4

    private GameObject activePanel;
    private MenuObject activePanelMenuObject;
    private EventSystem eventSystem;



    private void SetSelection(GameObject panelToSetSelected)
    {

        activePanel = panelToSetSelected;
        activePanelMenuObject = activePanel.GetComponent<MenuObject>();
        if (activePanelMenuObject != null)
        {
            activePanelMenuObject.SetFirstSelected();
        }
    }

    public void Start()
    {
        SetSelection(menuPanel);
    }

    //Call this function to activate and display the Options panel during the main menu
    public void ShowOptionsPanel()
    {
        optionsPanel.SetActive(true);
        optionsTint.SetActive(true);
        menuPanel.SetActive(false);
        SetSelection(optionsPanel);

    }

    //Call this function to activate and display the Options panel during the main menu
    public void ShowScnenePanel()
    {
        scenePanel.SetActive(true);
        menuPanel.SetActive(false);
        SetSelection(scenePanel);

    }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    //Call this function to activate and display the About panel during the main menu
    public void ShowAboutPanel()
    {
        aboutPanel.SetActive(true);
        menuPanel.SetActive(false);
        SetSelection(aboutPanel);

    }

    //Call this function to deactivate and hide the About, Options and Scene panel during the main menu
    public void HideOtherPanels()
=======
    //Call this function to deactivate and hide the Options and Scene panel during the main menu
    public void HideOptionsPanel()
>>>>>>> parent of 1feef8d... Editor 4
=======
    //Call this function to deactivate and hide the Options and Scene panel during the main menu
    public void HideOptionsPanel()
>>>>>>> parent of 1feef8d... Editor 4
=======
    //Call this function to deactivate and hide the Options and Scene panel during the main menu
    public void HideOptionsPanel()
>>>>>>> parent of 9a88f2a... revert Editor 3.2
=======
    //Call this function to deactivate and hide the Options and Scene panel during the main menu
    public void HideOptionsPanel()
>>>>>>> parent of 2351622... Editor 3.2
    {
        menuPanel.SetActive(true);
        optionsPanel.SetActive(false);
        optionsTint.SetActive(false);
        scenePanel.SetActive(false);
    }

    //Call this function to activate and display the main menu panel during the main menu
    public void ShowMenu()
    {
        menuPanel.SetActive(true);
        SetSelection(menuPanel);
    }

    //Call this function to deactivate and hide the main menu panel during the main menu
    public void HideMenu()
    {
        menuPanel.SetActive(false);

    }
}
