﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17379
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AskBargainsServices.Client.DataService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataItem", Namespace="http://schemas.datacontract.org/2004/07/AskBargains.DataEF.Models")]
    [System.SerializableAttribute()]
    public partial class DataItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AskBargainsServices.Client.DataService.Comment[] CommentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ConditionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CouponCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long DataItemIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ExpireDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ForwardLinkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImgPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MetaDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MetaKeywordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginalPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OthersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PromotionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime PublishDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RebateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SKUField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SaveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShippingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShowCouponsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TodayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserRatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WarrantyField;
        
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
        public string BrandName {
            get {
                return this.BrandNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandNameField, value) != true)) {
                    this.BrandNameField = value;
                    this.RaisePropertyChanged("BrandName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AskBargainsServices.Client.DataService.Comment[] Comments {
            get {
                return this.CommentsField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentsField, value) != true)) {
                    this.CommentsField = value;
                    this.RaisePropertyChanged("Comments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Condition {
            get {
                return this.ConditionField;
            }
            set {
                if ((object.ReferenceEquals(this.ConditionField, value) != true)) {
                    this.ConditionField = value;
                    this.RaisePropertyChanged("Condition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CouponCode {
            get {
                return this.CouponCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CouponCodeField, value) != true)) {
                    this.CouponCodeField = value;
                    this.RaisePropertyChanged("CouponCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long DataItemId {
            get {
                return this.DataItemIdField;
            }
            set {
                if ((this.DataItemIdField.Equals(value) != true)) {
                    this.DataItemIdField = value;
                    this.RaisePropertyChanged("DataItemId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ExpireDate {
            get {
                return this.ExpireDateField;
            }
            set {
                if ((this.ExpireDateField.Equals(value) != true)) {
                    this.ExpireDateField = value;
                    this.RaisePropertyChanged("ExpireDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ForwardLink {
            get {
                return this.ForwardLinkField;
            }
            set {
                if ((object.ReferenceEquals(this.ForwardLinkField, value) != true)) {
                    this.ForwardLinkField = value;
                    this.RaisePropertyChanged("ForwardLink");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ImgPath {
            get {
                return this.ImgPathField;
            }
            set {
                if ((object.ReferenceEquals(this.ImgPathField, value) != true)) {
                    this.ImgPathField = value;
                    this.RaisePropertyChanged("ImgPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemCategory {
            get {
                return this.ItemCategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemCategoryField, value) != true)) {
                    this.ItemCategoryField = value;
                    this.RaisePropertyChanged("ItemCategory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemDescription {
            get {
                return this.ItemDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemDescriptionField, value) != true)) {
                    this.ItemDescriptionField = value;
                    this.RaisePropertyChanged("ItemDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemName {
            get {
                return this.ItemNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemNameField, value) != true)) {
                    this.ItemNameField = value;
                    this.RaisePropertyChanged("ItemName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemPrice {
            get {
                return this.ItemPriceField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemPriceField, value) != true)) {
                    this.ItemPriceField = value;
                    this.RaisePropertyChanged("ItemPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MetaDescription {
            get {
                return this.MetaDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.MetaDescriptionField, value) != true)) {
                    this.MetaDescriptionField = value;
                    this.RaisePropertyChanged("MetaDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MetaKeyword {
            get {
                return this.MetaKeywordField;
            }
            set {
                if ((object.ReferenceEquals(this.MetaKeywordField, value) != true)) {
                    this.MetaKeywordField = value;
                    this.RaisePropertyChanged("MetaKeyword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OriginalPrice {
            get {
                return this.OriginalPriceField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginalPriceField, value) != true)) {
                    this.OriginalPriceField = value;
                    this.RaisePropertyChanged("OriginalPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Others {
            get {
                return this.OthersField;
            }
            set {
                if ((object.ReferenceEquals(this.OthersField, value) != true)) {
                    this.OthersField = value;
                    this.RaisePropertyChanged("Others");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Promotion {
            get {
                return this.PromotionField;
            }
            set {
                if ((object.ReferenceEquals(this.PromotionField, value) != true)) {
                    this.PromotionField = value;
                    this.RaisePropertyChanged("Promotion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PublishDate {
            get {
                return this.PublishDateField;
            }
            set {
                if ((this.PublishDateField.Equals(value) != true)) {
                    this.PublishDateField = value;
                    this.RaisePropertyChanged("PublishDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Rebate {
            get {
                return this.RebateField;
            }
            set {
                if ((object.ReferenceEquals(this.RebateField, value) != true)) {
                    this.RebateField = value;
                    this.RaisePropertyChanged("Rebate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SKU {
            get {
                return this.SKUField;
            }
            set {
                if ((object.ReferenceEquals(this.SKUField, value) != true)) {
                    this.SKUField = value;
                    this.RaisePropertyChanged("SKU");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Save {
            get {
                return this.SaveField;
            }
            set {
                if ((object.ReferenceEquals(this.SaveField, value) != true)) {
                    this.SaveField = value;
                    this.RaisePropertyChanged("Save");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Shipping {
            get {
                return this.ShippingField;
            }
            set {
                if ((object.ReferenceEquals(this.ShippingField, value) != true)) {
                    this.ShippingField = value;
                    this.RaisePropertyChanged("Shipping");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShowCoupons {
            get {
                return this.ShowCouponsField;
            }
            set {
                if ((object.ReferenceEquals(this.ShowCouponsField, value) != true)) {
                    this.ShowCouponsField = value;
                    this.RaisePropertyChanged("ShowCoupons");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubCategory {
            get {
                return this.SubCategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.SubCategoryField, value) != true)) {
                    this.SubCategoryField = value;
                    this.RaisePropertyChanged("SubCategory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Today {
            get {
                return this.TodayField;
            }
            set {
                if ((object.ReferenceEquals(this.TodayField, value) != true)) {
                    this.TodayField = value;
                    this.RaisePropertyChanged("Today");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserRated {
            get {
                return this.UserRatedField;
            }
            set {
                if ((object.ReferenceEquals(this.UserRatedField, value) != true)) {
                    this.UserRatedField = value;
                    this.RaisePropertyChanged("UserRated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Warranty {
            get {
                return this.WarrantyField;
            }
            set {
                if ((object.ReferenceEquals(this.WarrantyField, value) != true)) {
                    this.WarrantyField = value;
                    this.RaisePropertyChanged("Warranty");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Comment", Namespace="http://schemas.datacontract.org/2004/07/AskBargains.DataEF.Models")]
    [System.SerializableAttribute()]
    public partial class Comment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime AddedOnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CommentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long DataItemIdField;
        
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
        public System.DateTime AddedOn {
            get {
                return this.AddedOnField;
            }
            set {
                if ((this.AddedOnField.Equals(value) != true)) {
                    this.AddedOnField = value;
                    this.RaisePropertyChanged("AddedOn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CommentId {
            get {
                return this.CommentIdField;
            }
            set {
                if ((this.CommentIdField.Equals(value) != true)) {
                    this.CommentIdField = value;
                    this.RaisePropertyChanged("CommentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CommentText {
            get {
                return this.CommentTextField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentTextField, value) != true)) {
                    this.CommentTextField = value;
                    this.RaisePropertyChanged("CommentText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Commentator {
            get {
                return this.CommentatorField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentatorField, value) != true)) {
                    this.CommentatorField = value;
                    this.RaisePropertyChanged("Commentator");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long DataItemId {
            get {
                return this.DataItemIdField;
            }
            set {
                if ((this.DataItemIdField.Equals(value) != true)) {
                    this.DataItemIdField = value;
                    this.RaisePropertyChanged("DataItemId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataService.IDataService")]
    public interface IDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetAllDataItems", ReplyAction="http://tempuri.org/IDataService/GetAllDataItemsResponse")]
        AskBargainsServices.Client.DataService.DataItem[] GetAllDataItems(int topNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/GetDataItemById", ReplyAction="http://tempuri.org/IDataService/GetDataItemByIdResponse")]
        AskBargainsServices.Client.DataService.DataItem GetDataItemById(long dataItmeId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataServiceChannel : AskBargainsServices.Client.DataService.IDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceClient : System.ServiceModel.ClientBase<AskBargainsServices.Client.DataService.IDataService>, AskBargainsServices.Client.DataService.IDataService {
        
        public DataServiceClient() {
        }
        
        public DataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AskBargainsServices.Client.DataService.DataItem[] GetAllDataItems(int topNumber) {
            return base.Channel.GetAllDataItems(topNumber);
        }
        
        public AskBargainsServices.Client.DataService.DataItem GetDataItemById(long dataItmeId) {
            return base.Channel.GetDataItemById(dataItmeId);
        }
    }
}
