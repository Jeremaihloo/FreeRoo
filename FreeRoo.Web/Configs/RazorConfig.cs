﻿using System.Collections.Generic;
using Nancy.ViewEngines.Razor;

namespace FreeRoo.Web
{

	/// <summary>
	/// Razor配置，如果你需要使用 cshtml，这个配置比较重要，当然，也可以在这儿加入其它的类
	/// </summary>
	public class RazorConfig : IRazorConfiguration
	{

		public IEnumerable<string> GetAssemblyNames ()
		{
			//加了这句，才能处理 cshtml
			yield return "System.Web.Razor";
		}

		public IEnumerable<string> GetDefaultNamespaces ()
		{
			yield return "System.Web.Razor";
		}

		public bool AutoIncludeModelNamespace {
			get { return true; }
		}
	}
		
}
