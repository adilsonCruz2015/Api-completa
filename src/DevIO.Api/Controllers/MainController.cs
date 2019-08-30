using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        
    }

    [Route("api/fornecedores")]
    public  class FornecedoresController : MainController
    {

    }
}
