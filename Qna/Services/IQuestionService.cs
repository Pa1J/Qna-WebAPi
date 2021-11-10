using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qna.Services
{
    public interface IQuestionService
    {
        Boolean AddQuestion(Models.CoreModels.Question newQuestion);
        List<Models.CoreModels.QuesView> GetQuestionView();
        Boolean IncreaseVotes(Models.CoreModels.Voted newVote);
        Boolean IncreaseViews(Models.CoreModels.Viewed newView);
    }
}
