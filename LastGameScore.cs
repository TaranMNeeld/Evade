using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastGameScore : MonoBehaviour {

	private ScoreBehaviour score;

	private Text text1;

	private void Start()
	{
		score = GetComponent<ScoreBehaviour>();
		text1 = GetComponent<Text>();
	}

	private void Update()
	{
		text1.text = "Last Game: " + ScoreBehaviour.lastScore;
	}
}
