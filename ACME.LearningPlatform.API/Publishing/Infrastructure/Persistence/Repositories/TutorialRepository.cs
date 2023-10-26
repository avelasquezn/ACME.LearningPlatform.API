using ACME.LearningPlatform.API.Publishing.Domain.Model.Aggregates;
using ACME.LearningPlatform.API.Publishing.Domain.Repositories;
using ACME.LearningPlatform.API.Shared.Infrastructure.Persistence.Configuration;
using ACME.LearningPlatform.API.Shared.Infrastructure.Persistence.Repositories;

namespace ACME.LearningPlatform.API.Publishing.Infrastructure.Persistence.Repositories;

public class TutorialRepository: BaseRepository<Tutorial>, ITutorialRepository 
{
    public TutorialRepository(AppDbContext context) : base(context)
    {
    }
}