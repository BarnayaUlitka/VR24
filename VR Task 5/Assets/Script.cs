using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.EventSystems;

public class Script : MonoBehaviour
{
    public Text nm;
    public Text age;
    public Text gr;
    public string jsonURL;
    public Jsonclass jsnData;

    void Start()
    {
        StartCoroutine(getData());
    }

    IEnumerator getData()
    {
        var uwr = new UnityWebRequest(jsonURL);
        uwr.method = UnityWebRequest.kHttpVerbGET;
        var resultFile = Path.Combine(Application.persistentDataPath, "result.json");
        var dh = new DownloadHandlerFile(resultFile);
        dh.removeFileOnAbort = true;
        uwr.downloadHandler = dh;
        yield return uwr.SendWebRequest();
        jsnData = JsonUtility.FromJson<Jsonclass>(File.ReadAllText(Application.persistentDataPath + "/result.json"));
        nm.text = jsnData.Name;
        age.text = jsnData.Age.ToString();
        gr.text = jsnData.Group;
        yield return StartCoroutine(getData());
    }
    [System.Serializable]

    public class Jsonclass
    {
        public string Name;
        public int Age;
        public string Group;
    }
}