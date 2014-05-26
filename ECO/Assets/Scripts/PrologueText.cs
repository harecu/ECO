using UnityEngine;
using System;
using System.Collections;

public class PrologueText : MonoBehaviour
{    
    public UILabel label;
    public string[] lines;
    public float delayBetweenWords;
    public float delayBetweenLines;
    public float fadeInSpeed;

    private int colorCode;

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
                //label.text += word + " ";
                StartCoroutine(WordFadeIn(word));
                yield return new WaitForSeconds(delayBetweenWords);
            }
            label.text += "\n";
            yield return new WaitForSeconds(delayBetweenLines);
        }
    }

    IEnumerator WordFadeIn(string word)
    {
        colorCode += 0x010101;
        //Debug.Log(colorCode.ToString("X6"));
        label.text += String.Format("[{0}]{1}[-]", colorCode.ToString("X6"), word) + " ";
        yield return new WaitForSeconds(fadeInSpeed);
    }

    void Update()
    {
        
    }

    void OnGUI()
    {

    }
}
