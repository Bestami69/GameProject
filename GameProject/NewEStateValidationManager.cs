using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class NewEStateValidationManager : IUserValidationService
	{
		public bool Validation(Gamer gamer)
		{
			return true;
		}
	}
}