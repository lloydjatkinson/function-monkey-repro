using System;
using System.Collections.Generic;
using System.Text;
using AzureFromTheTrenches.Commanding.Abstractions;

namespace FunctionMonkeyRepro.Commands
{
    public class HelloWorldCommand : ICommand<string>
    {
        public string Message { get; set; }
    }
}
