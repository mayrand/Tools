using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TraderUtils
{
	public class makepasswd
	{
		public readonly string password;
		public readonly string md5;
		public makepasswd()
		{
			password = RandomPassword.Generate(10);
			md5 = MD5Crypt.crypt(password, string.Empty);
		}
	}
}
