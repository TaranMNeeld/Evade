using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour {

	private ScoreBehaviour scoreBehaviour;
	public GameObject laser1;
	public GameObject laser2;
	public GameObject coin;
	public List<GameObject> lasers = new List<GameObject>();
	public List<GameObject> coins = new List<GameObject>();

	private void Start()
	{
		scoreBehaviour = GetComponent<ScoreBehaviour>();
		lasers.Add(laser1);
		lasers.Add(laser2);
		coins.Add(coin);
	}

	private void Update()
	{
		
	}
}
