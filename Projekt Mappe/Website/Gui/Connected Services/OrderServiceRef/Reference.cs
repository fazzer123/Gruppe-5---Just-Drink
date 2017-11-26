﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gui.OrderServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.OrderServiceRef.Customer CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal DiscountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.OrderServiceRef.OrderLine[] OrderLinesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TotalPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.OrderServiceRef.User UserField;
        
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
        public Gui.OrderServiceRef.Customer Customer {
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Discount {
            get {
                return this.DiscountField;
            }
            set {
                if ((this.DiscountField.Equals(value) != true)) {
                    this.DiscountField = value;
                    this.RaisePropertyChanged("Discount");
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
        public Gui.OrderServiceRef.OrderLine[] OrderLines {
            get {
                return this.OrderLinesField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderLinesField, value) != true)) {
                    this.OrderLinesField = value;
                    this.RaisePropertyChanged("OrderLines");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TotalPrice {
            get {
                return this.TotalPriceField;
            }
            set {
                if ((this.TotalPriceField.Equals(value) != true)) {
                    this.TotalPriceField = value;
                    this.RaisePropertyChanged("TotalPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Gui.OrderServiceRef.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthdayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public System.DateTime Birthday {
            get {
                return this.BirthdayField;
            }
            set {
                if ((this.BirthdayField.Equals(value) != true)) {
                    this.BirthdayField = value;
                    this.RaisePropertyChanged("Birthday");
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
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
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderLine", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class OrderLine : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.OrderServiceRef.Drink DrinkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TotalPriceField;
        
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
        public Gui.OrderServiceRef.Drink Drink {
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
        public decimal TotalPrice {
            get {
                return this.TotalPriceField;
            }
            set {
                if ((this.TotalPriceField.Equals(value) != true)) {
                    this.TotalPriceField = value;
                    this.RaisePropertyChanged("TotalPrice");
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
    public partial class Drink : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Gui.OrderServiceRef.Ingredient[] IngredientsField;
        
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
        public Gui.OrderServiceRef.Ingredient[] Ingredients {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderServiceRef.IOrderService")]
    public interface IOrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/CreateOrder", ReplyAction="http://tempuri.org/IOrderService/CreateOrderResponse")]
        void CreateOrder(Gui.OrderServiceRef.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/CreateOrder", ReplyAction="http://tempuri.org/IOrderService/CreateOrderResponse")]
        System.Threading.Tasks.Task CreateOrderAsync(Gui.OrderServiceRef.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetOrder", ReplyAction="http://tempuri.org/IOrderService/GetOrderResponse")]
        Gui.OrderServiceRef.Order GetOrder(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetOrder", ReplyAction="http://tempuri.org/IOrderService/GetOrderResponse")]
        System.Threading.Tasks.Task<Gui.OrderServiceRef.Order> GetOrderAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetAllOrders", ReplyAction="http://tempuri.org/IOrderService/GetAllOrdersResponse")]
        Gui.OrderServiceRef.Order[] GetAllOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetAllOrders", ReplyAction="http://tempuri.org/IOrderService/GetAllOrdersResponse")]
        System.Threading.Tasks.Task<Gui.OrderServiceRef.Order[]> GetAllOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/CompleteOrder", ReplyAction="http://tempuri.org/IOrderService/CompleteOrderResponse")]
        void CompleteOrder(Gui.OrderServiceRef.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/CompleteOrder", ReplyAction="http://tempuri.org/IOrderService/CompleteOrderResponse")]
        System.Threading.Tasks.Task CompleteOrderAsync(Gui.OrderServiceRef.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetOrderByStatus", ReplyAction="http://tempuri.org/IOrderService/GetOrderByStatusResponse")]
        Gui.OrderServiceRef.Order GetOrderByStatus(string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetOrderByStatus", ReplyAction="http://tempuri.org/IOrderService/GetOrderByStatusResponse")]
        System.Threading.Tasks.Task<Gui.OrderServiceRef.Order> GetOrderByStatusAsync(string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetUser", ReplyAction="http://tempuri.org/IOrderService/GetUserResponse")]
        Gui.OrderServiceRef.User GetUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetUser", ReplyAction="http://tempuri.org/IOrderService/GetUserResponse")]
        System.Threading.Tasks.Task<Gui.OrderServiceRef.User> GetUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetCustomer", ReplyAction="http://tempuri.org/IOrderService/GetCustomerResponse")]
        Gui.OrderServiceRef.Customer GetCustomer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetCustomer", ReplyAction="http://tempuri.org/IOrderService/GetCustomerResponse")]
        System.Threading.Tasks.Task<Gui.OrderServiceRef.Customer> GetCustomerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/DeleteOrderByID", ReplyAction="http://tempuri.org/IOrderService/DeleteOrderByIDResponse")]
        void DeleteOrderByID(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/DeleteOrderByID", ReplyAction="http://tempuri.org/IOrderService/DeleteOrderByIDResponse")]
        System.Threading.Tasks.Task DeleteOrderByIDAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/UpdatePrice", ReplyAction="http://tempuri.org/IOrderService/UpdatePriceResponse")]
        void UpdatePrice(Gui.OrderServiceRef.Order order, decimal price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/UpdatePrice", ReplyAction="http://tempuri.org/IOrderService/UpdatePriceResponse")]
        System.Threading.Tasks.Task UpdatePriceAsync(Gui.OrderServiceRef.Order order, decimal price);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderServiceChannel : Gui.OrderServiceRef.IOrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceClient : System.ServiceModel.ClientBase<Gui.OrderServiceRef.IOrderService>, Gui.OrderServiceRef.IOrderService {
        
        public OrderServiceClient() {
        }
        
        public OrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CreateOrder(Gui.OrderServiceRef.Order order) {
            base.Channel.CreateOrder(order);
        }
        
        public System.Threading.Tasks.Task CreateOrderAsync(Gui.OrderServiceRef.Order order) {
            return base.Channel.CreateOrderAsync(order);
        }
        
        public Gui.OrderServiceRef.Order GetOrder(int ID) {
            return base.Channel.GetOrder(ID);
        }
        
        public System.Threading.Tasks.Task<Gui.OrderServiceRef.Order> GetOrderAsync(int ID) {
            return base.Channel.GetOrderAsync(ID);
        }
        
        public Gui.OrderServiceRef.Order[] GetAllOrders() {
            return base.Channel.GetAllOrders();
        }
        
        public System.Threading.Tasks.Task<Gui.OrderServiceRef.Order[]> GetAllOrdersAsync() {
            return base.Channel.GetAllOrdersAsync();
        }
        
        public void CompleteOrder(Gui.OrderServiceRef.Order order) {
            base.Channel.CompleteOrder(order);
        }
        
        public System.Threading.Tasks.Task CompleteOrderAsync(Gui.OrderServiceRef.Order order) {
            return base.Channel.CompleteOrderAsync(order);
        }
        
        public Gui.OrderServiceRef.Order GetOrderByStatus(string status) {
            return base.Channel.GetOrderByStatus(status);
        }
        
        public System.Threading.Tasks.Task<Gui.OrderServiceRef.Order> GetOrderByStatusAsync(string status) {
            return base.Channel.GetOrderByStatusAsync(status);
        }
        
        public Gui.OrderServiceRef.User GetUser(int id) {
            return base.Channel.GetUser(id);
        }
        
        public System.Threading.Tasks.Task<Gui.OrderServiceRef.User> GetUserAsync(int id) {
            return base.Channel.GetUserAsync(id);
        }
        
        public Gui.OrderServiceRef.Customer GetCustomer(int id) {
            return base.Channel.GetCustomer(id);
        }
        
        public System.Threading.Tasks.Task<Gui.OrderServiceRef.Customer> GetCustomerAsync(int id) {
            return base.Channel.GetCustomerAsync(id);
        }
        
        public void DeleteOrderByID(int ID) {
            base.Channel.DeleteOrderByID(ID);
        }
        
        public System.Threading.Tasks.Task DeleteOrderByIDAsync(int ID) {
            return base.Channel.DeleteOrderByIDAsync(ID);
        }
        
        public void UpdatePrice(Gui.OrderServiceRef.Order order, decimal price) {
            base.Channel.UpdatePrice(order, price);
        }
        
        public System.Threading.Tasks.Task UpdatePriceAsync(Gui.OrderServiceRef.Order order, decimal price) {
            return base.Channel.UpdatePriceAsync(order, price);
        }
    }
}
