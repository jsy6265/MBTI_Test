using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MBTI
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance = null;


        void Awake()
        {
            if (null == instance)
            {
                
                instance = this;

                
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                
                Destroy(this.gameObject);
            }
        }
    }
}

