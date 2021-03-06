﻿<AspNetHostingPermission(SecurityAction.LinkDemand, Level:=AspNetHostingPermissionLevel.Minimal), AspNetHostingPermission(SecurityAction.InheritanceDemand, Level:=AspNetHostingPermissionLevel.Minimal)> _
Public Class LabScriptReferenceCollection
    Inherits List(Of LabScriptReference)

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal scripts As IEnumerable(Of LabScriptReference))
        MyBase.New(scripts)
    End Sub

End Class
