using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;

//namespace ZapateriaAPI.App_Start
//{
public class MsDiHttpControllerActivator : IHttpControllerActivator
{
    private readonly ServiceProvider provider;

    public MsDiHttpControllerActivator(ServiceProvider provider)
    {
        this.provider = provider;
    }

    public IHttpController Create(
        HttpRequestMessage request, HttpControllerDescriptor descriptor, Type type)
    {
        var scope = this.provider.CreateScope();
        request.RegisterForDispose(scope);
        return (IHttpController)scope.ServiceProvider.GetRequiredService(type);
    }
}
//}