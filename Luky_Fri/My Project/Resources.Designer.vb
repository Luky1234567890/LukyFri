﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Tento kód byl generován nástrojem.
'     Verze modulu runtime:4.0.30319.42000
'
'     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
'     dojde-li k novému generování kódu.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Tato třída byla automaticky generována třídou StronglyTypedResourceBuilder
    'pomocí nástroje podobného aplikaci ResGen nebo Visual Studio.
    'Chcete-li přidat nebo odebrat člena, upravte souboru .ResX a pak znovu spusťte aplikaci ResGen
    's parametrem /str nebo znovu sestavte projekt aplikace Visual Studio.
    '''<summary>
    '''  Třída prostředků se silnými typy pro vyhledávání lokalizovaných řetězců atp.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Vrací instanci ResourceManager uloženou v mezipaměti použitou touto třídou.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Luky_Fri.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Potlačí vlastnost CurrentUICulture aktuálního vlákna pro všechna
        '''  vyhledání prostředků pomocí třídy prostředků se silnými typy.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Vyhledává lokalizovaný prostředek typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property character() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("character", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Vyhledává lokalizovaný prostředek typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property character_jump() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("character_jump", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Vyhledává lokalizovaný prostředek typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property coming_soon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("coming_soon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Vyhledává lokalizovaný prostředek typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property shop_building_outside() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("shop_building_outside", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Vyhledává lokalizovaný prostředek typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property title() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("title", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Vyhledává lokalizovaný prostředek typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property tree() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("tree", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Vyhledává lokalizovaný prostředek typu System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property welcome_sign() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("welcome_sign", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
