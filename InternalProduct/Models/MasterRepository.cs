using Dapper;
using System.Data;
using System.Net.Sockets;

namespace InternalProduct.Models
{
    public class MasterRepository
    {
        private readonly DbContext _dbContext;

        public MasterRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
    }
}
