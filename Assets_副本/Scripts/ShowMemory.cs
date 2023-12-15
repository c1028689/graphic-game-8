using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMemory : MonoBehaviour
{
    public Text memoryUsageText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        long totalMemory = System.GC.GetTotalMemory(false) / (1024 * 1024);

        memoryUsageText.text = "Total Memory: " + totalMemory + " MB";
    }
}
