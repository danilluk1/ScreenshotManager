namespace ScreenManagerBL.Model.SaveStrategy
{
    public class SaveContext
    {
        public ISaveStrategy ContextStrategy { get; set; }

        public SaveContext(ISaveStrategy _strategy)
        {
            ContextStrategy = _strategy;
        }

        public void DoSave()
        {
            ContextStrategy.Save();
        }
    }
}