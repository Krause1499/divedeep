namespace DiveDeep.Services
{
    public class OrderResult
    {
        public bool IsSuccessful { get; set; }
        public string Key { get; set; }
        public string ErrorMessage { get; set; }

        public static OrderResult Ok() => new() { IsSuccessful = true };
        public static OrderResult Fail(string key, string message)
            => new() { IsSuccessful = false, Key = key, ErrorMessage = message };
    }
}
