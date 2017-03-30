using UnityEngine;

public enum proType{
	rock, arrow, fireball
};

public class Projectile : MonoBehaviour {
[SerializeField] private int attackStrengh;
[SerializeField] private proType projectileType;

public int AttackStrengh{
	get{
		return attackStrengh;
	}
}

public proType ProjectileType{
	get{
		return projectileType;
	}
}
}
