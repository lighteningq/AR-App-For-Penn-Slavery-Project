using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace pspGUI {
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(CanvasGroup))]
    public class PSP_UI_Screen : MonoBehaviour
{


        #region Variables
        [] 
        private Animator animator;

        #endregion

        #region Main Methods
        // Start is called before the first frame update
        void Start()
    {
            animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        #endregion



        #region Helper Methods
        #endregion
    }


}
