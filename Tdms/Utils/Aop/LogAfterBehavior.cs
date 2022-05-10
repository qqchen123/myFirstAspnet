using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace Tdms.Utils.Aop
{
    public class LogAfterBehavior : IInterceptionBehavior
    {
        Logger logger = new Logger(typeof(LogAfterBehavior));
        public bool WillExecute => true;

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            //throw new NotImplementedException();
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            logger.Info("执行之前。。。");
            //throw new NotImplementedException();
            IMethodReturn methodReturn = getNext()(input,getNext);
            logger.Info("执行之后。。。");

            return methodReturn;

        }
    }
}