<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teste.aspx.cs" Inherits="MXM.TreinamentoWebForm2.Web.Treinamento.Teste" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        var prepare = function (value, rec) {
            rec.City = value.City;
            rec.StreetAddress = value.StreetAddress;
        };

        function alertaBR(valor) {
            alert(valor);
        }

        function clique(componente, e) {
            alert('evento');
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager ID="ResourceManager1" runat="server">
        </ext:ResourceManager>

        <ext:Viewport ID="Viewport1" runat="server" Layout="BorderLayout">
            <Items>
                <ext:Panel ID="pnlSuperior" runat="server" Collapsible="True" Height="100"
                    Region="North" Split="True" Title="North" Layout="AnchorLayout">
                    <Items>
                        <ext:TextField runat="server" ID="txfNome" AllowBlank="false"
                            FieldLabel="Nome do usuário" Anchor="100%">
                        </ext:TextField>
                        <ext:NumberField runat="server" ID="nbfIdade"></ext:NumberField>
                    </Items>
                </ext:Panel>
                <ext:Panel ID="Panel2" runat="server" Collapsible="true" Layout="Fit" Region="East" Split="true" Title="East" Width="175">
                    <Items>
                        <ext:TabPanel ID="TabPanel1" runat="server" ActiveTabIndex="0" Border="false" TabPosition="Bottom" Title="Title">
                            <Items>
                                <ext:Panel ID="Panel3" runat="server" Title="Tab 1">
                                    <Items></Items>
                                </ext:Panel>
                                <ext:Panel ID="Panel4" runat="server" Title="Tab 2">
                                    <Items></Items>
                                </ext:Panel>
                            </Items>
                        </ext:TabPanel>
                    </Items>
                </ext:Panel>
                <ext:Panel ID="Panel5" runat="server" ButtonAlign="Center"
                    Collapsible="true" Height="100" Region="South" Split="true" Title="South">
                    <Buttons>
                        <ext:Button runat="server" ID="btnGravar" Text="Gravar" Icon="PageSave"></ext:Button>

                        <ext:Button runat="server" ID="btnExcluir" Text="Excluir" Icon="Delete"></ext:Button>
                    </Buttons>
                </ext:Panel>
                <ext:Panel ID="Panel6" runat="server" Collapsible="true" Layout="accordion" Region="West" Split="true" Title="West" Width="175">
                    <Items>
                        <ext:Panel ID="Panel7" runat="server" Border="false" Collapsed="True" Icon="FolderGo" Title="Item 1">
                            <Items></Items>
                        </ext:Panel>
                        <ext:Panel ID="Panel8" runat="server" Border="false" Collapsed="true" Icon="FolderWrench" Title="Item 2">
                            <Items></Items>
                        </ext:Panel>
                    </Items>
                </ext:Panel>
                <ext:Panel ID="Panel9" runat="server" Layout="Fit" Region="Center" Title="Center">
                    <Items>
                        <ext:TabPanel ID="TabPanel2" runat="server" ActiveTabIndex="0" Border="false" Title="Center">
                            <Items>
                                <ext:Panel ID="Panel10" runat="server" Closable="true" Title="Tab 1">
                                    <Items>

                                        <ext:GridPanel
                                            ID="grpCliente"
                                            runat="server"
                                            Title="Customers"
                                            Height="300">
                                            <Store>
                                                <ext:Store ID="grpClienteStore" runat="server">
                                                    <Reader>
                                                        <ext:JsonReader>
                                                            <Fields>
                                                                <ext:RecordField Name="ID" Type="Int" />
                                                                <ext:RecordField Name="FirstName" />
                                                                <ext:RecordField Name="LastName" />
                                                                <ext:RecordField Name="Company" />
                                                                <ext:RecordField Name="Address">
                                                                    <Convert Fn="prepare" />
                                                                </ext:RecordField>
                                                                <ext:RecordField Name="City" />
                                                                <ext:RecordField Name="StreetAddress" />
                                                            </Fields>
                                                        </ext:JsonReader>
                                                    </Reader>
                                                </ext:Store>
                                            </Store>
                                            <ColumnModel runat="server">
                                                <Columns>
                                                    <ext:Column Header="ID" DataIndex="ID" />
                                                    <ext:Column Header="FirstName" DataIndex="FirstName" />
                                                    <ext:Column Header="LastName" DataIndex="LastName" />
                                                    <ext:Column Header="Company" DataIndex="Company" />
                                                    <ext:Column Header="City" DataIndex="City" />
                                                    <ext:Column Header="Street" DataIndex="StreetAddress" />
                                                </Columns>
                                            </ColumnModel>
                                            <LoadMask ShowMask="true" />
                                        </ext:GridPanel>
                                    </Items>
                                </ext:Panel>
                                <ext:Panel ID="Panel11" runat="server" Title="Tab 2">
                                    <Items></Items>
                                </ext:Panel>
                            </Items>
                        </ext:TabPanel>
                    </Items>
                </ext:Panel>
            </Items>
        </ext:Viewport>
    </form>
</body>
</html>
