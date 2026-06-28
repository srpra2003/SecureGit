using SecureGit.Cli.Commands;

namespace SecureGit.Cli.Dispatching {
    public sealed class CommandDispatcher {
        private readonly Dictionary<string, ICommand> _commands;

        public CommandDispatcher(IEnumerable<ICommand> commands) {
            _commands = commands.ToDictionary(
                command => command.Name,
                StringComparer.OrdinalIgnoreCase);
        }

        public async Task<int> DispatchAsync(string[] args) {
            if(args.Length == 0) {
                Console.WriteLine("No Command specified");
                return 1;
            }

            var commandName = args[0];

            if(!_commands.TryGetValue(commandName, out var command)) {
                Console.WriteLine($"Unknown Command '{commandName}'");
                return 1;
            }

            return await command.ExecuteAsync(args.Skip(1).ToArray());
        }
    }    
}