﻿namespace EasyCaching.Serialization.MessagePack
{
    using EasyCaching.Core;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;
    using System;

    public static class MessagePackSerializerServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the default message pack serializer.
        /// </summary>
        /// <returns>The default message pack serializer.</returns>
        /// <param name="services">Services.</param>
        public static IServiceCollection AddDefaultMessagePackSerializer(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.TryAddSingleton<IEasyCachingSerializer, DefaultMessagePackSerializer>();

            return services;
        }
    }
}
