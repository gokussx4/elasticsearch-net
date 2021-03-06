﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.Cluster.Ping
{
	public class PingUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls()
		{
			await HEAD("/")
				.Fluent(c => c.Ping())
				.Request(c => c.Ping(new PingRequest()))
				.FluentAsync(c => c.PingAsync())
				.RequestAsync(c => c.PingAsync(new PingRequest()))
				;
		}
	}
}
