using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DotweenPathMove : MonoBehaviour
{
    public Ease EaseType;
    public List<Vector3> WayPointList;
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init(false, true, LogBehaviour.ErrorsOnly);

        gameObject.transform.DOPath(WayPointList.ToArray(), 6.0f, PathType.CatmullRom).SetLookAt(Vector3.zero).SetEase(EaseType);
    }


}
