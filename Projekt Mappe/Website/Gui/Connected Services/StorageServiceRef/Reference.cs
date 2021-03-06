﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gui.StorageServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Storage", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Storage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.StorageServiceRef.Customer CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.StorageServiceRef.SuperAlchohol DrinkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MinAmountField;
        
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
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Gui.StorageServiceRef.Customer Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Gui.StorageServiceRef.SuperAlchohol Drink {
            get {
                return this.DrinkField;
            }
            set {
                if ((object.ReferenceEquals(this.DrinkField, value) != true)) {
                    this.DrinkField = value;
                    this.RaisePropertyChanged("Drink");
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
        public int MaxAmount {
            get {
                return this.MaxAmountField;
            }
            set {
                if ((this.MaxAmountField.Equals(value) != true)) {
                    this.MaxAmountField = value;
                    this.RaisePropertyChanged("MaxAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MinAmount {
            get {
                return this.MinAmountField;
            }
            set {
                if ((this.MinAmountField.Equals(value) != true)) {
                    this.MinAmountField = value;
                    this.RaisePropertyChanged("MinAmount");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CusNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CusPasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegionField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CusName {
            get {
                return this.CusNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CusNameField, value) != true)) {
                    this.CusNameField = value;
                    this.RaisePropertyChanged("CusName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CusPassword {
            get {
                return this.CusPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.CusPasswordField, value) != true)) {
                    this.CusPasswordField = value;
                    this.RaisePropertyChanged("CusPassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
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
        public string Img {
            get {
                return this.ImgField;
            }
            set {
                if ((object.ReferenceEquals(this.ImgField, value) != true)) {
                    this.ImgField = value;
                    this.RaisePropertyChanged("Img");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Region {
            get {
                return this.RegionField;
            }
            set {
                if ((object.ReferenceEquals(this.RegionField, value) != true)) {
                    this.RegionField = value;
                    this.RaisePropertyChanged("Region");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SuperAlchohol", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Gui.StorageServiceRef.Drink))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Gui.StorageServiceRef.Alchohol))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Gui.StorageServiceRef.HelFlask))]
    public partial class SuperAlchohol : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
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
        public string Img {
            get {
                return this.ImgField;
            }
            set {
                if ((object.ReferenceEquals(this.ImgField, value) != true)) {
                    this.ImgField = value;
                    this.RaisePropertyChanged("Img");
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
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Drink", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Drink : Gui.StorageServiceRef.SuperAlchohol {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.StorageServiceRef.Ingredient[] IngredientsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Gui.StorageServiceRef.Ingredient[] Ingredients {
            get {
                return this.IngredientsField;
            }
            set {
                if ((object.ReferenceEquals(this.IngredientsField, value) != true)) {
                    this.IngredientsField = value;
                    this.RaisePropertyChanged("Ingredients");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alchohol", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Alchohol : Gui.StorageServiceRef.SuperAlchohol {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ProcentField;
        
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HelFlask", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class HelFlask : Gui.StorageServiceRef.SuperAlchohol {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ProcentField;
        
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
    }
    
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StorageServiceRef.IStorageService")]
    public interface IStorageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/CreateStorage", ReplyAction="http://tempuri.org/IStorageService/CreateStorageResponse")]
        void CreateStorage(Gui.StorageServiceRef.Storage storage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/CreateStorage", ReplyAction="http://tempuri.org/IStorageService/CreateStorageResponse")]
        System.Threading.Tasks.Task CreateStorageAsync(Gui.StorageServiceRef.Storage storage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/GetStorage", ReplyAction="http://tempuri.org/IStorageService/GetStorageResponse")]
        Gui.StorageServiceRef.Storage GetStorage(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/GetStorage", ReplyAction="http://tempuri.org/IStorageService/GetStorageResponse")]
        System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage> GetStorageAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/GetDrinkStorage", ReplyAction="http://tempuri.org/IStorageService/GetDrinkStorageResponse")]
        Gui.StorageServiceRef.Storage GetDrinkStorage(int cusID, int drinkID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/GetDrinkStorage", ReplyAction="http://tempuri.org/IStorageService/GetDrinkStorageResponse")]
        System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage> GetDrinkStorageAsync(int cusID, int drinkID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/UpdateStorageDrink", ReplyAction="http://tempuri.org/IStorageService/UpdateStorageDrinkResponse")]
        void UpdateStorageDrink(int orderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/UpdateStorageDrink", ReplyAction="http://tempuri.org/IStorageService/UpdateStorageDrinkResponse")]
        System.Threading.Tasks.Task UpdateStorageDrinkAsync(int orderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/GetAllStorages", ReplyAction="http://tempuri.org/IStorageService/GetAllStoragesResponse")]
        Gui.StorageServiceRef.Storage[] GetAllStorages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/GetAllStorages", ReplyAction="http://tempuri.org/IStorageService/GetAllStoragesResponse")]
        System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage[]> GetAllStoragesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/getStorageByDrinkAndStorage", ReplyAction="http://tempuri.org/IStorageService/getStorageByDrinkAndStorageResponse")]
        Gui.StorageServiceRef.Storage getStorageByDrinkAndStorage(int drinkID, int cusID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/getStorageByDrinkAndStorage", ReplyAction="http://tempuri.org/IStorageService/getStorageByDrinkAndStorageResponse")]
        System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage> getStorageByDrinkAndStorageAsync(int drinkID, int cusID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/getAlchoholStorageByDrinkAndStorage", ReplyAction="http://tempuri.org/IStorageService/getAlchoholStorageByDrinkAndStorageResponse")]
        Gui.StorageServiceRef.Storage getAlchoholStorageByDrinkAndStorage(int alchID, int cusID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/getAlchoholStorageByDrinkAndStorage", ReplyAction="http://tempuri.org/IStorageService/getAlchoholStorageByDrinkAndStorageResponse")]
        System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage> getAlchoholStorageByDrinkAndStorageAsync(int alchID, int cusID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/getHelflaskStorageByHelflaskAndStorage", ReplyAction="http://tempuri.org/IStorageService/getHelflaskStorageByHelflaskAndStorageResponse" +
            "")]
        Gui.StorageServiceRef.Storage getHelflaskStorageByHelflaskAndStorage(int flaskID, int cusID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/getHelflaskStorageByHelflaskAndStorage", ReplyAction="http://tempuri.org/IStorageService/getHelflaskStorageByHelflaskAndStorageResponse" +
            "")]
        System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage> getHelflaskStorageByHelflaskAndStorageAsync(int flaskID, int cusID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/GetAllDrinkStorage", ReplyAction="http://tempuri.org/IStorageService/GetAllDrinkStorageResponse")]
        Gui.StorageServiceRef.Storage[] GetAllDrinkStorage(int cusID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/GetAllDrinkStorage", ReplyAction="http://tempuri.org/IStorageService/GetAllDrinkStorageResponse")]
        System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage[]> GetAllDrinkStorageAsync(int cusID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/GetAllAlchoholStorage", ReplyAction="http://tempuri.org/IStorageService/GetAllAlchoholStorageResponse")]
        Gui.StorageServiceRef.Storage[] GetAllAlchoholStorage(int cusID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/GetAllAlchoholStorage", ReplyAction="http://tempuri.org/IStorageService/GetAllAlchoholStorageResponse")]
        System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage[]> GetAllAlchoholStorageAsync(int cusID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/GetAllHelflaskStorage", ReplyAction="http://tempuri.org/IStorageService/GetAllHelflaskStorageResponse")]
        Gui.StorageServiceRef.Storage[] GetAllHelflaskStorage(int cusID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/GetAllHelflaskStorage", ReplyAction="http://tempuri.org/IStorageService/GetAllHelflaskStorageResponse")]
        System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage[]> GetAllHelflaskStorageAsync(int cusID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/UpdateStorages", ReplyAction="http://tempuri.org/IStorageService/UpdateStoragesResponse")]
        void UpdateStorages(Gui.StorageServiceRef.Storage storage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/UpdateStorages", ReplyAction="http://tempuri.org/IStorageService/UpdateStoragesResponse")]
        System.Threading.Tasks.Task UpdateStoragesAsync(Gui.StorageServiceRef.Storage storage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/CompleteOrder", ReplyAction="http://tempuri.org/IStorageService/CompleteOrderResponse")]
        bool CompleteOrder(int orderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStorageService/CompleteOrder", ReplyAction="http://tempuri.org/IStorageService/CompleteOrderResponse")]
        System.Threading.Tasks.Task<bool> CompleteOrderAsync(int orderID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStorageServiceChannel : Gui.StorageServiceRef.IStorageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StorageServiceClient : System.ServiceModel.ClientBase<Gui.StorageServiceRef.IStorageService>, Gui.StorageServiceRef.IStorageService {
        
        public StorageServiceClient() {
        }
        
        public StorageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StorageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StorageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StorageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CreateStorage(Gui.StorageServiceRef.Storage storage) {
            base.Channel.CreateStorage(storage);
        }
        
        public System.Threading.Tasks.Task CreateStorageAsync(Gui.StorageServiceRef.Storage storage) {
            return base.Channel.CreateStorageAsync(storage);
        }
        
        public Gui.StorageServiceRef.Storage GetStorage(int id) {
            return base.Channel.GetStorage(id);
        }
        
        public System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage> GetStorageAsync(int id) {
            return base.Channel.GetStorageAsync(id);
        }
        
        public Gui.StorageServiceRef.Storage GetDrinkStorage(int cusID, int drinkID) {
            return base.Channel.GetDrinkStorage(cusID, drinkID);
        }
        
        public System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage> GetDrinkStorageAsync(int cusID, int drinkID) {
            return base.Channel.GetDrinkStorageAsync(cusID, drinkID);
        }
        
        public void UpdateStorageDrink(int orderID) {
            base.Channel.UpdateStorageDrink(orderID);
        }
        
        public System.Threading.Tasks.Task UpdateStorageDrinkAsync(int orderID) {
            return base.Channel.UpdateStorageDrinkAsync(orderID);
        }
        
        public Gui.StorageServiceRef.Storage[] GetAllStorages() {
            return base.Channel.GetAllStorages();
        }
        
        public System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage[]> GetAllStoragesAsync() {
            return base.Channel.GetAllStoragesAsync();
        }
        
        public Gui.StorageServiceRef.Storage getStorageByDrinkAndStorage(int drinkID, int cusID) {
            return base.Channel.getStorageByDrinkAndStorage(drinkID, cusID);
        }
        
        public System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage> getStorageByDrinkAndStorageAsync(int drinkID, int cusID) {
            return base.Channel.getStorageByDrinkAndStorageAsync(drinkID, cusID);
        }
        
        public Gui.StorageServiceRef.Storage getAlchoholStorageByDrinkAndStorage(int alchID, int cusID) {
            return base.Channel.getAlchoholStorageByDrinkAndStorage(alchID, cusID);
        }
        
        public System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage> getAlchoholStorageByDrinkAndStorageAsync(int alchID, int cusID) {
            return base.Channel.getAlchoholStorageByDrinkAndStorageAsync(alchID, cusID);
        }
        
        public Gui.StorageServiceRef.Storage getHelflaskStorageByHelflaskAndStorage(int flaskID, int cusID) {
            return base.Channel.getHelflaskStorageByHelflaskAndStorage(flaskID, cusID);
        }
        
        public System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage> getHelflaskStorageByHelflaskAndStorageAsync(int flaskID, int cusID) {
            return base.Channel.getHelflaskStorageByHelflaskAndStorageAsync(flaskID, cusID);
        }
        
        public Gui.StorageServiceRef.Storage[] GetAllDrinkStorage(int cusID) {
            return base.Channel.GetAllDrinkStorage(cusID);
        }
        
        public System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage[]> GetAllDrinkStorageAsync(int cusID) {
            return base.Channel.GetAllDrinkStorageAsync(cusID);
        }
        
        public Gui.StorageServiceRef.Storage[] GetAllAlchoholStorage(int cusID) {
            return base.Channel.GetAllAlchoholStorage(cusID);
        }
        
        public System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage[]> GetAllAlchoholStorageAsync(int cusID) {
            return base.Channel.GetAllAlchoholStorageAsync(cusID);
        }
        
        public Gui.StorageServiceRef.Storage[] GetAllHelflaskStorage(int cusID) {
            return base.Channel.GetAllHelflaskStorage(cusID);
        }
        
        public System.Threading.Tasks.Task<Gui.StorageServiceRef.Storage[]> GetAllHelflaskStorageAsync(int cusID) {
            return base.Channel.GetAllHelflaskStorageAsync(cusID);
        }
        
        public void UpdateStorages(Gui.StorageServiceRef.Storage storage) {
            base.Channel.UpdateStorages(storage);
        }
        
        public System.Threading.Tasks.Task UpdateStoragesAsync(Gui.StorageServiceRef.Storage storage) {
            return base.Channel.UpdateStoragesAsync(storage);
        }
        
        public bool CompleteOrder(int orderID) {
            return base.Channel.CompleteOrder(orderID);
        }
        
        public System.Threading.Tasks.Task<bool> CompleteOrderAsync(int orderID) {
            return base.Channel.CompleteOrderAsync(orderID);
        }
    }
}
