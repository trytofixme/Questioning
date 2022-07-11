using System;
using System.Collections.Generic;
using TestTask.Interfaces;
using TestTask.Models;
using TestTask.Utils;
using TestTask.Repository;

namespace TestTask.Utils
{
    public class CommandUtility
    {
        private static bool isRunning = true;
        private readonly IDictionary<string, ICommand> CommandDictonary = new Dictionary<string, ICommand>();
        private Person profile = new Person();

        public CommandUtility(IEnumerable<ICommand> commands, Person profile)
        {

            foreach (var cmd in commands)
            {
                CommandDictonary.Add(cmd.CommandName, cmd);
            }
            this.profile = profile;
        }

        public bool IsRunning { get { return isRunning; } internal set { isRunning = value; } }

        public void RunCmd(string cmdString)
        {
            ICommand? command = null;


            if (string.IsNullOrWhiteSpace(cmdString))
                return;

            cmdString = cmdString.TrimStart();
            var cmd = cmdString.Split(" ")[0];
            if (CommandDictonary.TryGetValue(cmd, out command))
            {
                var param = cmdString.Substring(cmd.Length).Trim();
                var response = command.Execute(profile, param);
                CheckResponse(response);
            }
            else
                Console.WriteLine($"Неизвестная команда: {cmd}");
        }



        private void CheckResponse(IResponse response)
        {
            if (response == null)
                return;

            var RespType = response.responseType;
            if (RespType.Empty)
            {
                Console.WriteLine("Команда не выполнена");
            }
            if (RespType.Processed && !RespType.Empty)
            {
                this.profile = response.Data;
            }
        }
    }
}

