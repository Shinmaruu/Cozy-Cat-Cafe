using System;
using Plugins.CloudCanards.Inspector;
using UnityEngine;

namespace CozyCatCafe.Scripts
{
	public class Seat : MonoBehaviour
	{
		[NonSerialized]
		public Customers Customer;

		[Required]
		public PlayerStats Player;

		public GameObject HappyParticles;
		public GameObject SadParticles;

		private void OnMouseDown()
		{
			if (Player.holding == null)
				return;

			Customer.gotFood = true;
			if (Player.holding == Customer.orderDish)
			{
				// todo
				Player.Money++;
				if (HappyParticles != null)
					Instantiate(HappyParticles, transform);
			}
			else
			{
				if (SadParticles != null)
					Instantiate(SadParticles, transform);
			}

			Player.holding = null;
		}
	}
}