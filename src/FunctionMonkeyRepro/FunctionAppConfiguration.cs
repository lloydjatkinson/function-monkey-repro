using System;
using System.Collections.Generic;
using System.Text;
using FunctionMonkey.Abstractions.Builders;
using FunctionMonkeyRepro.Commands;
using FunctionMonkeyRepro.Handlers;

namespace FunctionMonkeyRepro
{
    public class FunctionAppConfiguration
    {
        public void Build(IFunctionHostBuilder builder)
        {
            builder
                .Setup((serviceCollection, commandRegistry) =>
                {
                    commandRegistry.Register<HelloWorldCommandHandler>();
                })
                .Functions(functions => functions
                    .HttpRoute("v1/HelloWorld", route => route
                        .HttpFunction<HelloWorldCommand>()
                    )
                );
        }
    }
}
