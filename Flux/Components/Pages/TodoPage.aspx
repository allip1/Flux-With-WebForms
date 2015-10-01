<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TodoPage.aspx.cs" Inherits="FormsFluxProto.Flux.Components.Pages.TodoPage" %>

<%@ Register Assembly="FormsFluxAtoms" Namespace="FormsFlux.Atoms" TagPrefix="FFAtoms" %>
<%@ Register Src="../Molecules/TodoRow.ascx" TagName="TodoRow" TagPrefix="FF" %>
<%@ Register Src="../Molecules/TodoForm.ascx" TagName="TodoForm" TagPrefix="FF" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" ID="smanager" />
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <FFAtoms:FFLabel runat="server" ID="header"></FFAtoms:FFLabel>
                <asp:Repeater runat="server" ID="Row_Repeater" OnItemDataBound="RenderRows">
                    <ItemTemplate>
                        <FF:TodoRow runat="server" ID="todoRow" OnRemove_Clicked_Handler="Handle_Remove_Click" OnIsDone_Toggle_Handler="Handle_Toggle_Click" />
                    </ItemTemplate>
                </asp:Repeater>
                <FF:TodoForm OnSubmit_Todo="Handle_Todo_Submit" runat="server"/>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
