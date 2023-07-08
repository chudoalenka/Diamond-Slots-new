using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tempp : MonoBehaviour
{
    public Text gtext;
    public int g;
    void Start()
    {
        g = PlayerPrefs.GetInt("Credit", 50000);
        gtext.text = g + "";
    }
    public void newupdate()
    {
        g = PlayerPrefs.GetInt("Credit", 50000);
        gtext.text = g + "";
        Invoke("eee", 2f);
    }
    void eee()
    {
        g = PlayerPrefs.GetInt("Credit", 50000);
        gtext.text = g + "";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
