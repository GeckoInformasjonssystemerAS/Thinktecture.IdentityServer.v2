﻿using System.ServiceModel.Activation;
using System.Web.Mvc;
using System.Web.Routing;
using Thinktecture.IdentityServer.Protocols.WSTrust;
using Thinktecture.IdentityServer.Repositories;
using Thinktecture.IdentityServer.TokenService;

namespace Thinktecture.IdentityServer.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes, IConfigurationRepository configuration, IUserRepository userRepository)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            #region Administration & Configuration
            routes.MapRoute(
                "InitialConfiguration",
                "initialconfiguration",
                new { controller = "InitialConfiguration", action = "Index" }
            );

            routes.MapRoute(
                "RelyingPartiesAdmin",
                "admin/relyingparties/{action}/{id}",
                new { controller = "RelyingPartiesAdmin", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "ClientCertificatesAdmin",
                "admin/clientcertificates/{action}/{userName}",
                new { controller = "ClientCertificatesAdmin", action = "Index", userName = UrlParameter.Optional }
            );

            routes.MapRoute(
                "DelegationAdmin",
                "admin/delegation/{action}/{userName}",
                new { controller = "DelegationAdmin", action = "Index", userName = UrlParameter.Optional }
            );
            #endregion

            #region Main UI
            routes.MapRoute(
                "Account",
                "account/{action}",
                new { controller = "Account", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "Home",
                "{action}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            #endregion
        }

    }
}