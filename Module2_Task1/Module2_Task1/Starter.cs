using System;

namespace Module2_Task1
{
    internal class Starter
    {
        internal void Run()
        {
            var rand = new Random();
            var tempAction = new Action();
            Result tempResult;
            for (int i = 0; i < 100; i++)
            {
                switch (rand.Next(1, 4))
                {
                    case 1:
                        tempResult = tempAction.InfoLog();
                        break;
                    case 2:
                        tempResult = tempAction.WarningLog();
                        break;
                    default:
                        tempResult = tempAction.ErrorLog();
                        break;
                }

                if (tempResult.Status == false)
                {
                    Logger.LoggerInstance.PushToLog(LogType.Error, "Action failed by a reason: " + tempResult.ErrorMessage);
                }
            }
        }
    }
}
