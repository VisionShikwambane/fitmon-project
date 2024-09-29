using AutoMapper;
using fitmon_businesslogic;
using fitmon_datamodels;
using fitmon_dbcontext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fitmon_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestConroller : BaseController<TestRepository, Test, Test>
    {
        public TestConroller(FitmonDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
