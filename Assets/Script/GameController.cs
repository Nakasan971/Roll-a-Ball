using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour {
    
    public UnityEngine.UI.Text ScoreLabel;
    public GameObject WinLabelObject;

    public void Update () {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        ScoreLabel.text = count.ToString();

        if(count == 0){
            WinLabelObject.SetActive(true);
        }
	}
}
