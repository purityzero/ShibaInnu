using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameManager : Singleton<InGameManager>
{
    public UserInfo Player = null;
    public UserInfoPopup InfoPopup;


    IEnumerator Start()
    {
        UserInfo player = new UserInfo();
        Player.ListStatus = player.ListStatus;

        yield return new WaitUntil(() => Player != null);

        InfoPopup.Init();
    }

}
