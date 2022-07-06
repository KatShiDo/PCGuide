using Microsoft.EntityFrameworkCore;
using PCGuide.DAL.Interfaces;
using PCGuide.Domain.Entities;
using PCGuide.Domain.Enum;
using PCGuide.Domain.Response;
using PCGuide.Domain.ViewModels;
using PCGuide.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCGuide.Service.Implementations
{
    public class TextFieldService : IBaseService<TextField, TextFieldViewModel>
    {
        private readonly IBaseRepository<TextField> _textFieldRepository;

        public TextFieldService(IBaseRepository<TextField> textFieldRepository)
        {
            _textFieldRepository = textFieldRepository;
        }

        public async Task<IBaseResponse<TextField>> EditAsync(TextFieldViewModel viewModel)
        {
            try
            {
                var textField = await _textFieldRepository.GetAll().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

                if (textField == null)
                {
                    return new BaseResponse<TextField>
                    {
                        Description = "TextField not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                viewModel.CopyToModel(ref textField);
                await _textFieldRepository.UpdateAsync(textField);

                return new BaseResponse<TextField>
                {
                    Data = textField,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<TextField>()
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public IBaseResponse<IEnumerable<TextField>> GetAll()
        {
            try
            {
                var textFields = _textFieldRepository.GetAll();

                if (!textFields.Any())
                {
                    return new BaseResponse<IEnumerable<TextField>>
                    {
                        Description = "Found 0 elements",
                        StatusCode = StatusCode.OK,
                        Data = textFields
                    };
                }

                return new BaseResponse<IEnumerable<TextField>>
                {
                    Data = textFields,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<TextField>>()
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<TextFieldViewModel>> GetByIdAsync(Guid id)
        {
            try
            {
                var textField = await _textFieldRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (textField == null)
                {
                    return new BaseResponse<TextFieldViewModel>
                    {
                        Description = "TextField not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<TextFieldViewModel>
                {
                    Data = (TextFieldViewModel)textField,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<TextFieldViewModel>()
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<TextField>> CreateAsync(TextFieldViewModel viewModel)
        {
            try
            {
                var textFields = (TextField)viewModel;
                await _textFieldRepository.CreateAsync(textFields);

                return new BaseResponse<TextField>
                {
                    StatusCode = StatusCode.OK,
                    Data = textFields
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<TextField>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<bool>> DeleteAsync(Guid id)
        {
            try
            {
                var textFields = await _textFieldRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (textFields == null)
                {
                    return new BaseResponse<bool>
                    {
                        Description = "News not found",
                        StatusCode = StatusCode.NotFound,
                        Data = false
                    };
                }

                await _textFieldRepository.DeleteAsync(textFields);

                return new BaseResponse<bool>
                {
                    StatusCode = StatusCode.OK,
                    Data = true
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<TextField>> GetModelByIdAsync(Guid id)
        {
            try
            {
                var textField = await _textFieldRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);

                if (textField == null)
                {
                    return new BaseResponse<TextField>
                    {
                        Description = "TextField not found",
                        StatusCode = StatusCode.NotFound
                    };
                }

                return new BaseResponse<TextField>
                {
                    Data = textField,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<TextField>()
                {
                    Description = $"[{System.Reflection.MethodBase.GetCurrentMethod().Name}] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
