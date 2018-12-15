﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.CompanyServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Company", Namespace="http://schemas.datacontract.org/2004/07/Service.Model")]
    [System.SerializableAttribute()]
    public partial class Company : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Client.CompanyServiceReference.CompanyType TypeField;
        
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
        public string CountryCode {
            get {
                return this.CountryCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryCodeField, value) != true)) {
                    this.CountryCodeField = value;
                    this.RaisePropertyChanged("CountryCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Client.CompanyServiceReference.CompanyType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompanyType", Namespace="http://schemas.datacontract.org/2004/07/Service.Model")]
    [System.SerializableAttribute()]
    public partial class CompanyType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CompanyServiceReference.ICompanyService")]
    public interface ICompanyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/GetAllCompanies", ReplyAction="http://tempuri.org/ICompanyService/GetAllCompaniesResponse")]
        Client.CompanyServiceReference.Company[] GetAllCompanies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/GetAllCompanies", ReplyAction="http://tempuri.org/ICompanyService/GetAllCompaniesResponse")]
        System.Threading.Tasks.Task<Client.CompanyServiceReference.Company[]> GetAllCompaniesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/GetCompany", ReplyAction="http://tempuri.org/ICompanyService/GetCompanyResponse")]
        Client.CompanyServiceReference.Company[] GetCompany(int Id, string companyName, string countryCode, string companyType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/GetCompany", ReplyAction="http://tempuri.org/ICompanyService/GetCompanyResponse")]
        System.Threading.Tasks.Task<Client.CompanyServiceReference.Company[]> GetCompanyAsync(int Id, string companyName, string countryCode, string companyType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/CreateCompany", ReplyAction="http://tempuri.org/ICompanyService/CreateCompanyResponse")]
        bool CreateCompany(Client.CompanyServiceReference.Company company);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/CreateCompany", ReplyAction="http://tempuri.org/ICompanyService/CreateCompanyResponse")]
        System.Threading.Tasks.Task<bool> CreateCompanyAsync(Client.CompanyServiceReference.Company company);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/GetAllCompanyTypes", ReplyAction="http://tempuri.org/ICompanyService/GetAllCompanyTypesResponse")]
        Client.CompanyServiceReference.CompanyType[] GetAllCompanyTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompanyService/GetAllCompanyTypes", ReplyAction="http://tempuri.org/ICompanyService/GetAllCompanyTypesResponse")]
        System.Threading.Tasks.Task<Client.CompanyServiceReference.CompanyType[]> GetAllCompanyTypesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompanyServiceChannel : Client.CompanyServiceReference.ICompanyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompanyServiceClient : System.ServiceModel.ClientBase<Client.CompanyServiceReference.ICompanyService>, Client.CompanyServiceReference.ICompanyService {
        
        public CompanyServiceClient() {
        }
        
        public CompanyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompanyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompanyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client.CompanyServiceReference.Company[] GetAllCompanies() {
            return base.Channel.GetAllCompanies();
        }
        
        public System.Threading.Tasks.Task<Client.CompanyServiceReference.Company[]> GetAllCompaniesAsync() {
            return base.Channel.GetAllCompaniesAsync();
        }
        
        public Client.CompanyServiceReference.Company[] GetCompany(int Id, string companyName, string countryCode, string companyType) {
            return base.Channel.GetCompany(Id, companyName, countryCode, companyType);
        }
        
        public System.Threading.Tasks.Task<Client.CompanyServiceReference.Company[]> GetCompanyAsync(int Id, string companyName, string countryCode, string companyType) {
            return base.Channel.GetCompanyAsync(Id, companyName, countryCode, companyType);
        }
        
        public bool CreateCompany(Client.CompanyServiceReference.Company company) {
            return base.Channel.CreateCompany(company);
        }
        
        public System.Threading.Tasks.Task<bool> CreateCompanyAsync(Client.CompanyServiceReference.Company company) {
            return base.Channel.CreateCompanyAsync(company);
        }
        
        public Client.CompanyServiceReference.CompanyType[] GetAllCompanyTypes() {
            return base.Channel.GetAllCompanyTypes();
        }
        
        public System.Threading.Tasks.Task<Client.CompanyServiceReference.CompanyType[]> GetAllCompanyTypesAsync() {
            return base.Channel.GetAllCompanyTypesAsync();
        }
    }
}
