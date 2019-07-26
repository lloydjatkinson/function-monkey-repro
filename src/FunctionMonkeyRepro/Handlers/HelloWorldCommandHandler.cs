using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AzureFromTheTrenches.Commanding.Abstractions;
using FunctionMonkeyRepro.Commands;

namespace FunctionMonkeyRepro.Handlers
{
    public class HelloWorldCommandHandler : ICommandHandler<HelloWorldCommand, string>
    {
        public Task<string> ExecuteAsync(HelloWorldCommand command, string previousResult)
        {
            if (string.IsNullOrWhiteSpace(command.Message))
            {
                return Task.FromResult("Hello stranger");
            }
            return Task.FromResult($"Hello {command.Message}");
        }
    }
}
