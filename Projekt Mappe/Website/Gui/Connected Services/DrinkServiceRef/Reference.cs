﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gui.DrinkServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Drink", Namespace="http://schemas.datacontract.org/2004/07/Modellayer")]
    [System.SerializableAttribute()]
    public partial class Drink : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.DrinkServiceRef.Favourite[] FavouritesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.DrinkServiceRef.Ingredients[] IngredientsesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.DrinkServiceRef.Menucard[] MenucardsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
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
        public Gui.DrinkServiceRef.Favourite[] Favourites {
            get {
                return this.FavouritesField;
            }
            set {
                if ((object.ReferenceEquals(this.FavouritesField, value) != true)) {
                    this.FavouritesField = value;
                    this.RaisePropertyChanged("Favourites");
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
        public Gui.DrinkServiceRef.Ingredients[] Ingredientses {
            get {
                return this.IngredientsesField;
            }
            set {
                if ((object.ReferenceEquals(this.IngredientsesField, value) != true)) {
                    this.IngredientsesField = value;
                    this.RaisePropertyChanged("Ingredientses");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Gui.DrinkServiceRef.Menucard[] Menucards {
            get {
                return this.MenucardsField;
            }
            set {
                if ((object.ReferenceEquals(this.MenucardsField, value) != true)) {
                    this.MenucardsField = value;
                    this.RaisePropertyChanged("Menucards");
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
        public double Price {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Favourite", Namespace="http://schemas.datacontract.org/2004/07/Modellayer")]
    [System.SerializableAttribute()]
    public partial class Favourite : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.DrinkServiceRef.Drink[] DrinksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
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
        public Gui.DrinkServiceRef.Drink[] Drinks {
            get {
                return this.DrinksField;
            }
            set {
                if ((object.ReferenceEquals(this.DrinksField, value) != true)) {
                    this.DrinksField = value;
                    this.RaisePropertyChanged("Drinks");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ingredients", Namespace="http://schemas.datacontract.org/2004/07/Modellayer")]
    [System.SerializableAttribute()]
    public partial class Ingredients : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.DrinkServiceRef.Drink[] DrinksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ProcentField;
        
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
        public Gui.DrinkServiceRef.Drink[] Drinks {
            get {
                return this.DrinksField;
            }
            set {
                if ((object.ReferenceEquals(this.DrinksField, value) != true)) {
                    this.DrinksField = value;
                    this.RaisePropertyChanged("Drinks");
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
        public double Procent {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Menucard", Namespace="http://schemas.datacontract.org/2004/07/Modellayer")]
    [System.SerializableAttribute()]
    public partial class Menucard : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.DrinkServiceRef.Drink[] DrinksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
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
        public Gui.DrinkServiceRef.Drink[] Drinks {
            get {
                return this.DrinksField;
            }
            set {
                if ((object.ReferenceEquals(this.DrinksField, value) != true)) {
                    this.DrinksField = value;
                    this.RaisePropertyChanged("Drinks");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DrinkServiceRef.IServiceDrink")]
    public interface IServiceDrink {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDrink/GetDrink", ReplyAction="http://tempuri.org/IServiceDrink/GetDrinkResponse")]
        Gui.DrinkServiceRef.Drink[] GetDrink(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDrink/GetDrink", ReplyAction="http://tempuri.org/IServiceDrink/GetDrinkResponse")]
        System.Threading.Tasks.Task<Gui.DrinkServiceRef.Drink[]> GetDrinkAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDrink/GetDrinkList", ReplyAction="http://tempuri.org/IServiceDrink/GetDrinkListResponse")]
        Gui.DrinkServiceRef.Drink[] GetDrinkList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDrink/GetDrinkList", ReplyAction="http://tempuri.org/IServiceDrink/GetDrinkListResponse")]
        System.Threading.Tasks.Task<Gui.DrinkServiceRef.Drink[]> GetDrinkListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDrink/CreateDrink", ReplyAction="http://tempuri.org/IServiceDrink/CreateDrinkResponse")]
        void CreateDrink(Gui.DrinkServiceRef.Drink Drink);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDrink/CreateDrink", ReplyAction="http://tempuri.org/IServiceDrink/CreateDrinkResponse")]
        System.Threading.Tasks.Task CreateDrinkAsync(Gui.DrinkServiceRef.Drink Drink);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDrink/DeleteDrink", ReplyAction="http://tempuri.org/IServiceDrink/DeleteDrinkResponse")]
        void DeleteDrink(Gui.DrinkServiceRef.Drink Drink);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDrink/DeleteDrink", ReplyAction="http://tempuri.org/IServiceDrink/DeleteDrinkResponse")]
        System.Threading.Tasks.Task DeleteDrinkAsync(Gui.DrinkServiceRef.Drink Drink);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceDrinkChannel : Gui.DrinkServiceRef.IServiceDrink, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceDrinkClient : System.ServiceModel.ClientBase<Gui.DrinkServiceRef.IServiceDrink>, Gui.DrinkServiceRef.IServiceDrink {
        
        public ServiceDrinkClient() {
        }
        
        public ServiceDrinkClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceDrinkClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDrinkClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDrinkClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Gui.DrinkServiceRef.Drink[] GetDrink(string name) {
            return base.Channel.GetDrink(name);
        }
        
        public System.Threading.Tasks.Task<Gui.DrinkServiceRef.Drink[]> GetDrinkAsync(string name) {
            return base.Channel.GetDrinkAsync(name);
        }
        
        public Gui.DrinkServiceRef.Drink[] GetDrinkList() {
            return base.Channel.GetDrinkList();
        }
        
        public System.Threading.Tasks.Task<Gui.DrinkServiceRef.Drink[]> GetDrinkListAsync() {
            return base.Channel.GetDrinkListAsync();
        }
        
        public void CreateDrink(Gui.DrinkServiceRef.Drink Drink) {
            base.Channel.CreateDrink(Drink);
        }
        
        public System.Threading.Tasks.Task CreateDrinkAsync(Gui.DrinkServiceRef.Drink Drink) {
            return base.Channel.CreateDrinkAsync(Drink);
        }
        
        public void DeleteDrink(Gui.DrinkServiceRef.Drink Drink) {
            base.Channel.DeleteDrink(Drink);
        }
        
        public System.Threading.Tasks.Task DeleteDrinkAsync(Gui.DrinkServiceRef.Drink Drink) {
            return base.Channel.DeleteDrinkAsync(Drink);
        }
    }
}
