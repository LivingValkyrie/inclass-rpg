using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: Entity 
/// </summary>
public class Entity : ScriptableObject {

	#region Fields

	public string entityName;
	public int age;


	protected string faction;

	public string occupation;

	public int level = 1;
	public int health = 2;
	public int strength = 1;
	public int magic = 0;
	public int defenese = 0;
	public int speed = 1;
	public int damage = 1;
	public int armour = 0;
	public int numOfAttacks = 1;

	public string weapon;
	public Vector2 position; 

	#endregion

	public void TakeDamage(int amount) {
		health -= Mathf.Clamp((amount - armour), 0, int.MaxValue);
	}

	public void Attack(Entity entity) {
		entity.TakeDamage(strength);
	}

}
