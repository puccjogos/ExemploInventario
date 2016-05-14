using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemUI : MonoBehaviour
{
	public void Clicou(string cursor)
	{
		GameObject.Find("Jogo").GetComponent<Jogo>().Cursor = cursor;
	}
}
