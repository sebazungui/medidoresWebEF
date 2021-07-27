<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerEstacion.aspx.cs" Inherits="MedidoresWeb.VerEstacion" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">

    <div class="col-8 mt-5 mx-auto">

        <asp:GridView ID="estacionesGrid" runat="server"
            AutoGenerateColumns="false" CssClass="table table-hover text-center" OnRowCommand="estacionesGrid_RowCommand"
            EmptyDataText="No hay puntos de carga en el sistema">
            <Columns>
                <asp:BoundField HeaderText="Id Estación" DataField="Id" />
                <asp:BoundField HeaderText="Capacidad Máxima" DataField="CapacidadMaxima" />
                <asp:BoundField HeaderText="Dirección" DataField="Direccion" />
                <asp:BoundField HeaderText="Ciudad" DataField="Ciudad" />
                <asp:TemplateField HeaderText="Acciones">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" Text="Eliminar" CssClass="btn btn-danger"
                            CommandName="eliminar"
                            CommandArgument='<%# Eval("Id")%>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

