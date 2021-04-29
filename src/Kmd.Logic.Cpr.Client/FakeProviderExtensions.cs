﻿using System;
using System.Threading.Tasks;
using Kmd.Logic.Cpr.Client.Models;

namespace Kmd.Logic.Cpr.Client
{
    public static class FakeProviderExtensions
    {
        public static async Task<FakeProviderConfigurationModel> CreateFakeProviderConfiguration(this CprClient cprClient, string name)
        {
            if (cprClient == null)
            {
                throw new ArgumentException("Client cannot be null", nameof(cprClient));
            }

            var client = cprClient.CreateClient();

            using var response = await client.CreateFakeProviderConfigurationWithHttpMessagesAsync(
                cprClient.GetOptions().SubscriptionId,
                name).ConfigureAwait(false);

            switch (response.Response.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return response.Body;

                case System.Net.HttpStatusCode.NotFound:
                    return null;

                default:
                    throw new CprConfigurationException(response.Response?.ReasonPhrase ?? "Provider configuration creation failed");
            }
        }

        public static async Task<FakeProviderConfigurationModel> UpdateFakeProviderConfiguration(
            this CprClient cprClient,
            Guid configurationId,
            string name)
        {
            if (cprClient == null)
            {
                throw new ArgumentException("Client cannot be null", nameof(cprClient));
            }

            var client = cprClient.CreateClient();

            using var response = await client.UpdateFakeProviderConfigurationWithHttpMessagesAsync(
                cprClient.GetOptions().SubscriptionId,
                configurationId,
                name).ConfigureAwait(false);

            switch (response.Response.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return response.Body;

                case System.Net.HttpStatusCode.NotFound:
                    throw new CprConfigurationException("Configuration not found");

                default:
                    throw new CprConfigurationException(response.Response?.ReasonPhrase ?? "Provider configuration update failed");
            }
        }
    }
}