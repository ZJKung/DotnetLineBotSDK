using System;
using Microsoft.AspNetCore.Mvc;

namespace DotnetcoreLineBot.Filters
{
    public class LineVerifySignatureAttribute : TypeFilterAttribute
    {
        public LineVerifySignatureAttribute() : base(typeof(LineVerifySignatureFilter))
        {

        }
    }
}
