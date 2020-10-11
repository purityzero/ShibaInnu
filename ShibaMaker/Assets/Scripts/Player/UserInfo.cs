using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UserEnum
{
    UserCode = -1,
    ID = 0,
    Lovely,
    Mischief,
    Splendor,
    Dark,
    IQ,
    EQ,
    Strong,
    Hungry,
    END
}


[System.Serializable]
public class Status
{
    public string StatusName = "";
    public double Stat = 0;

    public Status(string _Name, int _stat)
    {
        StatusName = _Name;
        Stat += _stat;
    }
}

[System.Serializable]
public class UserInfo : MonoBehaviour
{
    public double UserCode;
    public List<Status> ListStatus = new List<Status>();
    //public DateTime ShibaDate = new DateTime();

    // 유저 정보가 없을 시
    public UserInfo()
    {

        for (int i = 0; i < (int)UserEnum.END; i++)
        {
            if ( i == 0)
            {
                Status status = new Status("용맹한시바", 0);
                ListStatus.Add(status);
            }
            else
            {
                int stat = 0;
                if ((UserEnum)i == UserEnum.Lovely)
                    stat = 30;
                else if ((UserEnum)i == UserEnum.Hungry)
                    stat = 50;
                else
                {
                    stat = 10;
                }

                Status status = new Status(((UserEnum)i).ToString(), stat);
                ListStatus.Add(status);
            }
        }
        //ShibaDate = new DateTime(0, 0, 0);
    }


    // User정보가 있을 시
    public UserInfo(double _userCode, string _id, double _lovely, double _mischief, double _splendor, double _dark, double _iq, double _eq, double _str, double _hungry)
    {
        //UserCode = _userCode;
        //ListStatus[0].StatusName = _id;
        //ListStatus[1] = _lovely;
        //Mischief = _mischief;
        //Splendor = _splendor;
        //Dark = _dark;
        //IQ = _iq;
        //EQ = _eq;W
        //Strong = _str;
        //Hungry = _hungry;
    }

}
