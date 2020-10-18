using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Button PlayingBTN;
    public Button SnackBTN;
    public Button ExerciseBTN;
    public Button PartTimeBTN;
    public Button ItemBTN;

    private void Start()
    {
        PlayingBTN.onClick.AddListener(() => BTNPlaying());
        SnackBTN.onClick.AddListener(() => BTNSnack());
        ExerciseBTN.onClick.AddListener(() => BTNExercise());
        PartTimeBTN.onClick.AddListener(() => BTNPartTime());
        ItemBTN.onClick.AddListener(() => BTNItem());
    }

    public void BTNPlaying()
    {
        PlayingBTN.GetComponent<ButtonAnimmation>().StartAnimation();
        Debug.Log("play");
        InGameManager.Instance.PlayPopup.ShowPopupPlay();
    }

    public void BTNSnack()
    {
        SnackBTN.GetComponent<ButtonAnimmation>().StartAnimation();
        Debug.Log("snack");
    }

    public void BTNExercise()
    {
        ExerciseBTN.GetComponent<ButtonAnimmation>().StartAnimation();
        Debug.Log("Exercis");
    }

    public void BTNPartTime()
    {
        PartTimeBTN.GetComponent<ButtonAnimmation>().StartAnimation();
        Debug.Log("PartTime");
    }

    public void BTNItem()
    {
        ItemBTN.GetComponent<ButtonAnimmation>().StartAnimation();
        Debug.Log("Item");
    }
}
