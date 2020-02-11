<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aluno.aspx.cs" Inherits="MXM.TreinamentoWebForm2.Web.Treinamento.Aluno" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ResourceManager ID="ResourceManager1" runat="server">
        </ext:ResourceManager>

        <ext:Viewport ID="Viewport1" runat="server" Layout="BorderLayout">
            <Items>
                <ext:Panel ID="Panel1" runat="server"
                    Region="Center" Padding="6" Layout="AnchorLayout" Height="2000">
                    <Items>

                        <ext:TextField runat="server" FieldLabel="Matrícula" ID="txfMatricula" Width="600"></ext:TextField>
                        <ext:TextField runat="server" FieldLabel="Nome" ID="txfNome" Anchor="100%"></ext:TextField>
                        <ext:TextField runat="server" MaskRe="[0-9]" FieldLabel="CPF" ID="txfCPF" Width="600"></ext:TextField>



                        <ext:GridPanel runat="server" ID="grpMateria" Height="200">
                            <Store>
                                <ext:Store runat="server" ID="grpMateriaStore">
                                    <Reader>
                                        <ext:JsonReader>
                                            <Fields>
                                                <ext:RecordField Name="Disciplina"></ext:RecordField>
                                            </Fields>
                                        </ext:JsonReader>
                                    </Reader>
                                </ext:Store>
                            </Store>
                            <ColumnModel>
                                <Columns>
                                    <ext:Column Header="Disciplinas" DataIndex="Disciplina"></ext:Column>
                                </Columns>
                            </ColumnModel>
                            <SelectionModel>
                                <ext:CheckboxSelectionModel runat="server"></ext:CheckboxSelectionModel>
                            </SelectionModel>
                        </ext:GridPanel>


                    </Items>
                </ext:Panel>
                <ext:Panel runat="server" ButtonAlign="Center"
                    Region="South">
                    <Buttons>
                        <ext:Button runat="server" ID="btnGravar"
                            Text="Gravar" Icon="DatabaseSave">
                        </ext:Button>
                        <ext:Button runat="server"
                            ID="btnExcluir" Icon="Delete" Text="Excluir">
                        </ext:Button>
                    </Buttons>
                </ext:Panel>
            </Items>
        </ext:Viewport>
    </form>
</body>
</html>
