using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Helpers.Utils
{
    public interface IHandleContents<T> where T : class
    {
        Task CreateContents(int masterEntityId, ICollection<T> entity);
        //Task AddContentToTables(int languageId, )
    }
}
