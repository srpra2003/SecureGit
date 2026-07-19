using SecureGit.Core.Repositories;

namespace SecureGit.Cli.Commands {
    public sealed class InitCommand: ICommand {

        public string Name => "init";
        
        public async Task<int> ExecuteAsync(string[] args) {
            var repositoryService = new RepositoryService();

            repositoryService.Initialize(Directory.GetCurrentDirectory());

            Console.WriteLine("Initialized Empty Git Repository");
            return 0;
        }
    }
}