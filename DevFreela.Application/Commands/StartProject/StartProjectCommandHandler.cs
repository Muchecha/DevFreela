using Azure.Core;
using Dapper;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DevFreela.Application.Commands.StartProject
{
    public class StartProjectCommandHandler: IRequestHandler<StartProjectCommand, Unit>
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly string _connectionString;
        public StartProjectCommandHandler(DevFreelaDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("DevFreelaCs"); 
        }
        public async Task<Unit> Handle(StartProjectCommand request, CancellationToken cancellationToken)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == request.Id);

            project.Start();

            await _dbContext.SaveChangesAsync();

            //using(var sqlConnection = new SqlConnection(_connectionString))
            //{
            //    sqlConnection.Open();

            //    var scrip = "UPDATE Projects SET Status = @status, StartedAt = @startedAt WHERE Id = @id";

            //    await sqlConnection.ExecuteAsync(scrip, new { status = project.Status, startedat = project.StartedAt, project.Id });
            //}

            return Unit.Value;
        }
    }
}
