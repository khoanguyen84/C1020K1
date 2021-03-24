using Shopping.Domain.Responses;
using System;
using System.Collections.Generic;
using Dapper;
using Shopping.DAL.Interface;
using System.Threading.Tasks;
using System.Data;

namespace Shopping.DAL.Implement
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public async Task<IEnumerable<Category>> Gets()
        {
            
            try
            {
                var result = await SqlMapper.QueryAsync<Category>(cnn: connection,
                                                                sql: "sp_GetCategories",
                                                                commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }

            //var query = "SELECT CategoryId, CategoryName FROM Category WHERE IsDeleted = 0";
            //var result = await SqlMapper.QueryAsync<Category>(cnn: connection,
            //                                                    sql: query,
            //                                                    commandType: CommandType.Text);
            return new List<Category>();
        }
    }
}
