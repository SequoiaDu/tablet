﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.269
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")>  _
Partial Friend NotInheritable Class ClientSetting
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As ClientSetting = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New ClientSetting()),ClientSetting)
    
    Public Shared ReadOnly Property [Default]() As ClientSetting
        Get
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.WebServiceUrl),  _
     Global.System.Configuration.DefaultSettingValueAttribute("http://localhost:19951/ServiceMessage")>  _
    Public ReadOnly Property ServerURL() As String
        Get
            Return CType(Me("ServerURL"),String)
        End Get
    End Property
End Class
