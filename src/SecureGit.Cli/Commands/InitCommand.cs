namespace SecureGit.Cli.Commands {
    public sealed class InitCommand: ICommand {

        public string Name => "init";
        
        public Task<int> ExecuteAsync(string[] args) {
            Console.WriteLine("SecureGit repository initialization is not implemented yet.");
            return Task.FromResult(0);
        }
    }
}