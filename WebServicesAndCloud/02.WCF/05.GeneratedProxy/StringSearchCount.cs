﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IStringSearchCount")]
public interface IStringSearchCount
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringSearchCount/TimesStringFound", ReplyAction="http://tempuri.org/IStringSearchCount/TimesStringFoundResponse")]
    int TimesStringFound(string text, string searched);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStringSearchCount/TimesStringFound", ReplyAction="http://tempuri.org/IStringSearchCount/TimesStringFoundResponse")]
    System.Threading.Tasks.Task<int> TimesStringFoundAsync(string text, string searched);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IStringSearchCountChannel : IStringSearchCount, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class StringSearchCountClient : System.ServiceModel.ClientBase<IStringSearchCount>, IStringSearchCount
{
    
    public StringSearchCountClient()
    {
    }
    
    public StringSearchCountClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public StringSearchCountClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public StringSearchCountClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public StringSearchCountClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public int TimesStringFound(string text, string searched)
    {
        return base.Channel.TimesStringFound(text, searched);
    }
    
    public System.Threading.Tasks.Task<int> TimesStringFoundAsync(string text, string searched)
    {
        return base.Channel.TimesStringFoundAsync(text, searched);
    }
}
