using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Runner.Characters;

namespace Runner.Enemies
{

	public abstract class Enemy : MonoBehaviour
	{

		public abstract Collider2D Collider2D { get; }

		public abstract void Kill ( Character target );

	}

}