using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum RewardType
{
    None = -1,
    Food,
    Dress,
    Favor

}

public enum Dress
{
    None,
}

public enum Food
{
    None,
}

public enum Favor
{
    None,
}

public class Reward : MonoBehaviour
{
    public Image RewardImage;
    public Text RewardText;
    private RewardType rewardType;
    public const int FOOD_MAX_COUNT = 5;


    int FoodCount = 1;

    public void Init(RewardType _rewardType)
    {
        rewardType = _rewardType;

        if (rewardType == RewardType.Food)
            FoodCount = Random.Range(1, FOOD_MAX_COUNT + 1);

    }

    public int SelectRewardItemIndex()
    {
        // rewardType string 값으로 받아서
        // string을 enum Type 으로 변경, 변경 후 idx 판별 
        int idx = Random.Range(0, (int)rewardType);
        return idx;
    }


}
