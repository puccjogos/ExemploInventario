using UnityEngine;
using System.Collections;

public class Jogo : MonoBehaviour
{
	public static Jogo instancia;

	public string Cursor { get; set; }

	public void Awake()
	{
		Cursor = "Pegar";
		if (instancia == null)
		{
			instancia = this;
			DontDestroyOnLoad(gameObject);
		} else
		{
			Destroy(gameObject);
		}
	}

	public void Update()
	{
		Debug.Log(Cursor);
	}
}
