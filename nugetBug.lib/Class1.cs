using Newtonsoft.Json;
using System;

namespace nugetBug.lib
{
    public class Class1
    {
        public string Method()
        {
            return JsonConvert.SerializeObject(new  { t = "test"});
        }
    }
}
