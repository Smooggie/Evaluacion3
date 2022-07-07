<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="DefaultLectura.aspx.cs" Inherits="Evaluacion3Web.DefaultLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
     <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensaje">
                <asp:Label runat="server" ID="mensajeLb1" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Lectura</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="numeroTxt">Numero</label>
                        <asp:TextBox ID="numeroTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="consumoTxt">Consumo</label>
                        <asp:TextBox ID="consumoTxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <!-- <div class="form-group">
                        <label for="lecturaDd1">Bebida Favorita</label>
                        <asp:DropDownList runat="server" ID="lecturaDd1" CssClass="form-select">
                            
                        </asp:DropDownList>
                    </div> -->
                    <div class="form-group">
                        <label for="tipoRb1">Tipo</label>
                        <asp:RadioButtonList runat="server" ID="tipoRb1">
                            <asp:ListItem Selected="True" Value="1" Text="5000"></asp:ListItem>
                            <asp:ListItem Value="2" Text="5500"></asp:ListItem>
                            <asp:ListItem Value="3" Text="6000"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn2" OnClick="agregarBtn2_Click" Text="Agregar" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
