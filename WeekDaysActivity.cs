using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeekDaysActivity : MonoBehaviour
{
    public DaysEnum day;

    void Start()
    {
        switch (day)
        {
            case (DaysEnum.Monday):
                Debug.Log("Today is Monday!");break;
            case (DaysEnum.Tuesday):
                Debug.Log("Today is Tuesday!");break;
            case (DaysEnum.Wednesday):
                Debug.Log("Today is Wednesday!");break;
            case (DaysEnum.Thursday):
                Debug.Log("Today is Thursday!");break;
            case (DaysEnum.Friday):
                Debug.Log("Today is Friday!");break;
            case (DaysEnum.Saturday):
                Debug.Log("Today is Saturday!");break;
            case (DaysEnum.Sunday):
                Debug.Log("Today is Sunday!");break;
            default:
                Debug.Log("Huh?");break;
        }
    }

}

public enum DaysEnum
{

    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday

}
