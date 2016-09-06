using UnityEngine;
using System.Collections;
using System;

public class Clocking : MonoBehaviour {

    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;

    private const float hoursToDegress = 360f / 12f;
    private const float minutesToDegress = 360f / 60f;
    private const float secondsToDegress = 360f / 60f;

    void Update()
    {
        DateTime time = DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegress);
        minutesTransform.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegress);
        secondsTransform.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secondsToDegress);
    }

}
