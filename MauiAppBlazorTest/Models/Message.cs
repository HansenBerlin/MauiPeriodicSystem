using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBlazorTest.Models;

public class Message
{
    public Dictionary<int, bool> ActiveLeds { get; set; } = new();
}
