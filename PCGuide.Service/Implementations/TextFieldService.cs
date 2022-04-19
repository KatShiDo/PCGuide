using Microsoft.EntityFrameworkCore;
using PCGuide.DAL.Interfaces;
using PCGuide.DAL.Repositories;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using PCGuide.Domain.Response;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCGuide.Service.Implementations
{
    public class TextFieldService : ITextFieldService
    {
        private readonly IBaseRepository<TextField> _textFieldRepository;

        public TextFieldService(IBaseRepository<TextField> textFieldRepository)
        {
            _textFieldRepository = textFieldRepository;
        }

        public async Task<IBaseResponse<TextField>> EditTextFieldAsync(Guid id, TextFieldViewModel model)
        {
            var baseResponse = new BaseResponse<TextField>();

            try
            {
                var textField = await _textFieldRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (textField == null)
                {
                    baseResponse.Description = "News not found";
                    baseResponse.StatusCode = StatusCode.NotFound;

                    return baseResponse;
                }

                textField.Text = model.Text;
                textField.Title = model.Title;

                await _textFieldRepository.UpdateAsync(textField);

                baseResponse.Data = textField;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<TextField>()
                {
                    Description = $"[EditTextFieldAsync] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<TextFieldViewModel>> GetTextFieldByCodeWordAsync(string codeWord)
        {
            var baseResponse = new BaseResponse<TextFieldViewModel>();

            try
            {
                var textField = await _textFieldRepository.GetAll().FirstOrDefaultAsync(x => x.CodeWord == codeWord);

                if (textField == null)
                {
                    baseResponse.Description = "TextField not found";
                    baseResponse.StatusCode = StatusCode.NotFound;

                    return baseResponse;
                }

                var data = new TextFieldViewModel()
                {
                    Id = textField.Id,
                    CodeWord = textField.CodeWord,
                    Title = textField.Title,
                    Text = textField.Text,
                };

                baseResponse.Data = data;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<TextFieldViewModel>()
                {
                    Description = $"[GetTextFieldByCodeWord] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public IBaseResponse<IEnumerable<TextField>> GetTextFields()
        {
            var baseResponse = new BaseResponse<IEnumerable<TextField>>();

            try
            {
                var textFields = _textFieldRepository.GetAll();

                if (!textFields.Any())
                {
                    baseResponse.Description = "Found 0 elements";
                    baseResponse.StatusCode = StatusCode.OK;

                    return baseResponse;
                }

                baseResponse.Data = textFields;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<TextField>>()
                {
                    Description = $"[GetTextFields] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
