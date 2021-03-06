﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeagueManager.WPF.LMService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SetupContract", Namespace="http://schemas.datacontract.org/2004/07/LeagueManager.Service")]
    [System.SerializableAttribute()]
    public partial class SetupContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdcField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JungleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlayerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SuppField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TopField;
        
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
        public string Adc {
            get {
                return this.AdcField;
            }
            set {
                if ((object.ReferenceEquals(this.AdcField, value) != true)) {
                    this.AdcField = value;
                    this.RaisePropertyChanged("Adc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Jungle {
            get {
                return this.JungleField;
            }
            set {
                if ((object.ReferenceEquals(this.JungleField, value) != true)) {
                    this.JungleField = value;
                    this.RaisePropertyChanged("Jungle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mid {
            get {
                return this.MidField;
            }
            set {
                if ((object.ReferenceEquals(this.MidField, value) != true)) {
                    this.MidField = value;
                    this.RaisePropertyChanged("Mid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlayerName {
            get {
                return this.PlayerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayerNameField, value) != true)) {
                    this.PlayerNameField = value;
                    this.RaisePropertyChanged("PlayerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Supp {
            get {
                return this.SuppField;
            }
            set {
                if ((object.ReferenceEquals(this.SuppField, value) != true)) {
                    this.SuppField = value;
                    this.RaisePropertyChanged("Supp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Top {
            get {
                return this.TopField;
            }
            set {
                if ((object.ReferenceEquals(this.TopField, value) != true)) {
                    this.TopField = value;
                    this.RaisePropertyChanged("Top");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GameContract", Namespace="http://schemas.datacontract.org/2004/07/LeagueManager.Service")]
    [System.SerializableAttribute()]
    public partial class GameContract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LeagueManager.WPF.LMService.SetupContract PlayerOneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LeagueManager.WPF.LMService.SetupContract PlayerTwoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeStampField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LeagueManager.WPF.LMService.SetupContract WinnerField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LeagueManager.WPF.LMService.SetupContract PlayerOne {
            get {
                return this.PlayerOneField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayerOneField, value) != true)) {
                    this.PlayerOneField = value;
                    this.RaisePropertyChanged("PlayerOne");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LeagueManager.WPF.LMService.SetupContract PlayerTwo {
            get {
                return this.PlayerTwoField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayerTwoField, value) != true)) {
                    this.PlayerTwoField = value;
                    this.RaisePropertyChanged("PlayerTwo");
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
        public LeagueManager.WPF.LMService.SetupContract Winner {
            get {
                return this.WinnerField;
            }
            set {
                if ((object.ReferenceEquals(this.WinnerField, value) != true)) {
                    this.WinnerField = value;
                    this.RaisePropertyChanged("Winner");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LMService.ILMService")]
    public interface ILMService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILMService/SendSetup", ReplyAction="http://tempuri.org/ILMService/SendSetupResponse")]
        int SendSetup(LeagueManager.WPF.LMService.SetupContract setup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILMService/SendSetup", ReplyAction="http://tempuri.org/ILMService/SendSetupResponse")]
        System.Threading.Tasks.Task<int> SendSetupAsync(LeagueManager.WPF.LMService.SetupContract setup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILMService/GetGameResult", ReplyAction="http://tempuri.org/ILMService/GetGameResultResponse")]
        LeagueManager.WPF.LMService.GameContract GetGameResult(int gameId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILMService/GetGameResult", ReplyAction="http://tempuri.org/ILMService/GetGameResultResponse")]
        System.Threading.Tasks.Task<LeagueManager.WPF.LMService.GameContract> GetGameResultAsync(int gameId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILMServiceChannel : LeagueManager.WPF.LMService.ILMService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LMServiceClient : System.ServiceModel.ClientBase<LeagueManager.WPF.LMService.ILMService>, LeagueManager.WPF.LMService.ILMService {
        
        public LMServiceClient() {
        }
        
        public LMServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LMServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LMServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LMServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int SendSetup(LeagueManager.WPF.LMService.SetupContract setup) {
            return base.Channel.SendSetup(setup);
        }
        
        public System.Threading.Tasks.Task<int> SendSetupAsync(LeagueManager.WPF.LMService.SetupContract setup) {
            return base.Channel.SendSetupAsync(setup);
        }
        
        public LeagueManager.WPF.LMService.GameContract GetGameResult(int gameId) {
            return base.Channel.GetGameResult(gameId);
        }
        
        public System.Threading.Tasks.Task<LeagueManager.WPF.LMService.GameContract> GetGameResultAsync(int gameId) {
            return base.Channel.GetGameResultAsync(gameId);
        }
    }
}
