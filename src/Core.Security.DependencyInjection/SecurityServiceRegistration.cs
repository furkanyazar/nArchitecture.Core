﻿using Microsoft.Extensions.DependencyInjection;
using Core.Security.EmailAuthenticator;
using Core.Security.JWT;
using Core.Security.OtpAuthenticator;
using Core.Security.OtpAuthenticator.OtpNet;

namespace Core.Security.DependencyInjection;

public static class SecurityServiceRegistration
{
    public static IServiceCollection AddSecurityServices<TUserId, TOperationClaimId, TRefreshTokenId>(
        this IServiceCollection services,
        TokenOptions tokenOptions
    )
    {
        services.AddScoped<
            ITokenHelper<TUserId, TOperationClaimId, TRefreshTokenId>,
            JwtHelper<TUserId, TOperationClaimId, TRefreshTokenId>
        >(_ => new JwtHelper<TUserId, TOperationClaimId, TRefreshTokenId>(tokenOptions));
        services.AddScoped<IEmailAuthenticatorHelper, EmailAuthenticatorHelper>();
        services.AddScoped<IOtpAuthenticatorHelper, OtpNetOtpAuthenticatorHelper>();
        services.AddSingleton(_ => tokenOptions);

        return services;
    }
}
