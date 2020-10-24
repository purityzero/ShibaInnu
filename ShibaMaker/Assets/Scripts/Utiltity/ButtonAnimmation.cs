using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonAnimmation : MonoBehaviour
{
    private bool isPossible = true;

    public void StartAnimation()
    {
        if (!isPossible)
            return;

        isPossible = false;
        gameObject.transform.DOScale(1.1f, 0.05f).SetLoops(2, LoopType.Yoyo).OnComplete(() =>
        {
            isPossible = true;
        });
    }

}
