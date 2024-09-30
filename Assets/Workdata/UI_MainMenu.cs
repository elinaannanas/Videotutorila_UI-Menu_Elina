using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_MainMenu : MonoBehaviour
{ [SerializeField] private CanvasGroup MainMenu_Panel;
    [SerializeField] private Button Start_Button;
    [SerializeField] private Button Option_Button;
    [SerializeField] private Button Exit_Button;

    [SerializeField] private CanvasGroup Options_Panel;
    [SerializeField] private Button Back_Button;
    

    


   









    
    void Start()
    {
        MainMenu_Panel.ShowCanvasGroup();
        Start_Button.onClick.AddListener(loadNextLevel);
        Option_Button.onClick.AddListener(OpenOptionPanel);
        Exit_Button.onClick.AddListener(ExitGame);

        Options_Panel.HideCanvasGroup();
        Back_Button.onClick.AddListener(BackToMenu);
        


    }

    public void OpenOptionPanel()
    {
        MainMenu_Panel.HideCanvasGroup();
        Options_Panel.ShowCanvasGroup();
        

    }

    public void BackToMenu()
    {
        
        MainMenu_Panel.ShowCanvasGroup();
        Options_Panel.HideCanvasGroup();
        
        
    }

    public void ExitGame()
    {
        MainMenu_Panel.ShowCanvasGroup();
        
        
    }

    public void loadNextLevel()
    {
        MainMenu_Panel.ShowCanvasGroup();


    }
     
    



}




public static class UIExtentions
{
    public static void HideCanvasGroup(this CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 0f;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }

    public static void ShowCanvasGroup(this CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 1f;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;

    }
    
    
    
    
    
    
}
