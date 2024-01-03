using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uiController : MonoBehaviour
{

    soundMannager mannager;
 [SerializeField]   TextMeshProUGUI missionName;
 [SerializeField]   TextMeshProUGUI time;


    bool firstLoop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!firstLoop)
        {

            firstLoop = true;
            mannager = soundMannager.Instance;



        }
        if (firstLoop)
        {

        missionName.text = "Mission Name: " + mannager.nextSound.name;
            time.text = "Time : " + mannager.nextSound.timing;

        }
    }
}
