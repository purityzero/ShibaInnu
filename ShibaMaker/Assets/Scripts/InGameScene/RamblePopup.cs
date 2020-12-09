using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RamblePopup : BasePopup
{
    [SerializeField]
    Image PrograssBar;

    public float timer = 4;

    protected override void OnStart()
    {
        gameObject.SetActive(true);
        StartCoroutine(coPrograssStart());

        
    }
    protected override void OnEnd()
    {
        base.OnEnd();
        gameObject.SetActive(false);
    }

    private IEnumerator coPrograssStart()
    {
        float time = 0;
        PrograssBar.fillAmount = 0;
        while (true)
        {
            time += (0.25f/(timer*2));

            yield return new WaitForSeconds(0.25f);
            PrograssBar.fillAmount = Mathf.Lerp(0, timer, time);

            if (PrograssBar.fillAmount >= 1)
                break;
        }

        InGameManager.Instance.ShowRewardPopUp(PlayType.Ramble);
        OnEnd();
    }

}
