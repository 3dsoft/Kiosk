namespace Microsoft.AspNetCore.Mvc.RazorPages
{
    public static class PageModelExtensions
    {
        public static void SetStatusMessage(this PageModel pageModel, string message)
        {
            pageModel.TempData["StatusMessage"] = message;
        }
    }
}
