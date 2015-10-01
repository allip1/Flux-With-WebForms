<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TodoRow.ascx.cs" Inherits="FormsFluxProto.Flux.Components.Molecules.TodoRow" %>
<%@ Register Assembly="FormsFluxAtoms" Namespace="FormsFlux.Atoms" TagPrefix="FF" %>

<div>
    <FF:FFCheckBox runat="server" ID="checked_cb" ViewStateMode="Enabled" OnCheckedChanged="Checkbox_IsDone_Clicked"/>
    <FF:FFLabel runat="server" ID="todo_text"/>
    <FF:FFButton runat="server" ID="remove_btn" Text="remove" OnClick="Btn_Remove_Clicked"/>
    <asp:HiddenField runat="server" ID="ID" />
</div>
 