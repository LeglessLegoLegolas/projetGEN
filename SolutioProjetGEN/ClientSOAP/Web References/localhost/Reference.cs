﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18449
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Ce code source a été automatiquement généré par Microsoft.VSDesigner, Version 4.0.30319.18449.
// 
#pragma warning disable 1591

namespace ClientSOAP.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IMesServices", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class MesServices : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback m_serviceOperationCompleted;
        
        private System.Threading.SendOrPostCallback authentificationOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MesServices() {
            this.Url = "http://localhost:1993/MesServicesWCF";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event m_serviceCompletedEventHandler m_serviceCompleted;
        
        /// <remarks/>
        public event authentificationCompletedEventHandler authentificationCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://localhost:1993/MesServicesWCF/IMesServices/m_service", RequestNamespace="http://localhost:1993/MesServicesWCF", ResponseNamespace="http://localhost:1993/MesServicesWCF", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Stg m_service(Stg msg) {
            object[] results = this.Invoke("m_service", new object[] {
                        msg});
            return ((Stg)(results[0]));
        }
        
        /// <remarks/>
        public void m_serviceAsync(Stg msg) {
            this.m_serviceAsync(msg, null);
        }
        
        /// <remarks/>
        public void m_serviceAsync(Stg msg, object userState) {
            if ((this.m_serviceOperationCompleted == null)) {
                this.m_serviceOperationCompleted = new System.Threading.SendOrPostCallback(this.Onm_serviceOperationCompleted);
            }
            this.InvokeAsync("m_service", new object[] {
                        msg}, this.m_serviceOperationCompleted, userState);
        }
        
        private void Onm_serviceOperationCompleted(object arg) {
            if ((this.m_serviceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.m_serviceCompleted(this, new m_serviceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://localhost:1993/MesServicesWCF/IMesServices/authentification", RequestNamespace="http://localhost:1993/MesServicesWCF", ResponseNamespace="http://localhost:1993/MesServicesWCF", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool authentification(string login, string password) {
            object[] results = this.Invoke("authentification", new object[] {
                        login,
                        password});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void authentificationAsync(string login, string password) {
            this.authentificationAsync(login, password, null);
        }
        
        /// <remarks/>
        public void authentificationAsync(string login, string password, object userState) {
            if ((this.authentificationOperationCompleted == null)) {
                this.authentificationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnauthentificationOperationCompleted);
            }
            this.InvokeAsync("authentification", new object[] {
                        login,
                        password}, this.authentificationOperationCompleted, userState);
        }
        
        private void OnauthentificationOperationCompleted(object arg) {
            if ((this.authentificationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.authentificationCompleted(this, new authentificationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://localhost:1993/MesServicesWCF")]
    public partial class Stg {
        
        private string _infoField;
        
        private object[] _dataField;
        
        private string _operationNameField;
        
        private string _tokenApllField;
        
        private string _tokenUserField;
        
        private bool _statut_opField;
        
        /// <remarks/>
        public string _info {
            get {
                return this._infoField;
            }
            set {
                this._infoField = value;
            }
        }
        
        /// <remarks/>
        public object[] _data {
            get {
                return this._dataField;
            }
            set {
                this._dataField = value;
            }
        }
        
        /// <remarks/>
        public string _operationName {
            get {
                return this._operationNameField;
            }
            set {
                this._operationNameField = value;
            }
        }
        
        /// <remarks/>
        public string _tokenApll {
            get {
                return this._tokenApllField;
            }
            set {
                this._tokenApllField = value;
            }
        }
        
        /// <remarks/>
        public string _tokenUser {
            get {
                return this._tokenUserField;
            }
            set {
                this._tokenUserField = value;
            }
        }
        
        /// <remarks/>
        public bool _statut_op {
            get {
                return this._statut_opField;
            }
            set {
                this._statut_opField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void m_serviceCompletedEventHandler(object sender, m_serviceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class m_serviceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal m_serviceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Stg Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Stg)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    public delegate void authentificationCompletedEventHandler(object sender, authentificationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class authentificationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal authentificationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591