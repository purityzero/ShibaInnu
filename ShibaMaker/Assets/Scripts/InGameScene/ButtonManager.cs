using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;

public class ButtonManager : MonoBehaviour
{
    [BoxGroup("MenuBTN")]
    public Button PlayingBTN;
    [BoxGroup("MenuBTN")]
    public Button SnackBTN;
    [BoxGroup("MenuBTN")]
    public Button ExerciseBTN;
    [BoxGroup("MenuBTN")]
    public Button PartTimeBTN;
    [BoxGroup("MenuBTN")]
    public Button ItemBTN;

    [BoxGroup("TopUI")]
    public Button AchievementBTN;
    [BoxGroup("TopUI")]
    public Button CollectionBookBTN;


    private void Start()
    {
        PlayingBTN.onClick.AddListener(() => BTNPlaying());
        SnackBTN.onClick.AddListener(() => BTNSnack());
        ExerciseBTN.onClick.AddListener(() => BTNRamble());
        PartTimeBTN.onClick.AddListener(() => BTNPartTime());
        ItemBTN.onClick.AddListener(() => BTNItem());

        AchievementBTN.onClick.AddListener(() => BTNAchievement());
        CollectionBookBTN.onClick.AddListener(() => BTNCollectionBook());

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

    public void BTNRamble()
    {
        ExerciseBTN.GetComponent<ButtonAnimmation>().StartAnimation();
        Debug.Log("Ramble");
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

    public void BTNAchievement()
    {
        AchievementBTN.GetComponent<ButtonAnimmation>().StartAnimation();
        Debug.Log("AchievementBTN");

    }

    public void BTNCollectionBook()
    {
        CollectionBookBTN.GetComponent<ButtonAnimmation>().StartAnimation();
        Debug.Log("CollectionBook");
    }

}
