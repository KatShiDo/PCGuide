using PCGuide.Domain.Entities;
using PCGuide.Domain.Response;
using PCGuide.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Service.Interfaces
{
    public interface ITextFieldService
    {
        IBaseResponse<IEnumerable<TextField>> GetTextFields();

        Task<IBaseResponse<TextFieldViewModel>> GetTextFieldByCodeWordAsync(string codeWord);

        //Task<IBaseResponse<News>> CreateNewsAsync(NewsViewModel model, byte[] imageData);

        //Task<IBaseResponse<bool>> DeleteNewsAsync(Guid id);

        Task<IBaseResponse<TextField>> EditTextFieldAsync(Guid id, TextFieldViewModel model);
    }
}
