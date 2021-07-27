<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarPunto.aspx.cs" Inherits="MedidoresWeb.RegistrarPunto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-12 col-md-6 col-lg-5 mx-auto">
            <div>
                <asp:Label ID="mensajeLbl" CssClass="text-success h1" runat="server"></asp:Label>
            </div>
            <div class="card col-8 mx-auto">
                <div class="card-header bg-dark text-white text-center">
                    <h5>Registrar Punto de Carga</h5>
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
                        <label class="form-label" for="tipoRbl">Tipo</label>
                        <asp:RadioButtonList runat="server" ID="tipoRbl">
                            <asp:ListItem Value="1" Text="Eléctrico" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Dual"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="mb-3">
                        <label class="form-label" for="capacidadTxt">Capacidad Máxima</label>
                        <asp:TextBox runat="server" type="number" ID="capacidadTxt" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Debe ingresar Capacidad Máxima"
                            ControlToValidate="capacidadTxt" CssClass="text-danger"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Solo valores numéricos"
                            ControlToValidate="capacidadTxt" CssClass="text-danger"
                            ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                    </div>
                    <div class="row mb-3">
                        <label class="form-label" for="fechaTxt">Fecha de Vencimiento</label>
                        <div class="col-4">
                            <asp:TextBox runat="server" ID="fechaTxt" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-2">
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/img/calendario.png"
                                ImageAlign="AbsBottom"
                                Width="20px" Height="20px"
                                OnClick="ImageButton1_Click" />
                            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"
                                OnDayRender="Calendar1_DayRender"
                                Width="200px" Height="180px" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black">
                                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                                <NextPrevStyle VerticalAlign="Bottom" />
                                <OtherMonthDayStyle ForeColor="#808080" />
                                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                                <SelectorStyle BackColor="#CCCCCC" />
                                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                                <WeekendDayStyle BackColor="#FFFFCC" />
                            </asp:Calendar>
                        </div>
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
