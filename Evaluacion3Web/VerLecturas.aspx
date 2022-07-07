<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="Evaluacion3Web.VerLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
     <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Lectura</h3>
                </div>
                <div class="card-body">
                    <%--<div class="form-group">
                        <label for="tipoDb1">Filtrar por Tipo</label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="tipoDb1_SelectedIndexChanged" runat="server" ID="tipoDb1">
                            <asp:ListItem Value="1" Text="5000"></asp:ListItem>
                            <asp:ListItem Value="2" Text="5500"></asp:ListItem>
                            <asp:ListItem Value="3" Text="6000"></asp:ListItem>
                        </asp:DropDownList>

                    </div>--%>
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        EmptyDataText="No hay Lecturas" ShowHeader="true"
                        OnRowCommand="grillaLecturas_RowCommand"
                        AutoGenerateColumns="false" runat="server" ID="grillaLecturas">
                        <Columns>
                            <asp:BoundField DataField="Numero" HeaderText="Numero Lectura" />
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha Lectura" />
                            <%--<asp:BoundField DataField="TipoTxt" HeaderText="Tipo Rewards" />--%>
                            <%--<asp:BoundField DataField="BebidaFavorita.Nombre" HeaderText="Favorita" />--%>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button 
                                        CommandName="eliminar"
                                        CommandArgument='<%# Eval("Numero")%>'
                                        runat="server" 
                                        CssClass="btn bg-danger" Text="Eliminar" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
