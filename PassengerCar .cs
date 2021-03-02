using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture
{
	class PassengerCar
	{
		private int currentSpeed;
		private static int maxSpeed = 200;

		public void SpeedUp()
		{
			currentSpeed = currentSpeed + 5 > maxSpeed ? maxSpeed : currentSpeed + 5;
		}
		public static int MaxSpeedUp() => maxSpeed++;

		public int CurrentSpeed
		{
			get { return currentSpeed; }
		}
		public static int MaxSpeed
		{
			get => maxSpeed;
		}
		//rest of code here
	}
}
