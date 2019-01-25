using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Solid.ISP.Violation
{
	public interface IPersist
	{
		void Validade();
		void Save();
		void SendEmail();
	}
}
