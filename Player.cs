using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public static float moveSpeed = 150f;

	public static float x;

	public static float y;

	private float width;

	private float height;

	public Joystick joystick;

	private static Rigidbody2D player;

	private static RectTransform playerRect;

	public static Vector2 location;

	public static bool gameOver;

	public static bool turnAround;

	private ScoreBehaviour scoreBehaviour;

	private HighscoreBehaviour highscoreBehaviour;

	private CoinManager sprites;

	private FindPlayArea findPlayArea;

	private void Start()
	{
		player = GetComponent<Rigidbody2D>();
		playerRect = GetComponent<RectTransform>();
		scoreBehaviour = GetComponent<ScoreBehaviour>();
		highscoreBehaviour = GetComponent<HighscoreBehaviour>();
		sprites = GetComponent<CoinManager>();
		findPlayArea = GetComponent<FindPlayArea>();
		HighscoreBehaviour.highscore = PlayerPrefs.GetFloat("highscore", HighscoreBehaviour.highscore);
		CoinManager.sprites = PlayerPrefs.GetFloat("sprites", CoinManager.sprites);
		moveSpeed = PlayerPrefs.GetFloat("moveSpeed", moveSpeed);
		location = base.transform.position;
		width = playerRect.rect.width * 100f / 2f;
		height = playerRect.rect.height * 100f / 2f;
	}

	private void Update()
	{
		player = GetComponent<Rigidbody2D>();
		Vector3 vector = Vector3.right * joystick.Horizontal + Vector3.up * joystick.Vertical;
		Transform transform = base.transform;
		Vector3 position = base.transform.position;
		float num = Mathf.Clamp(position.x, width, FindPlayArea.maxX * 2f - width);
		Vector3 position2 = base.transform.position;
		transform.position = new Vector2(num, Mathf.Clamp(position2.y, height, FindPlayArea.maxY * 2f - height));
		if (vector != Vector3.zero)
		{
			base.transform.Translate(vector * moveSpeed * Time.deltaTime, Space.World);
		}
		if (gameOver)
		{
			Debug.Log(CoinManager.sprites);
			location.x = FindPlayArea.maxX;
			location.y = FindPlayArea.maxY;
			if (ScoreBehaviour.score > HighscoreBehaviour.highscore)
			{
				float num2 = HighscoreBehaviour.highscore = ScoreBehaviour.score;
				ScoreBehaviour.lastScore = ScoreBehaviour.score;
				PlayerPrefs.SetFloat("highscore", HighscoreBehaviour.highscore);
				PlayerPrefs.SetFloat("sprites", CoinManager.sprites);
				PlayerPrefs.SetFloat("moveSpeed", moveSpeed);
				ScoreBehaviour.score = 200f;
				SceneManager.LoadScene("Highscores");
			}
			else
			{
				ScoreBehaviour.lastScore = ScoreBehaviour.score;
				PlayerPrefs.SetFloat("highscore", HighscoreBehaviour.highscore);
				PlayerPrefs.SetFloat("sprites", CoinManager.sprites);
				PlayerPrefs.SetFloat("moveSpeed", moveSpeed);
				SceneManager.LoadScene("Highscores");
				ScoreBehaviour.score = 200f;
			}
		}
	}
}
