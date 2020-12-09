using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardPopup : BasePopup
{

    [SerializeField] Reward PrefabRewardObj;
    [SerializeField] Transform LayoutGroup;

    public void Init(List<RewardType> rewardTypes)
    {
        gameObject.SetActive(true);
        //if (rewardTypes != null || rewardTypes.Count != 0)
        //{
        //    for (int i = 0; i < rewardTypes.Count; i++)
        //    {
        //        Reward rewardItem = Instantiate<Reward>(PrefabRewardObj, LayoutGroup);
        //        rewardItem.Init(rewardTypes[i]);
        //    }
        //}
                
    }

    protected override void OnStart()
    {
    }
}
    