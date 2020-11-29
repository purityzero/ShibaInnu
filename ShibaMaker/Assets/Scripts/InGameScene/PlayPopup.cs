using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayData
{
    public int ICutNo;
    public string ImagePath;
    public string Strcontent;
    public bool bButton;

    public List<string> ButtonString;
    public List<int> FirstSelect;
    public List<int> SecondSelect;
    public List<int> ThirdSelect;

    public List<PlayData> TestData()
    {
        List<PlayData> TestDatas = new List<PlayData>();

        int testNo = 5;
        for (int i = 0; i < testNo; i++)
        {
            PlayData data = new PlayData();
            data.ICutNo = i;
            data.ImagePath = "";
            data.bButton = false;
            if (i == 0)
                data.Strcontent = "오늘도 요안나는 글로리를 때렸다.";
            else if (i == 1)
                data.Strcontent = "그래서 글로리는 요안나에게 복수의 계획을 새운다.";
            else if (i == 2)
                data.Strcontent = "하지만 글로리는 착해서 마음을 고쳐먹는다.";
            else if (i == 3)
                data.Strcontent = "요안나에게 먹을 걸 사줄 결심을 한다.";
            else
            {
                data.bButton = true;
                data.Strcontent = "무엇을 사줄까?";
            }

            if (data.bButton)
            {
                data.ButtonString = new List<string>();
                data.ButtonString.Add("고디바");
                data.ButtonString.Add("오리지날 글레이즈드 도넛");
                data.ButtonString.Add("요안나의 꿀밤");
            }
            TestDatas.Add(data);
        }
        return TestDatas;
    }
}

public class PlayPopup : MonoBehaviour
{

    public Text ContentText;
    public List<PlayData> ListData;
    public Button NextButton;
    public int CutNum = 0;
    public GameObject ButtonSelect;

    public List<Button> SelectButton;

    void Start()
    {
        NextButton.gameObject.SetActive(true);
        NextButton.onClick.AddListener(() => NextButtonClick());
    }

    public void ShowPopupPlay()
    {
        gameObject.SetActive(true);
        PlayData data = new PlayData();
        ListData = data.TestData();

        CutNum = 0;
        DataUpdate();
    }

    void NextButtonClick()
    {
        if (CutNum > ListData.Count)
            return;

        CutNum += 1;
        DataUpdate();

        if (CutNum >= ListData.Count - 1)
            NextButton.gameObject.SetActive(false);
    }

    void DataUpdate()
    {
        if (CutNum >= ListData.Count)
            return;

        ContentText.text = ListData[CutNum].Strcontent;

        ButtonSelect.SetActive(ListData[CutNum].bButton);
        if (ListData[CutNum].bButton)
        {
            SelectButton.ForEach(x => x.gameObject.SetActive(false));
            for (int i =  0; i < ListData[CutNum].ButtonString.Count; i++)
            {
                SelectButton[i].gameObject.SetActive(true);
                SelectButton[i].gameObject.GetComponentInChildren<Text>().text = ListData[CutNum].ButtonString[i];
            }
        }


    }

}
