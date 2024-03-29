﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationTest.ServiceMath {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMath.IServiceAddition")]
    public interface IServiceAddition {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAddition/Addition", ReplyAction="http://tempuri.org/IServiceAddition/AdditionResponse")]
        int Addition(int value1, int value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAddition/Addition", ReplyAction="http://tempuri.org/IServiceAddition/AdditionResponse")]
        System.Threading.Tasks.Task<int> AdditionAsync(int value1, int value2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAdditionChannel : WebApplicationTest.ServiceMath.IServiceAddition, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAdditionClient : System.ServiceModel.ClientBase<WebApplicationTest.ServiceMath.IServiceAddition>, WebApplicationTest.ServiceMath.IServiceAddition {
        
        public ServiceAdditionClient() {
        }
        
        public ServiceAdditionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAdditionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAdditionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAdditionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Addition(int value1, int value2) {
            return base.Channel.Addition(value1, value2);
        }
        
        public System.Threading.Tasks.Task<int> AdditionAsync(int value1, int value2) {
            return base.Channel.AdditionAsync(value1, value2);
        }
    }
}
