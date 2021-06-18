using Shopping.Domain.Responses;
using System;
using System.Collections.Generic;
using Dapper;
using Shopping.DAL.Interface;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Extensions.Configuration;
using Shopping.Domain.Requests;
using Shopping.Domain;

namespace Shopping.DAL.Implement
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(IConfiguration  configuration) : base(configuration)
        {

        }

        public async Task<int> CreateCategory(CreateCategoryReq request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryName", request.CategoryName);
                var result = await SqlMapper.QueryFirstAsync<int>(
                                                cnn: connection,
                                                sql: Helper.GetEnumDescription(Constant.SP.sp_CreateCategory),
                                                param: parameters,
                                                commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }

        public async Task<CreateCategoryRes> CreateCategory2(CreateCategoryReq request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryName", request.CategoryName);
                var result = await SqlMapper.QueryFirstAsync<CreateCategoryRes>(
                                                cnn: connection,
                                                sql: Helper.GetEnumDescription(Constant.SP.sp_CreateCategory2),
                                                param: parameters,
                                                commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return new CreateCategoryRes();
            }
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryId", categoryId);
                var result = await SqlMapper.QueryFirstOrDefaultAsync<Category>(
                                                cnn: connection,
                                                sql: "sp_GetCategoryById",
                                                param: parameters,
                                                commandType: CommandType.StoredProcedure);
                return result;

            }
            catch (Exception ex)
            {
                return new Category();
            }
            
        }

        public async Task<Category> GetCategoryByName(string categoryName)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CategoryName", categoryName);
                var result = await SqlMapper.QueryFirstOrDefaultAsync<Category>(
                                                cnn: connection,
                                                sql: "sp_GetCategoryByName",
                                                param: parameters,
                                                commandType: CommandType.StoredProcedure);
                return result;

            }
            catch (Exception ex)
            {
                return new Category();
            }
        }

        public async Task<IEnumerable<Category>> Gets()
        {
            
            try
            {
                var result = await SqlMapper.QueryAsync<Category>(cnn: connection,
                                                                sql: Helper.GetEnumDescription(Constant.SP.sp_GetCategories),
                                                                commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                return new List<Category>();
            }

            //var query = "SELECT CategoryId, CategoryName FROM Category WHERE IsDeleted = 0";
            //var result = await SqlMapper.QueryAsync<Category>(cnn: connection,
            //                                                    sql: query,
            //                                                    commandType: CommandType.Text);
            
        }
    }
}
