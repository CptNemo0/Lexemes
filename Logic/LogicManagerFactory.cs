namespace Logic
{
    public enum ILogicEnum
    {
        STANDARD
    }

    public static class LogicManagerFactory
    {
        public static ILogic CreateLogicManager(ILogicEnum type)
        {
            if (type == ILogicEnum.STANDARD)
            {
                return new LogicManager();
            }

            throw new Exception("Wrong enum type!!!");
        }
    }
}
