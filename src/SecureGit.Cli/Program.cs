using SecureGit.Cli.Commands;
using SecureGit.Cli.Dispatching;

var commands = new ICommand[]{
    new InitCommand()
};

var dispatcher = new CommandDispatcher(commands);

var exitCode = await dispatcher.DispatchAsync(args);

Environment.Exit(exitCode);