using UnityEngine;
using System.Collections;

public class ItemClicavel : MonoBehaviour
{
	public Item item;
	Inventario inventario;

	void Start()
	{
		inventario = GameObject.Find("Inventario").GetComponent<Inventario>();
	}

	void OnMouseUpAsButton()
	{
		if (inventario.Adicionar(item))
		{
			Destroy(gameObject);
		}

	}
}
