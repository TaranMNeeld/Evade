using UnityEngine;
using UnityEngine.Advertisements;

public class PlayAdvert : MonoBehaviour
{
	private CoinManager coin;

	private void Start()
	{
		coin = GetComponent<CoinManager>();
	}

	public void ShowRewardedVideoAd()
	{
		Debug.Log("Ad");
		if (Advertisement.IsReady("rewardedVideo"))
		{
			Debug.Log("Ad Ready");
			ShowOptions showOptions = new ShowOptions();
			showOptions.resultCallback = HandleShowResult;
			ShowOptions showOptions2 = showOptions;
			Advertisement.Show("rewardedVideo", showOptions2);
		}
	}

	private void HandleShowResult(ShowResult showResult)
	{
		switch (showResult)
		{
		case ShowResult.Finished:
			Debug.Log("Player finished watching the video ad and is being rewarded with extra sprites.");
			CoinManager.sprites += 100f;
			PlayerPrefs.SetFloat("sprites", CoinManager.sprites);
			break;
		case ShowResult.Skipped:
			Debug.Log("Player skipped watching the video ad, no reward.");
			break;
		case ShowResult.Failed:
			Debug.Log("video ad failed, no reward.");
			break;
		}
	}
}