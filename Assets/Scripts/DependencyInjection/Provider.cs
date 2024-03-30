using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace DependencyInjection
{
    public class ServiceA
    {
        public void Initialize(string message)
        {
            Debug.Log($"ServiceA intialize{message}");
        }
    }
    public class ServiceB
    {
        public void Initialize(string message)
        {
            Debug.Log($"ServiceA intialize{message}");
        }
    }

    public class FactoryA
    {
        ServiceA cachedServiceA;
        public ServiceA CreateServiceA()
        {
            if (cachedServiceA == null)
            {
                cachedServiceA = new ServiceA();
            }
            return cachedServiceA;
        }
    }
    public class Provider : MonoBehaviour, IDependencyProvider
    {
        [Provide]
        public ServiceA ProvideServiceA()
        {
            return new ServiceA();
        }

        [Provide]
        public ServiceB ProvideServiceB()
        {
            return new ServiceB();
        }

        [Provide]
        public FactoryA ProvideFactoryA()
        {
            return new FactoryA();
        }
    }
}