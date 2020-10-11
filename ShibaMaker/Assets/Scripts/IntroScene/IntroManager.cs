using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour
{
    public Button StartButton;
    public Button CollectionButton;
    public Button ExitButton;

    public void Start()
    {
        StartButton?.onClick.AddListener(() => GameStart());
        CollectionButton?.onClick.AddListener(() => Collection());
        ExitButton?.onClick.AddListener(() => Exit());
    }

    private void Collection()
    {

    }

    private void Exit()
    {
        Application.Quit();
#if !UNITY_EDITOR
        System.Diagnostics.Process.GetCurrentProcess().Kill();
#endif
    }

    private void GameStart()
    {

    }
}
