namespace BibleApp.BibleApiModels
{
    public class DataWrapper<T> where T : class
    {
        public T data { get; set; }
    }
}
