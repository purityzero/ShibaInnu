using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class InfoPopupGauge
{
    public Text Title;
    public Image GaugeImage;
}

public class UserInfoPopup : MonoBehaviour
{

    public Text PlayerID;
    public List<InfoPopupGauge> ListContent;
    public void Init()
    {
        PlayerID.text = InGameManager.Instance.Player.ListStatus[0].StatusName;
        for (int i = 1; i < (int)UserEnum.END; i ++)
        {
            Status status = InGameManager.Instance.Player.ListStatus[i];
            //ListContent[i].Title.text = status.StatusName;
            ListContent[i - 1].GaugeImage.fillAmount = (float)(status.Stat / 100);
        }
    }


}
