using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInfo
{
    private double UserCode = 0;
    private string ID = "";
    private double Lovely = 0;
    private double Mischief = 0;
    private double Splendor = 0;
    private double Dark = 0;
    private double IQ = 0;
    private double EQ = 0;
    private double Strong = 0;
    private double Hungry = 0;

    public UserInfo()
    {
    }

    public UserInfo(double _userCoude, string _id, double _lovely, double _mischief, double _splendor, double _dark, double _iq, double _eq, double _str, double _hungry)
    {
        UserCode = _userCoude;
        ID = _id;
        Lovely = _lovely;
        Mischief = _mischief;
        Splendor = _splendor;
        Dark = _dark;
        IQ = _iq;
        EQ = _eq;
        Strong = _str;
        Hungry = _hungry;
    }
}
