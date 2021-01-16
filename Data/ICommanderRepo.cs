namespace Commander.Data
{
    // methods signatures
    public interface ICommanderRepo {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }

   
}