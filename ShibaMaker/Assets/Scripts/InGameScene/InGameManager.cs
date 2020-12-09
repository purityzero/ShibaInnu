using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class InGameManager : Singleton<InGameManager>
{
    public UserInfo Player = null;
    public UserInfoPopup InfoPopup;
    public PlayPopup PlayPopup;
    [ReadOnly][SerializeField]
     private List<BasePopup> ShowingPopup;
    [BoxGroup("Reward")]
    [SerializeField]
    private RewardPopup RewardPopup;

    IEnumerator Start()
    {
        UserInfo player = new UserInfo();
        Player.ListStatus = player.ListStatus;

        yield return new WaitUntil(() => Player != null);
        //InfoPopup.Init();
    }

    public void ShowRewardPopUp(PlayType _playType)
    {
        RewardPopup.Init(null);
    }

    public void AddShowingPopup<T>(T _basePopup) where T : BasePopup
    {
        ShowingPopup.Add(_basePopup);
    }

    public void RemoveShowingPopup<T>(T _basePopup) where T : BasePopup
    {
        ShowingPopup.Remove(_basePopup);
    }

}
