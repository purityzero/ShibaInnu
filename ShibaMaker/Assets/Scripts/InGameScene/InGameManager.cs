using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class InGameManager : Singleton<InGameManager>
{
    public UserInfo Player = null;
    public UserInfoPopup InfoPopup;
    public PlayPopup PlayPopup;
    public List<BasePopup> ShowingPopup;

    IEnumerator Start()
    {
        UserInfo player = new UserInfo();
        Player.ListStatus = player.ListStatus;

        yield return new WaitUntil(() => Player != null);

        InfoPopup.Init();
    }

}
