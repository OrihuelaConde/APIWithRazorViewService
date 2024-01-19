using APIWithRazorViewService.Models;
using APIWithRazorViewService.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIWithRazorViewService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        private readonly IViewRenderService _viewRenderService;
        private readonly HttpClient _httpClient;

        public FruitsController(IViewRenderService viewRenderService, HttpClient httpClient)
        {
            _viewRenderService = viewRenderService;
            _httpClient = httpClient;
        }

        // GET: api/<FruitsController>
        [HttpGet]
        public async Task<string> Get()
        {
            try
            {
                var fruits = await _httpClient.GetFromJsonAsync<Fruit[]>("/api/fruit/all");
                if (fruits != null)
                {
                    var random = new Random().Next(0, fruits.Length);
                    return await _viewRenderService.RenderToStringAsync("Fruits", fruits[random]);
                }
                return "No fruits found";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
