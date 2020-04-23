using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour {

	private ScoreBehaviour scoreBehaviour;

	private void Start()
	{
		scoreBehaviour = GetComponent<ScoreBehaviour>();
	}

	private void Update()
	{
		if (!(ScoreBehaviour.score >= 1000f))
		{
		}
	}
}
