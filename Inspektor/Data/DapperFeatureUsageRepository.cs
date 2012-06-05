using System.Data.SqlClient;
using System.Linq;
using System.Web.Configuration;
using Dapper;
using Inspektor.Models;

namespace Inspektor.Data
{
    public class DapperFeatureUsageRepository:IRepository<FeatureUsage>
    {
        public IQueryable<FeatureUsage> Find()
        {
            var connectionString = WebConfigurationManager.ConnectionStrings["Cortex"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var sql = @"select  f.application_name as ApplicationName,
                                    f.feature_name as FeatureName,
                                    u.Notes as Notes,
                                    u.UsedBy as UsedBy,
                                    u.UsedDate as UsedDate
                            from    dbo.FEATURE F
                            join    dbo.FEATURE_USAGE U on F.feature_id = U.feature_id";
                var results = connection.Query<FeatureUsage>(sql);

                connection.Close();

                return new EnumerableQuery<FeatureUsage>(results);
            }
        }
    }
}