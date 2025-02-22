﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApplication.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfTranslationLibrary")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginalStrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeStampField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TranslationStrField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OriginalStr {
            get {
                return this.OriginalStrField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginalStrField, value) != true)) {
                    this.OriginalStrField = value;
                    this.RaisePropertyChanged("OriginalStr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp {
            get {
                return this.TimeStampField;
            }
            set {
                if ((this.TimeStampField.Equals(value) != true)) {
                    this.TimeStampField = value;
                    this.RaisePropertyChanged("TimeStamp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TranslationStr {
            get {
                return this.TranslationStrField;
            }
            set {
                if ((object.ReferenceEquals(this.TranslationStrField, value) != true)) {
                    this.TranslationStrField = value;
                    this.RaisePropertyChanged("TranslationStr");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITranslationService")]
    public interface ITranslationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITranslationService/TranslateToPigLatin", ReplyAction="http://tempuri.org/ITranslationService/TranslateToPigLatinResponse")]
        ClientApplication.ServiceReference1.CompositeType TranslateToPigLatin(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITranslationService/TranslateToPigLatin", ReplyAction="http://tempuri.org/ITranslationService/TranslateToPigLatinResponse")]
        System.Threading.Tasks.Task<ClientApplication.ServiceReference1.CompositeType> TranslateToPigLatinAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITranslationService/TranslateToRussian", ReplyAction="http://tempuri.org/ITranslationService/TranslateToRussianResponse")]
        ClientApplication.ServiceReference1.CompositeType TranslateToRussian(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITranslationService/TranslateToRussian", ReplyAction="http://tempuri.org/ITranslationService/TranslateToRussianResponse")]
        System.Threading.Tasks.Task<ClientApplication.ServiceReference1.CompositeType> TranslateToRussianAsync(string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITranslationServiceChannel : ClientApplication.ServiceReference1.ITranslationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TranslationServiceClient : System.ServiceModel.ClientBase<ClientApplication.ServiceReference1.ITranslationService>, ClientApplication.ServiceReference1.ITranslationService {
        
        public TranslationServiceClient() {
        }
        
        public TranslationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TranslationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TranslationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TranslationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClientApplication.ServiceReference1.CompositeType TranslateToPigLatin(string value) {
            return base.Channel.TranslateToPigLatin(value);
        }
        
        public System.Threading.Tasks.Task<ClientApplication.ServiceReference1.CompositeType> TranslateToPigLatinAsync(string value) {
            return base.Channel.TranslateToPigLatinAsync(value);
        }
        
        public ClientApplication.ServiceReference1.CompositeType TranslateToRussian(string value) {
            return base.Channel.TranslateToRussian(value);
        }
        
        public System.Threading.Tasks.Task<ClientApplication.ServiceReference1.CompositeType> TranslateToRussianAsync(string value) {
            return base.Channel.TranslateToRussianAsync(value);
        }
    }
}
