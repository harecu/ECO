using UnityEngine;
using System.Collections;

public class PrologueText : MonoBehaviour
{    
    public UILabel label;
    public string[] lines;
    public float delayBetweenWords;
    public float delayBetweenLines;

    void Start()
    {        
        string[] words = label.text.Split(null);
        UIInput input = GameObject.FindObjectOfType<UIInput>();
        input.selected = true;
        StartCoroutine(TextFadeIn());
    }

    IEnumerator TextFadeIn()
    {
        foreach (string line in lines)
        {
            //label.text += line + "\n";
            string[] words = line.Split(' ');
            foreach (string word in words)
            {
                label.text += word + " ";
                yield return new WaitForSeconds(delayBetweenWords);
            }
            label.text += "\n";
            yield return new WaitForSeconds(delayBetweenLines);
        }
    }

    void Update()
    {
        
    }

    void OnGUI()
    {

    }
}
