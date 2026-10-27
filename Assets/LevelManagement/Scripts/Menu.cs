using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SampleGame;

namespace LevelManagement
{
    [RequireComponent(typeof(Canvas))]
    public abstract class Menu : MonoBehaviour
    {
        public void OnPlayPressed(){
            GameManager gameManager = Object.FindObjectOfType<GameManager>();
            if(gameManager != null)
            {
                gameManager.LoadNextLevel();
            }
        }
        public void OnSettingsPresse(){
            MenuManager menuManager = Object.FindObjectOfType<MenuManager>();
            Menu settingsMenu = transform.parent.Find("SettingsMenu(Clone)").GetComponent<Menu>();
            if(menuManager != null && settingsMenu != null)
            {
                menuManager.OpenMenu(settingsMenu);
            }

        }
        public void OnCreditsPressed(){
            MenuManager menuManager = Object.FindObjectOfType<MenuManager>();
            Menu creditsMenu = transform.parent.Find("CreditsMenu(Clone)").GetComponent<Menu>();
            if(menuManager != null && creditsMenu != null)
            {
                menuManager.OpenMenu(creditsMenu);
            }
        }

        public void OnBackPressed(){
            MenuManager menuManager = Object.FindObjectOfType<MenuManager>();
            if(menuManager != null)
            {
                menuManager.CloseMenu();
            }
        }
    }

}