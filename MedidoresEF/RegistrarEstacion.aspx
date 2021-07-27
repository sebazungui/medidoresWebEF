<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarEstacion.aspx.cs" Inherits="MedidoresWeb.RegistrarEstacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">

    <div class="row mt-5">
        <div class="col-12 col-md-6 col-lg-5 mx-auto">
            <div>
                <asp:Label ID="mensajeLbl" CssClass="text-success h1" runat="server"></asp:Label>
            </div>
            <div class="card col-8 mx-auto">
                <div class="card-header bg-dark text-white text-center">
                    <h5>Registrar Estación</h5>                    
                </div>
                <div class="card-body">
                    <div class="mb-3">
                        <label class="form-label" for="idTxt">Id</label>
                        <asp:TextBox runat="server" ID="idTxt" CssClass="form-control"></asp:TextBox>
                        <asp:CustomValidator ID="idCV" runat="server" ErrorMessage="CustomValidator"
                            CssClass="text-danger"
                            ControlToValidate="idTxt"
                            OnServerValidate="idCV_ServerValidate"
                            ValidateEmptyText="true"></asp:CustomValidator>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="capacidadTxt">Capacidad Máxima</label>
                        <asp:TextBox runat="server" type="number" ID="capacidadTxt" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe ingresar Capacidad Máxima"
                            ControlToValidate="capacidadTxt" CssClass="text-danger"></asp:RequiredFieldValidator>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="direccionTxt">Dirección</label>
                        <asp:TextBox runat="server" ID="direccionTxt" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe ingresar dirección"
                            ControlToValidate="direccionTxt" CssClass="text-danger"></asp:RequiredFieldValidator>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="ciudadTxt">Ciudad</label>
                        <asp:TextBox runat="server" ID="ciudadTxt" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Debe ingresar ciudad"
                            ControlToValidate="ciudadTxt" CssClass="text-danger"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="card-footer d-grid gap-1">
                    <asp:Button runat="server" ID="ingresarBtn" CssClass="btn btn-primary" style="font-size:large" Text="Registrar"
                        OnClick="ingresarBtn_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
