<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="EjemploWebForm.index" %>

<!DOCTYPE html>
<html lang="es-es">
<head runat="server">
<meta charset="utf-8"/>
    <title></title>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
     
<!-- Optional theme -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">
<script   src="http://code.jquery.com/jquery-2.2.4.min.js"   integrity="sha256-BbhdlvQf/xTY9gja0Dq3HiwQF8LaCRTXxZKRutelT44="   crossorigin="anonymous"></script>
<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" ID="ScripManager" />
    <div>
        <asp:Menu ID="Menu1" runat="server">
            <Items>
                <asp:MenuItem NavigateUrl="~/index.aspx" Text="Pagina principal" Value="Pagina principal"></asp:MenuItem>
            </Items>
        </asp:Menu>
    <asp:UpdatePanel runat="server">
       <ContentTemplate>
        <asp:Button ID="btnCrearUsuario" OnClick="btnCrearUsuario_Click" runat="server" Text="Crear" />
            <asp:GridView DataKeyNames="id" OnRowCommand="grdv_Usuarios_RowCommand" ID="grdv_Usuarios" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False">
                <Columns>                    
                    <asp:BoundField DataField="id" Visible="False" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre Usuario" Visible="true" />
                    <asp:BoundField DataField="apellidos" HeaderText="Apellidos" Visible="true" />
                    <asp:BoundField DataField="password" HeaderText="Pass" Visible="true" />
                    <asp:BoundField DataField="fNacimiento" HeaderText="Fnacimiento" Visible="true" />
                    <asp:BoundField DataField="email" HeaderText="Email" Visible="true" />
                    <asp:BoundField DataField="borrado" HeaderText="borrado" Visible="true" />
                    <asp:ButtonField CommandName="editUsuario" Text="Editar" ControlStyle-CssClass="btn btn-info">
                        <ControlStyle CssClass="btn btn-info" />
                     </asp:ButtonField>
                    <asp:ButtonField CommandName="deleteUsuario" Text="Borrar" ControlStyle-CssClass="btn btn-danger">
                        <ControlStyle CssClass="btn btn-danger" />
                     </asp:ButtonField>
                </Columns>
            </asp:GridView>
        </ContentTemplate>
      </asp:UpdatePanel>
         

 <div class="modal fade" id="editModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" id="exampleModalLabel">Formulario</h4>
      </div>
      <div class="modal-body">
       <asp:Label runat="server" ID="lblIdUsuario" Visible="false" Text=""></asp:Label>
            <div class="form-group">          
                <asp:Label runat="server" ID="lblNombre" Visible="true" Text="Nombre:"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" Text="" CssClass="form-control"></asp:TextBox>
            </div>
          <div class="form-group">
             <asp:Label runat="server" ID="lblApellidos" Visible="true" Text="Apellidos:"></asp:Label>
             <asp:TextBox ID="txtApellidos" runat="server" Text="" CssClass="form-control"></asp:TextBox>
          </div>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
            <asp:Button runat="server" OnClick="btnGuardarUsuario_Click"  id="btnGuardarUsuario" Text="Guardar" />
          </div>
             </ContentTemplate>
            </asp:UpdatePanel>
        </div>
      </div>
    </div>
</div>

    
<div class="modal fade" id="deleteConfirm" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" id="">Borrar</h4>
      </div>
      <div class="modal-body">
          
          <asp:Label ID="lblMensaje" runat="server" Text="¿Seguro de borrar?"></asp:Label>
          <asp:TextBox ID="txtdelIdUsuario" runat="server" Enabled="false" Visible="false"></asp:TextBox>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
        <asp:Button id="btnBorrado" OnClick="btnDelete_Click" runat="server" Text="Aceptar"></asp:Button>
      </div>
    </div>
  </div>
</div>
    </form>
</body>
</html>
