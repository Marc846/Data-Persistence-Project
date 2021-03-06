using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public MainManager Manager;

    private void OnCollisionEnter(Collision other)
    {
        DataManager.Instance.SaveScore();
        //Debug.Log(Application.persistentDataPath + "/savefile.json");
        Destroy(other.gameObject);
        Manager.GameOver();
    }
}
