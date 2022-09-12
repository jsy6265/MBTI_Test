using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace MBTI
{
    public class ScceneManager : MonoBehaviour
    {
        public void SceneChange(string type)
        {
            SceneManager.LoadScene(type);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}

