using Qna.Models.CoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qna.Services
{
    public interface IAnswerService
    {
        List<Models.CoreModels.AnswerView> GetAnswerView();
        Boolean AddAnswer(Models.CoreModels.Answer newAnswer);
        Boolean LikeAnswer(Models.CoreModels.Liked newLike);
        Boolean ChangeBestSolution(Models.CoreModels.Answer bestAnswer);
    }
}
