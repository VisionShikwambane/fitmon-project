using AutoMapper;
using fitmon_datamodels;
using fitmon_dbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitmon_businesslogic
{
    public class TestRepository : BaseRepository<Test, Test>
    {
        public TestRepository(FitmonDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {

        }
    }
}
