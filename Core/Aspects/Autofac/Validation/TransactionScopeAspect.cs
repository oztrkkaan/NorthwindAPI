﻿using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System;
using System.Transactions;

namespace Core.Aspects.Autofac.Validation
{
   public class TransactionScopeAspect:MethodInterception
    {
        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    invocation.Proceed();
                    transactionScope.Complete();
                }
                catch (Exception)
                {
                    transactionScope.Dispose();
                    throw;
                }
            }
        }
    }
}