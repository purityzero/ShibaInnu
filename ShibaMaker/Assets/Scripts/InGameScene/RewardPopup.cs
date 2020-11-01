using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardPopup : MonoBehaviour
{

    [SerializeField] Reward PrefabRewardObj;
    VerticalLayoutGroup LayoutGroup;

    public void Init(List<RewardType> rewardTypes)
    {

        for (int i = 0; i < rewardTypes.Count; i++)
        {
            Reward rewardItem = Instantiate<Reward>(PrefabRewardObj, LayoutGroup.transform);
            rewardItem.Init(rewardTypes[i]);
        }
                
    }
}
    