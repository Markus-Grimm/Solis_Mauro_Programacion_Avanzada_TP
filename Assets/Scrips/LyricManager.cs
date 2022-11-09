using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LyricPortion
{
    public float timeStamp;
    public string lyric;
    public string lyricCoro;
    public float nextLyric;
}

public class LyricManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip song;

    [SerializeField] Text lyric_txt, lyricCoro_txt, time_txt;

    private int currVal;

    private static List<LyricPortion> lyricList = new List<LyricPortion>();

    public static void Main()
    {
        List<LyricPortion> initialList = new List<LyricPortion>();

        initialList.Add(new LyricPortion() { timeStamp = 20.5f, lyric = "VERTI EST SUA AETERNI", lyricCoro = "", nextLyric = 22.8f });
        initialList.Add(new LyricPortion() { timeStamp = 22.8f, lyric = "", lyricCoro = "VERTI EST SUA AETERNI", nextLyric = 25.8f });
        initialList.Add(new LyricPortion() { timeStamp = 25.8f, lyric = "CORDA NOSTRA SOLUM TIBI", lyricCoro = "", nextLyric = 28f });
        initialList.Add(new LyricPortion() { timeStamp = 28.0f, lyric = "", lyricCoro = "CORDA NOSTRA SOLUM TIBI", nextLyric = 30f });
        initialList.Add(new LyricPortion() { timeStamp = 30.0f, lyric = "VERTI EST SUA AETERNI", lyricCoro = "", nextLyric = 33f });
        initialList.Add(new LyricPortion() { timeStamp = 33.0f, lyric = "", lyricCoro = "VERTI EST SUA AETERNI", nextLyric = 35f });
        initialList.Add(new LyricPortion() { timeStamp = 35.0f, lyric = "VITA NOSTRA SOLIM TIBI", lyricCoro = "", nextLyric = 37.8f });
        initialList.Add(new LyricPortion() { timeStamp = 37.8f, lyric = "", lyricCoro = "VITA NOSTRA SOLIM TIBI", nextLyric = 40f });
        initialList.Add(new LyricPortion() { timeStamp = 40.0f, lyric = "ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 45f });
        initialList.Add(new LyricPortion() { timeStamp = 45.0f, lyric = "ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 50f });
        initialList.Add(new LyricPortion() { timeStamp = 50.0f, lyric = "OH ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 55f });
        initialList.Add(new LyricPortion() { timeStamp = 55.0f, lyric = "ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 59f });
        initialList.Add(new LyricPortion() { timeStamp = 59.0f, lyric = "", lyricCoro = "", nextLyric = 71f });
        initialList.Add(new LyricPortion() { timeStamp = 71.0f, lyric = "A FERVENTI AESTUOSA LIBYA", lyricCoro = "", nextLyric = 74f });
        initialList.Add(new LyricPortion() { timeStamp = 74.0f, lyric = "", lyricCoro = "A FERVENTI AESTUOSA LIBYA", nextLyric = 76f });
        initialList.Add(new LyricPortion() { timeStamp = 76.0f, lyric = "VOLAT AQUILA LEGIONUM", lyricCoro = "", nextLyric = 78f });
        initialList.Add(new LyricPortion() { timeStamp = 78.0f, lyric = "", lyricCoro = "VOLAT AQUILA LEGIONUM", nextLyric = 80f });
        initialList.Add(new LyricPortion() { timeStamp = 80.0f, lyric = "SUPRA TERRA BRITTANNORUM", lyricCoro = "", nextLyric = 83f });
        initialList.Add(new LyricPortion() { timeStamp = 83.0f, lyric = "", lyricCoro = "SUPRA TERRA BRITTANNORUM", nextLyric = 85f });
        initialList.Add(new LyricPortion() { timeStamp = 85.0f, lyric = "VOLAT AQUILA LEGIONUM", lyricCoro = "", nextLyric = 88f });
        initialList.Add(new LyricPortion() { timeStamp = 88.0f, lyric = "", lyricCoro = "VOLAT AQUILA LEGIONUM", nextLyric = 90f });
        initialList.Add(new LyricPortion() { timeStamp = 90.0f, lyric = "ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 95f });
        initialList.Add(new LyricPortion() { timeStamp = 95.0f, lyric = "ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 100f });
        initialList.Add(new LyricPortion() { timeStamp = 100.0f, lyric = "OH ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 105f });
        initialList.Add(new LyricPortion() { timeStamp = 105.0f, lyric = "ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 110f });
        initialList.Add(new LyricPortion() { timeStamp = 110.0f, lyric = "ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 113f });
        initialList.Add(new LyricPortion() { timeStamp = 113.0f, lyric = "", lyricCoro = "", nextLyric = 133f });
        initialList.Add(new LyricPortion() { timeStamp = 133.0f, lyric = "SIT ITALICA SUA VIS", lyricCoro = "", nextLyric = 135f });
        initialList.Add(new LyricPortion() { timeStamp = 135.0f, lyric = "", lyricCoro = "SIT ITALICA SUA VIS", nextLyric = 138f });
        initialList.Add(new LyricPortion() { timeStamp = 138.0f, lyric = "NOSTRUM MUNUS PATRI MARTIS", lyricCoro = "", nextLyric = 140.8f });
        initialList.Add(new LyricPortion() { timeStamp = 140.8f, lyric = "", lyricCoro = "NOSTRUM MUNUS PATRI MARTIS", nextLyric = 143f });
        initialList.Add(new LyricPortion() { timeStamp = 143.0f, lyric = "SIT ITALICA SUA VIS", lyricCoro = "", nextLyric = 145f });
        initialList.Add(new LyricPortion() { timeStamp = 145.0f, lyric = "", lyricCoro = "SIT ITALICA SUA VIS", nextLyric = 148f });
        initialList.Add(new LyricPortion() { timeStamp = 148.0f, lyric = "NOSTRUM MUNUS PATRI MARTIS", lyricCoro = "", nextLyric = 150f });
        initialList.Add(new LyricPortion() { timeStamp = 150.0f, lyric = "", lyricCoro = "NOSTRUM MUNUS PATRI MARTIS", nextLyric = 153f });
        initialList.Add(new LyricPortion() { timeStamp = 153.0f, lyric = "ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 157.5f });
        initialList.Add(new LyricPortion() { timeStamp = 157.5f, lyric = "ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 162f });
        initialList.Add(new LyricPortion() { timeStamp = 162.0f, lyric = "OH ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 168f });
        initialList.Add(new LyricPortion() { timeStamp = 168.0f, lyric = "ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 173f });
        initialList.Add(new LyricPortion() { timeStamp = 173.0f, lyric = "ROMA", lyricCoro = "LEGIO! AETERNA! AERTERNA! VICTRIX!", nextLyric = 176f });
        initialList.Add(new LyricPortion() { timeStamp = 176.0f, lyric = "", lyricCoro = "", nextLyric = 20f });

        lyricList = initialList;
    }

    void Start()
    {                
        currVal = 0;        
        audioSource.Play();
        Main();
        StartCoroutine(Change(0.1f));
    }

    IEnumerator Change(float time)
    {
        
        if (currVal < lyricList.Count)
        {            
            if (lyricList[currVal].timeStamp <= audioSource.time && lyricList[currVal].nextLyric > audioSource.time)
            {                
                    if (lyric_txt.text != lyricList[currVal].lyric) lyric_txt.text = lyricList[currVal].lyric;
                    if (lyricCoro_txt.text != lyricList[currVal].lyricCoro) lyricCoro_txt.text = lyricList[currVal].lyricCoro;                            
            }
            else currVal++;
        }
        else currVal = 0;
        
        yield return new WaitForSeconds(time);
        StartCoroutine(Change(0.1f));
    }

    void Update()
    {
        
        time_txt.text = Mathf.RoundToInt(audioSource.time).ToString();
    }

    public void SaveTime()
    {
        PlayerPrefs.SetFloat("TimeSong", audioSource.time);
    }
}
