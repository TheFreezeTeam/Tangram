namespace Tangram
{
  using System.CommandLine.Builder;
  using System.CommandLine.Invocation;
  using FluentValidation;
  using MediatR.Pipeline;
  using Microsoft.Extensions.DependencyInjection;
  using Tangram.Behaviors;
  using Tangram.Services;
  using Tangram.Commands.SampleCommand;
  using Tangram.Commands.VaultUnseal;

  internal class Startup
  {
    public void Configure(TimeWarpCommandLineBuilder aTimeWarpCommandLineBuilder)
    {
      aTimeWarpCommandLineBuilder
        .UseVersionOption()
        // middleware
        .UseHelp()
        .UseParseDirective()
        .UseDebugDirective()
        .UseSuggestDirective()
        .RegisterWithDotnetSuggest()
        .UseParseErrorReporting()
        .UseExceptionHandler();
    }

    public void ConfigureServices(IServiceCollection aServiceCollection)
    {
      aServiceCollection.AddScoped(typeof(IRequestPreProcessor<>), typeof(ValidationBehavior<>));
      aServiceCollection.AddScoped(typeof(IValidator<SampleCommandRequest>), typeof(SampleCommandValidator));
      aServiceCollection.AddScoped(typeof(IValidator<VaultUnsealCommand>), typeof(VaultUnsealValidator));
      aServiceCollection.AddLogging();
      aServiceCollection.AddSingleton<GitService>();
    }
  }
}