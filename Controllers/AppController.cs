namespace ServeFileDemo.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	/// <summary>
	/// Controller for App
	/// </summary>
	public class AppController : Controller
	{
		public IActionResult Index()
		{
			return this.View();
		}
	}
}
