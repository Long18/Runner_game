using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Runner.Collectables;

namespace Runner.UI
{

	public class UICoinImage : Image
	{

		[SerializeField]
		protected ParticleSystem m_ParticleSystem;

		protected override void Awake ()
		{
			base.Awake ();
		}

        protected override void Start()
        {
            GameManager.Singleton.m_Coin.AddEventAndFire(Coin_OnCoinCollected, this);
        }

        void Coin_OnCoinCollected (int coinValue)
		{
			GetComponent<Animator> ().SetTrigger ("Collect");
		}

		public virtual void PlayParticleSystem ()
		{
			m_ParticleSystem.Play ();
		}
	}
}