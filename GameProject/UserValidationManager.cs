using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class UserValidationManager : IUserValidationService
	{
		public bool Validation(Gamer gamer)
		{
			if (gamer.BirthYear == 1986 && gamer.FirstName == "Bestami" && gamer.LastName == "Tayfuroğlu" && gamer.IdentityNumber == 123456)
			{

				return true;
			}
			else
			{

				return false;
			}
		}
	}
}