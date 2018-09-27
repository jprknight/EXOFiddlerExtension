﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EXOFiddlerInspector.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"HTTP 502: False Positive. By design Office 365 Autodiscover does not respond to autodiscover.contoso.onmicrosoft.com for example on port 443. 
Validate this message by confirming this is an Office 365 IP address and perform a telnet to the IP address on port 80. 
If you get a response on port 80 and no response on port 443, this is more than likely an Autodiscover VIP which by design redirects the request to a secure Autodiscover resource.")]
        public string HTTP502AutodiscoverFalsePositive {
            get {
                return ((string)(this["HTTP502AutodiscoverFalsePositive"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"HTTP 403: Forbidden. Is your firewall or web proxy blocking Outlook connectivity? 
To fire this message a HTTP 403 response code was detected and ""Access Denied"" was found in the response body. 
Check the Raw and WebView tabs, do you see anything which indicates traffic is blocked?


")]
        public string HTTP403WebProxyBlocking {
            get {
                return ((string)(this["HTTP403WebProxyBlocking"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HTTP 503: FederatedSTSUnreachable.\r\nThe fedeation service is unreachable or unava" +
            "ilable. Check the Raw tab for additional details.\r\nCheck the realm page for the " +
            "authenticating domain.")]
        public string HTTP503FederatedSTSUnreachableStart {
            get {
                return ((string)(this["HTTP503FederatedSTSUnreachableStart"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://en.wikipedia.org/wiki/List_of_HTTP_status_codes")]
        public string HTTPStatusCodesURL {
            get {
                return ((string)(this["HTTPStatusCodesURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HTTP 200: Errors found in response body. Check the Raw tab, click \'View in Notepa" +
            "d\' button bottom right, and search for error in the response to review.\r\n")]
        public string HTTP200ErrorsFound {
            get {
                return ((string)(this["HTTP200ErrorsFound"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HTTP 401: Unauthorized. These are expected and are not an issue as long as a subs" +
            "equent HTTP 200 is seen for authentication to the server which issued the HTTP 4" +
            "01 unauthorized security challenge.")]
        public string HTTP401Unauthorized {
            get {
                return ((string)(this["HTTP401Unauthorized"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"While HTTP 403's can be symptomatic of a proxy server blocking traffic, the phrase 'Access Denied' was not detected in the response body. A small number of HTTP 403's can be seen in normal working scenarios. Check the Raw and WebView tabs to look for anything which looks suspect.")]
        public string HTTP403Generic {
            get {
                return ((string)(this["HTTP403Generic"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HTTP 429: Kind of sounds bad, needs to be taken into context with the rest of the" +
            " sessions. A small number is probably not an issue, larger numbers of these coul" +
            "d be cause for concern.")]
        public string HTTP429TooManyRequests {
            get {
                return ((string)(this["HTTP429TooManyRequests"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"Expected responses:
AuthURL: Normally expected to show federation service logon page.
STSAuthURL: Normally expected to show HTTP 400
MEXURL: Normally expected to show long stream of XML data.

If any of these show the HTTP 503 Service Unavailable this confirms a consistent failure on the federation service.
If however you get the expected responses, this does not neccessarily mean the federation service / everything authentication is healthy.")]
        public string HTTP503FederatedSTSUnreachableEnd {
            get {
                return ((string)(this["HTTP503FederatedSTSUnreachableEnd"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("The quantity of these types of server errors need to be considered in context wit" +
            "h what you are troubleshooting and whether these are relevant or not. A small nu" +
            "mber is probably not an issue, larger numbers of these could be cause for concer" +
            "n.")]
        public string HTTPQuantity {
            get {
                return ((string)(this["HTTPQuantity"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"HTTP 307: Temporary Redirects have been seen to redirect Exchange Online Autodiscover calls back to On-Premise resources, breaking Outlook connectivity.
Check the Headers or Raw tab and the Location to ensure the Autodiscover call is going to the correct place.
If this session is not for an Outlook process then the information above may not be relevant to the issue under investigation.")]
        public string HTTP307TemporaryRedirect {
            get {
                return ((string)(this["HTTP307TemporaryRedirect"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"HTTP 307: Temporary Redirects have been seen to redirect Exchange Online Autodiscover calls back to On-Premise resources, breaking Outlook connectivity.
This session has enough data points to be an Autodiscover request for Exchange Online which has not been sent to https://autodiscover-s.outlook.com/autodiscover/autodiscover.xml as expected.
Check the Headers or Raw tab and the Location to ensure the Autodiscover call is going to the correct place.")]
        public string HTTP307IncorrectTemporaryRedirect {
            get {
                return ((string)(this["HTTP307IncorrectTemporaryRedirect"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/jprknight/EXOFiddlerExtension/master/EXOFiddler" +
            "Inspector/update.xml")]
        public string UpdateURL {
            get {
                return ((string)(this["UpdateURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/jprknight/EXOFiddlerExtension/releases/download/1.0.18/EXOFidd" +
            "lerInspectorInstaller.msi")]
        public string InstallerURL {
            get {
                return ((string)(this["InstallerURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/jprknight/EXOFiddlerExtension/wiki")]
        public string WikiURL {
            get {
                return ((string)(this["WikiURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/jprknight/EXOFiddlerExtension/issues")]
        public string ReportIssuesURL {
            get {
                return ((string)(this["ReportIssuesURL"]));
            }
        }
    }
}
