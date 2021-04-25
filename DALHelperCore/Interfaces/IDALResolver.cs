using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DALHelperCore.Interfaces
{
	public interface IDALResolver
	{
		MySqlConnectionStringBuilder GetConnectionBuilderFromConnectionType(Enum ConfigConnectionString);
	}
}
