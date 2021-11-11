namespace Module2_Task1
{
    internal class Action
    {
        internal Result InfoLog()
        {
            Logger.LoggerInstance.PushToLog(LogType.Info, "Start method: InfoLog");
            return new Result { Status = true };
        }

        internal Result WarningLog()
        {
            Logger.LoggerInstance.PushToLog(LogType.Warning, "Skipped logic in method: WarningLog");
            return new Result { Status = true };
        }

        internal Result ErrorLog()
        {
            return new Result { Status = false, ErrorMessage = "I broke a logic" };
        }
    }
}
