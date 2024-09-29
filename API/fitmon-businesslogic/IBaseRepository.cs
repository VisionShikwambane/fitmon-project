using fitmon_datamodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitmon_businesslogic
{
    public interface IBaseRepository<T, TDTO> where T : class
    {
        Task<IEnumerable<TDTO>> GetAll();
        Task<TDTO> GetById(int Id);
        Task<ResponseObject<IEnumerable<TDTO>>> AddRange(IEnumerable<TDTO> dtos);
        Task<ResponseObject<TDTO>> Add(TDTO dto);
        Task<ResponseObject<bool>> Delete(int id);

        Task<ResponseObject<bool>> DeleteRange(IEnumerable<int> ids);

    }
}
