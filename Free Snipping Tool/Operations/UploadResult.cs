using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Upload
{
    public string slug { get; set; }
    public string media_filename { get; set; }
    public string cdn_url { get; set; }
}

public class RootObject
{
    public Upload upload { get; set; }
}

