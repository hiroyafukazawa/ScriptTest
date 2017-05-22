using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53;

	// 攻撃用の関数
	public void Attack()
	{
		Debug.Log(this.power + "のダメージを与えた");
	}

	// 防御用の関数
	public void Defence(int damage)
	{
		Debug.Log(damage + "のダメージを受けた");
		// 残りhpを減らす
		this.hp -= damage;
	}

	//魔法用の関数
	public void Magic()
	{
		if (this.mp < 5)
		{
			Debug.Log("MPが足りないため魔法が使えない");
		}
		else
		{
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りのMPは" + this.mp);

		}
	}
}

public class Test : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] array = new int[5];
		//あるいは、int[] array = {11,22,33,44,55};
		array[0] = 11;
		array[1] = 22;
		array[2] = 33;
		array[3] = 44;
		array[4] = 55;

		for (int i = 0; i < 5; i++)
		{
			Debug.Log(array[i]);
		}
		for (int t = 4; t >= 0; t--)
		{
			Debug.Log(array[t]);
		}
		Boss lastboss = new Boss();
		for (int i = 1; i <= 11; i++)
		{
			lastboss.Magic();

		}
	}

	// Update is called once per frame
	void Update() {
			
	}
}
