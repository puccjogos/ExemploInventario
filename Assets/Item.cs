using System;
using UnityEngine;

[Serializable]
public class Item
{
	public string nome;
	public GameObject prefab;

	public Item(string nome)
	{
		this.nome = nome;
	}
}

