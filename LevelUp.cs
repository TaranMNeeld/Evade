using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour {

	private ScoreBehaviour scoreBehaviour;
	public Laser1 laser1;
	public Laser2 laser2;
	public RespawnCoin1 coin;
	public GameObject[] lasers;
	public GameObject[] coins;

	private void Start()
	{
		scoreBehaviour = GetComponent<ScoreBehaviour>();
	}

	private void Update()
	{
		if (!(ScoreBehaviour.score >= 500f))
		{
		}
	}
}
