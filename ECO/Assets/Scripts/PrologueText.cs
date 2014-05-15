using UnityEngine;
using System.Collections;

public class PrologueText : MonoBehaviour
{

    public UILabel label;

    void Start()
    {        
        string[] words = label.text.Split(null);

        StartCoroutine(TextFadeIn());
    }

    IEnumerator TextFadeIn()
    {

        yield return 0;
    }

    void Update()
    {
        
    }

    void OnGUI()
    {

    }
}
