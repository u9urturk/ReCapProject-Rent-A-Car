using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Castle.DynamicProxy;
using Core.Utilities.SendMail;
using System.Net.Mail;

namespace Core.Aspects.Autofac.Performance
{
    public class PerformanceAspect:MethodInterception,ISendMail
    {
        private int _interval;
        private Stopwatch _stopwatch;
        
        public PerformanceAspect(int interval)
        {
            _interval = interval;
            _stopwatch = ServiceTool.ServiceProvider.GetService<Stopwatch>();
            
        }

        protected override void OnBefore(IInvocation invocation)
        {
            _stopwatch.Start();
        }

        protected override void OnAfter(IInvocation invocation)
        {
            if (_stopwatch.Elapsed.Seconds>_interval)
            {
                //Performans bilgisi belirtilen mail hesabına iletilecek.
                SendMail sendMail = new SendMail();

                sendMail.Send("dened9761@gmail.com",
                               "password",
                               "ADMIN",
                               "l4rnxy@gmail.com",
                               "Sistem Performansı",
                               $"Performance : {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name}-->{_stopwatch.Elapsed.TotalSeconds}",
                               "smtp.gmail.com",587);


            }
            _stopwatch.Reset();

           
        }
    }
}
