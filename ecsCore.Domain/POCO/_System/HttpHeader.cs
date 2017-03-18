using System;
using System.Collections.Generic;
using System.Text;

namespace ecsCore.Domain.POCO
{
    public class HttpHeader
    {
	public string scheme { get; set; }
    public string model { get; set; }
    public string verb { get; set; }
    public string param { get; set; }
    }
}
