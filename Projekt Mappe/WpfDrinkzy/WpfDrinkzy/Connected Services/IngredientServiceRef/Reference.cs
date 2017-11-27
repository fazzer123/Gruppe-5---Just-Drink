﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfDrinkzy.IngredientServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ingredient", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Ingredient : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ProcentField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Procent {
            get {
                return this.ProcentField;
            }
            set {
                if ((this.ProcentField.Equals(value) != true)) {
                    this.ProcentField = value;
                    this.RaisePropertyChanged("Procent");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IngredientServiceRef.IIngredientService")]
    public interface IIngredientService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/createIngredient", ReplyAction="http://tempuri.org/IIngredientService/createIngredientResponse")]
        void createIngredient(WpfDrinkzy.IngredientServiceRef.Ingredient i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/createIngredient", ReplyAction="http://tempuri.org/IIngredientService/createIngredientResponse")]
        System.Threading.Tasks.Task createIngredientAsync(WpfDrinkzy.IngredientServiceRef.Ingredient i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/GetIngredient", ReplyAction="http://tempuri.org/IIngredientService/GetIngredientResponse")]
        WpfDrinkzy.IngredientServiceRef.Ingredient GetIngredient(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/GetIngredient", ReplyAction="http://tempuri.org/IIngredientService/GetIngredientResponse")]
        System.Threading.Tasks.Task<WpfDrinkzy.IngredientServiceRef.Ingredient> GetIngredientAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/getAllIngredients", ReplyAction="http://tempuri.org/IIngredientService/getAllIngredientsResponse")]
        WpfDrinkzy.IngredientServiceRef.Ingredient[] getAllIngredients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/getAllIngredients", ReplyAction="http://tempuri.org/IIngredientService/getAllIngredientsResponse")]
        System.Threading.Tasks.Task<WpfDrinkzy.IngredientServiceRef.Ingredient[]> getAllIngredientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/SearchIngedient", ReplyAction="http://tempuri.org/IIngredientService/SearchIngedientResponse")]
        WpfDrinkzy.IngredientServiceRef.Ingredient[] SearchIngedient(string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/SearchIngedient", ReplyAction="http://tempuri.org/IIngredientService/SearchIngedientResponse")]
        System.Threading.Tasks.Task<WpfDrinkzy.IngredientServiceRef.Ingredient[]> SearchIngedientAsync(string search);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/DeleteIngredient", ReplyAction="http://tempuri.org/IIngredientService/DeleteIngredientResponse")]
        void DeleteIngredient(int IngID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/DeleteIngredient", ReplyAction="http://tempuri.org/IIngredientService/DeleteIngredientResponse")]
        System.Threading.Tasks.Task DeleteIngredientAsync(int IngID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/UpdateIngredient", ReplyAction="http://tempuri.org/IIngredientService/UpdateIngredientResponse")]
        void UpdateIngredient(WpfDrinkzy.IngredientServiceRef.Ingredient ingredient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IIngredientService/UpdateIngredient", ReplyAction="http://tempuri.org/IIngredientService/UpdateIngredientResponse")]
        System.Threading.Tasks.Task UpdateIngredientAsync(WpfDrinkzy.IngredientServiceRef.Ingredient ingredient);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IIngredientServiceChannel : WpfDrinkzy.IngredientServiceRef.IIngredientService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IngredientServiceClient : System.ServiceModel.ClientBase<WpfDrinkzy.IngredientServiceRef.IIngredientService>, WpfDrinkzy.IngredientServiceRef.IIngredientService {
        
        public IngredientServiceClient() {
        }
        
        public IngredientServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IngredientServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IngredientServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IngredientServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void createIngredient(WpfDrinkzy.IngredientServiceRef.Ingredient i) {
            base.Channel.createIngredient(i);
        }
        
        public System.Threading.Tasks.Task createIngredientAsync(WpfDrinkzy.IngredientServiceRef.Ingredient i) {
            return base.Channel.createIngredientAsync(i);
        }
        
        public WpfDrinkzy.IngredientServiceRef.Ingredient GetIngredient(int id) {
            return base.Channel.GetIngredient(id);
        }
        
        public System.Threading.Tasks.Task<WpfDrinkzy.IngredientServiceRef.Ingredient> GetIngredientAsync(int id) {
            return base.Channel.GetIngredientAsync(id);
        }
        
        public WpfDrinkzy.IngredientServiceRef.Ingredient[] getAllIngredients() {
            return base.Channel.getAllIngredients();
        }
        
        public System.Threading.Tasks.Task<WpfDrinkzy.IngredientServiceRef.Ingredient[]> getAllIngredientsAsync() {
            return base.Channel.getAllIngredientsAsync();
        }
        
        public WpfDrinkzy.IngredientServiceRef.Ingredient[] SearchIngedient(string search) {
            return base.Channel.SearchIngedient(search);
        }
        
        public System.Threading.Tasks.Task<WpfDrinkzy.IngredientServiceRef.Ingredient[]> SearchIngedientAsync(string search) {
            return base.Channel.SearchIngedientAsync(search);
        }
        
        public void DeleteIngredient(int IngID) {
            base.Channel.DeleteIngredient(IngID);
        }
        
        public System.Threading.Tasks.Task DeleteIngredientAsync(int IngID) {
            return base.Channel.DeleteIngredientAsync(IngID);
        }
        
        public void UpdateIngredient(WpfDrinkzy.IngredientServiceRef.Ingredient ingredient) {
            base.Channel.UpdateIngredient(ingredient);
        }
        
        public System.Threading.Tasks.Task UpdateIngredientAsync(WpfDrinkzy.IngredientServiceRef.Ingredient ingredient) {
            return base.Channel.UpdateIngredientAsync(ingredient);
        }
    }
}
