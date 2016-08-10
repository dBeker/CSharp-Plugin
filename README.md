# MEF-Plugin-CSharp
MEF plugin implementation under C#. 

In this example, MEF structure will be added and will be explained. 

## What is MEF

MEF is the framework which is provided by Microsoft natively under .NET. It provides API to bind methods dynamically. Hence, during compile time, the methods don't have to be statically bounded.

## Why it is used?

MEF is generally used for Plugin based structures where software is configurable based on user decisions. The purpose of using MEF is generally isolating the implementation from the caller method. Hence, if there is any change in implementation, there will not be any need of code change in caller methods. It will reduce the code amount to be changes, possible reduce the size of patch and provide elasticity to the software. Video processing softwares (i.e. directshow, gstreamer) are generally based on plugin based structures. 

## Explanation of the code

In this example, there are three projects. 

* <b>MefTrial</b> : This is the main project. It searches for plugin directory and loads other dlls dinamically. 
* <b>MefInterface</b> : This is the shared project which contains the interfaces (contracts) between implementation and caller. 
* <b>MefAuthentication</b> : This is the implementation of contracts defined in <b>MefInterface</b>.
 

To define which method is implementation of an interface, two attributes are used: `ImportAttribute` and `ExportAttribute`.
In the following example, the line `[Import(typeof(IAuthenticationManager))]` informs that Authentication object has to be initialized with type `IAuthenticationManager` while composing the class. If a property is marked to be imported, the property has to be public.

```
  [Import(typeof(IAuthenticationManager))]
  public IAuthenticationManager Authentication;
```

