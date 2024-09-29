using AutoMapper;
using fitmon_businesslogic;
using fitmon_dbcontext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;






namespace fitmon_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<IRepository, T, TDTO> : ODataController where IRepository : class, IBaseRepository<T, TDTO> where T : class
    {
        private readonly FitmonDbContext dbContext;
        protected readonly IRepository repository;
        private readonly IMapper mapper;

        public BaseController(FitmonDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.repository = (IRepository)Activator.CreateInstance(typeof(IRepository), dbContext, mapper)!;
        }

        [EnableQuery]
        [HttpGet]
        public virtual async Task<IEnumerable<TDTO>> Get()
        {
            return await repository.GetAll();
        }

        [EnableQuery]
        [HttpGet("{key}")]
        public virtual async Task<TDTO> Get(int key)
        {
            var response = await repository.GetById(key);
            return response;
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] TDTO dto)
        {
            var response = await repository.Add(dto);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            var response = await repository.Delete(id);
            return Ok(response);
        }

         [HttpPost("SaveRange")]
        public virtual async Task<IActionResult> SaveRange([FromBody] IEnumerable<TDTO> dtos)
        {
            var response = await repository.AddRange(dtos);
            return Ok(response);
        }

        [HttpDelete("DeleteRange")]
        public virtual async Task<IActionResult> DeleteRange([FromBody] IEnumerable<int> ids)
        {
            var response = await repository.DeleteRange(ids);
            return Ok(response);
        }





    }
}
