﻿using APPLICATION.DOMAIN.UTILS.AUTH.CUSTOMAUTHORIZE.FILTER;
using APPLICATION.ENUMS;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace APPLICATION.DOMAIN.UTILS.AUTH;

public class CustomAuthorizeAttribute : TypeFilterAttribute
{
	public CustomAuthorizeAttribute(Claims claim, params string[] values) : base(typeof(CustomAuthorizeFilter))
	{
		Arguments = new object[] { values.Select(value => new Claim(claim.ToString(), value)).ToList() };
	}
}
