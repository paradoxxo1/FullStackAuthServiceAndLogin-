﻿using Onboarding_API.Core.Dtos.General;
using Onboarding_API.Core.Dtos.Message;
using System.Security.Claims;

namespace Onboarding_API.Core.Interfaces
{
    public interface IMessageService
    {
        Task<GeneralServiceResponseDto> CreateNewMessageAsync(ClaimsPrincipal User, CreateMessageDto createMessageDto);
        Task<IEnumerable<GetMessageDto>> GetMessagesAsync();
        Task<IEnumerable<GetMessageDto>> GetMyMessagesAsync(ClaimsPrincipal User);
    }
}
