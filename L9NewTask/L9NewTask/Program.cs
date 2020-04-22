using System;
using System.Collections.Generic;
using System.IO;
namespace L9NewTask
{
    class Program
    {
        static void Main(string[] args)
        {
            PopularWords words = new PopularWords();
            words.InitDictionary();
            words.GetAnswer(words.InitDictionary());
        }
        
    }
}
