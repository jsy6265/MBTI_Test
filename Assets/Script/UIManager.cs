using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace MBIT
{
    public class UIManager : MonoBehaviour
    {
        public GameObject mainBord;
        public GameObject optionBord;

        public void OnOffOption(int type)
        {
            if(type == 1)
            {
                mainBord.SetActive(false);
                optionBord.SetActive(true);

                Sequence option = DOTween.Sequence();

                option.Prepend(optionBord.transform.DOScale(1, 1));
                option.Append(mainBord.transform.DOScale(0, 0));

            }
            else
            {
                optionBord.SetActive(false);
                mainBord.SetActive(true);

                Sequence option = DOTween.Sequence();

                option.Append(optionBord.transform.DOScale(0, 0));
                option.Append(mainBord.transform.DOScale(1, 1));
            }
            

        }
    }
}

