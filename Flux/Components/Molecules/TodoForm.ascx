<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TodoForm.ascx.cs" Inherits="FormsFluxProto.Flux.Components.Molecules.TodoForm" %>
<%@ Register Assembly="FormsFluxAtoms" Namespace="FormsFlux.Atoms" TagPrefix="FF" %>

<div>
    <FF:FFTextbox runat="server" ID="todo_text"/>
    <FF:FFButton runat="server" Text="create" OnClick="Create_Btn_Clicked"/>
</div>