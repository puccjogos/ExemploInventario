using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Inventario : MonoBehaviour
{
	public List<Item> items;
	public Transform painel;

	public bool Adicionar(Item novoItem)
	{
		foreach (var item in items)
		{
			if (item.nome == novoItem.nome)
			{
				return false;
			}
		}
		// processamento
		items.Add(novoItem);
		GameObject novoBotao = Instantiate(novoItem.prefab) as GameObject;
		novoBotao.transform.SetParent(painel.transform);
		return true;
	}
}
