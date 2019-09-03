using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace pspGUI{


public class PSP_UI_System : MonoBehaviour
{
        #region Variables
        [Header("system events")]
        public UnityEvent onSwitchedScreen = new UnityEvent();


        // all screens array
        private Component[] screens = new Component[0];

        // private variable for screens
        private PSP_UI_Screen currentScreen;
        private PSP_UI_Screen previousScreen;

        // getters, this is a property
        public PSP_UI_Screen CurrentScreen { get { return currentScreen; } }
        public PSP_UI_Screen PreviousScreen { get { return previousScreen; } }


        
#endregion

        #region MainMethods
        // Start is called before the first frame update
        void Start()
    {
            screens = GetComponentsInChildren<PSP_UI_Screen>(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        #endregion






        #region Helper Methods
        public void SwitchScreens(PSP_UI_Screen aScreen)
        {
            if (aScreen)
            {
                if (currentScreen)
                {
                    //currentScreen.Close();
                    previousScreen = currentScreen;
                }

                currentScreen = aScreen;
                currentScreen.gameObject.SetActive(true);
                //currentScreen.StartScreen();
            }

            if (onSwitchedScreen != null)
            {
                onSwitchedScreen.Invoke();
            }
        }

        // go to previous screen
        public void GoToPreviousScreen()
        {
            if (previousScreen)
            {
                SwitchScreens(previousScreen);
            }
        }

        //
        public void LoadScene(int sceneIndex)
        {
            StartCoroutine(WaitToLoadScene(sceneIndex));
        }

        IEnumerator WaitToLoadScene(int sceneIndex)
        {
            yield return null;
        } 

        #endregion
    }


}
