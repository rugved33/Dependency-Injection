using System.Collections;
using System.Collections.Generic;
using DependencyInjection;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    [Inject]
    ServiceA serviceA;

    [Inject]
    ServiceB serviceB;

    FactoryA factory;

    [Inject]
    public void Init(FactoryA factoryA)
    {
        this.factory = factoryA;
    }

    private void Start()
    {
        serviceA.Initialize("Hi service A");
        serviceB.Initialize("Hi service B");

        serviceA = factory.CreateServiceA();
        serviceA.Initialize("new service created");
    }
}
